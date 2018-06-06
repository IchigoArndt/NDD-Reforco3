using Exercicio3Reforco.Dominio.Features.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Reforco.Dominio
{
    public class Funcionario : Entidade
    {
        public string NomeFuncionario { get; set; }
        public string Cargo { get; set; }
        public int Ramal { get; set; }

        public override void Validar()
        {
            if(string.IsNullOrEmpty(NomeFuncionario))
            {
                throw new StringVaziaOuNulaException();
            }
            if(string.IsNullOrEmpty(Cargo))
            {
                throw new StringVaziaOuNulaException();
            }
            if(Ramal == 0)
            {
                throw new RamalException();
            }
        }
    }
}
