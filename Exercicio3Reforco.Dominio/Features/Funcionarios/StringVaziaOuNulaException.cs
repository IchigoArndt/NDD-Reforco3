using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Reforco.Dominio.Features.Funcionarios
{
    public class StringVaziaOuNulaException : Exception
    {
        public StringVaziaOuNulaException() : base("O campo não pode ficar vazio ou ser nula")
        {

        }
    }
}
