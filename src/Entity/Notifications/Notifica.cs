using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Notifications
{
    public class Notifica
    {
        public Notifica()
        {
            notificacoes = new List<Notifica>();
        }
        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Messagem { get; set; }

        [NotMapped]
        public List<Notifica> notificacoes { get; set; }

        public bool ValidaPropridade(string valor, string nomePropriedade) 
        { 
            //Verifica se o campo da string está vazio
            if(string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notifica {
                            Messagem = "Campo obrigatório",
                            NomePropriedade = nomePropriedade
                });
                return false;
            }
            return true;
        }

        public bool ValidaPriedadeInt(int valor, string nomePropriedade)
        { 
            if(valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                //Verifica se o campo da inteiro está vazio
                notificacoes.Add(new Notifica {
                            Messagem = "Campo obrigatório",
                            NomePropriedade = "nomePropriedade"
                });
                return false;
            }
            return true;
        }
    }
}
