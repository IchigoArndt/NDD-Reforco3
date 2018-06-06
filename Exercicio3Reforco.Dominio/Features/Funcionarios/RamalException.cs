using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Reforco.Dominio.Features.Funcionarios
{
    public class RamalException : Exception
    {
        public RamalException() : base("O Ramal não pode ser zerado")
        {

        }
    }
}
