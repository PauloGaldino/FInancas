using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Entities
{
    [Table("Sugestao")]
    public class Sugestao 
    {
        [Key()]
        public int SugestaoId { get; set; }

        [Display(Name = "Sugestão")]
        public string DescricaoSugestao { get; set; }

        [Display(Name = "E-mail do Usuário")]
        public string EmailUsuario { get; set; }
    }
}
