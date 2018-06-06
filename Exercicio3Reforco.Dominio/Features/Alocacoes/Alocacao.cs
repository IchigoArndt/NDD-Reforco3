using Exercicio3Reforco.Dominio.Features.Alocacoes;
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
        public DateTime? DataAlocacao { get; set; }
        public override void Validar()
        {
            if (Sala == null)
                throw new NullReferenceException();
            if(Funcionario == null)
                throw new NullReferenceException();
            if (DataAlocacao == null)
                throw new NullReferenceException();
        }
}
}
