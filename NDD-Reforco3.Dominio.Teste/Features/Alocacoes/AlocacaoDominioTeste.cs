using System;
using Exercicio3Reforco.Dominio;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDD_Reforco3.Comum;
using NUnit.Framework;

namespace NDD_Reforco3.Dominio.Teste
{
    [TestFixture]
    public class AlocacaoDominioTeste
    {
       [Test]
       public void Alocacao_CriarAlocacao_DeveFuncionar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoValida();
            alocacao.Validar();
            alocacao.Id.Should().Be(1);
        }
        [Test]
        public void Alocacao_CriarAlocacaoComSalaNula_DeveFalhar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoInvalidaSala();
            Action act = alocacao.Validar;
            act.Should().Throw<NullReferenceException>();

        }
        [Test]
        public void Alocacao_CriarAlocacaoComFuncionarioNulo_DeveFalhar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoInvalidaFuncionario();
            Action act = alocacao.Validar;
            act.Should().Throw<NullReferenceException>();
        }
        [Test]
        public void Alocacao_CriarAlocacaoComDataInvalida_DeveFalhar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoInvalidaData();
            Action act = alocacao.Validar;
            act.Should().Throw<NullReferenceException>();
        }
    }
}