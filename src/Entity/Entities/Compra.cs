using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities
{
    /// <summary>
    /// Entidade da tabela reponsável peloa dados de cadastro de compra e alterações
    /// </summary>

    [Table("Compra")]
    public class Compra 
    {
        [Key()]
        public int CompraId { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Data de Alteração")]
        public DateTime DataAlteracao { get; set; }

        //Chave estrangeira
        [Display(Name = "Categoria")]
        [ForeignKey("Categoria")]
        [Column(Order = 1)]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
