using Entity.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Entity.Entities
{
    /// <summary>
    /// Classe com propriedades para todas as classe 
    /// </summary>
    public class Base : Notifica
    {
        public Base()
        {

        }
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Display(Name ="Nome")]
        public string Nome { get; set; }
    }
}
