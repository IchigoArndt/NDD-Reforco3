using Exercicio3Reforco.Dominio;
using Exercicio3Reforco.Dominio.Features.Funcionarios;
using Exercicio3Reforco.Dominio.Features.Salas;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDD_Reforco3.Comum.Features.Salas
{
   public class SalaDominioTeste
    {
        [Test]
        public void Sala_CriarSala_DeveFuncionar()
        {
            Sala sala = ObjectMother.ObterSalaValido();
            sala.Validar();
            sala.Id.Should().Be(1);
        }
        [Test]
        public void Sala_CriarSalaComNomeSalaInvalido_DeveFalhar()
        {
            Sala sala = ObjectMother.ObterSalaInvalidoNomeSala();
            Action act = sala.Validar;
            act.Should().Throw<StringVaziaOuNulaException>();

        }
        [Test]
        public void Sala_CriarSalaComSalaComQuantidadeLugaresZerado_DeveFalhar()
        {
            Sala sala = ObjectMother.ObterSalaInvalidoQuantidadeLugares();
            Action act = sala.Validar;
            act.Should().Throw<QuantidadeLugaresZeradoException>();
        }
    }
}
