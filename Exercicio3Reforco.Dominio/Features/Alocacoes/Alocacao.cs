using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Reforco.Dominio
{
    public class Alocacao : Entidade
    {
        public Sala Sala { get; set; }
        public Funcionario Funcionario {get;set;}
        public DateTime DataAlocacao { get; set; }
        public string Duracao { get; set; }
        public void CriarAlocacao(IList<Alocacao> alocacoes, Sala sala, DateTime Data)
        {
            if(this.VerificarDisponibilidadeSala(alocacoes,sala,Data) == true)
            {
                sala.Situacao = false;
            }
        }
        public bool VerificarDisponibilidadeSala(IList<Alocacao> alocacoes,Sala sala,DateTime Data)
        {
            bool Livre = false;
            foreach(var item in alocacoes)
            {
                if (item.Sala == sala && item.DataAlocacao == Data)
                    Livre = false;
                else
                    Livre = true;
            }
            return Livre;

        }
        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
