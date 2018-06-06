using Exercicio3Reforco.Dominio.Features.Funcionarios;
using Exercicio3Reforco.Dominio.Features.Salas;
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
        public override void Validar()
        {
            if (string.IsNullOrEmpty(nomeSala))
                throw new StringVaziaOuNulaException();
            if (QuantidadeLugares == 0)
                throw new QuantidadeLugaresZeradoException();
        }
    }
}
