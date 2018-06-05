using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Reforco.Dominio
{
    public class Sala : Entidade
    {
        public string nomeSala { get; set; }
        public int QuantidadeLugares { get; set; }
        public bool Situacao { get; set; }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
