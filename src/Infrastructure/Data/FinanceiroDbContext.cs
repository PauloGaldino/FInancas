using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class FinanceiroDbContext : DbContext
    {
        public FinanceiroDbContext(DbContextOptions<FinanceiroDbContext> options) : base(options)
        {
            //Database.EnsureCreated();

        }
        public FinanceiroDbContext()
        {

        }

       public DbSet<Base> Bases { set; get; }
       public DbSet<SistemaFinanceiro> SistemaFinanceiro { set; get; } 
        public DbSet<Categoria> Categoria { set; get; }
       public DbSet<Compra> Compra { set; get; }
       public DbSet<ItemCompra> ItemCompra { get; set; }
        public DbSet<Despesa> Despesas { set; get; }
        public DbSet<Sugestao> Sugestoes { set; get; }
        public DbSet<UsuarioSistemaFinanceiro>UsuarioSistemaFinanceiros { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado

            ////Utilizando Sql Server
            //if (!optionsBuilder.IsConfigured)
            //    optionsBuilder.UseMySql(GetStringConectionConfig());

            //Utilizando o Mysql
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql(GetStringConectionConfig());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConectionConfig()
        {
            //string strCon = "Data Source=PAULO_DESCKTOP;Initial Catalog=FINACEIRO_2020;Integrated Security=False;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
     
            // string strCon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SG_Fabrica; Integrated Security=False;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
           
            string strCon = "Data Source = localhost;port=3308;database=Dna_Financeiro;user=root;password=toor";
            return strCon;
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }


            }
            return base.SaveChanges();
        }
        

      
    }
}
