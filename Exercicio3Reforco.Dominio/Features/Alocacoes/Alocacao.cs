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
        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
