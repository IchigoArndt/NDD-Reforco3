using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Reforco.Dominio.Features.Alocacoes
{
    public class DataInicalMaiorQueDataFinalException : Exception
    {
        public DataInicalMaiorQueDataFinalException() : base("A data inicial não pode ser maior que a data final")
        {

        }
    }
}
