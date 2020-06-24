using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities
{
    [Table("Categoria")]
    public class Categoria 
    {
        [Key()]
        public int CategoriaId { get; set; }

        //Chaves estrangeiras
        [Display(Name = "Código do Sistema")]
        [ForeignKey("SistemaFinanceiro")]
        [Column(Order = 1)]
        public int IdSistema { get; set; }
        public virtual SistemaFinanceiro SistemaFinanceiro { get; set; }
    }
}

