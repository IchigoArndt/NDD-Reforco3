using System;
using Exercicio3Reforco.Dominio;
using Exercicio3Reforco.Dominio.Features.Funcionarios;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDD_Reforco3.Comum;
using NUnit.Framework;

namespace NDD_Reforco3.Dominio.Teste
{
    [TestFixture]
    public class FuncionarioDominioTeste
    {
       [Test]
       public void Funcionario_CriarFuncionario_DeveFuncionar()
        {
            Funcionario funcionario = ObjectMother.ObterFuncionarioValido();
            funcionario.Validar();
            funcionario.Id.Should().Be(1);
        }
        [Test]
        public void Funcionario_CriarFuncionarioComNomeFuncionarioInvalido_DeveFalhar()
        {
            Funcionario funcionario = ObjectMother.ObterFuncionarioInvalidoNomeFuncionario();
            Action act = funcionario.Validar;
            act.Should().Throw<StringVaziaOuNulaException>();

        }
        [Test]
        public void Funcionario_CriarFuncionarioComFuncionarioComCargoVazio_DeveFalhar()
        {
            Funcionario funcionario = ObjectMother.ObterFuncionarioInvalidoCargo();
            Action act = funcionario.Validar;
            act.Should().Throw<StringVaziaOuNulaException>();
        }
        [Test]
        public void Funcionario_CriarFuncionarioComRamalZerado_DeveFalhar()
        {
            Funcionario funcionario = ObjectMother.ObterFuncionarioInvalidoRamalZerado();
            Action act = funcionario.Validar;
            act.Should().Throw<RamalException>();
        }
    }
}