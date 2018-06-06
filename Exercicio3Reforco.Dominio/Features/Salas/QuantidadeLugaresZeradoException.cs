using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Reforco.Dominio.Features.Salas
{
    public class QuantidadeLugaresZeradoException : Exception
    {
        public QuantidadeLugaresZeradoException() : base("A Quantidade de lugares não pode ser 0 ou menor")
        {

        }
    }
}
