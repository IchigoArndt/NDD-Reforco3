using Exercicio3Reforco.Aplicacao;
using Exercicio3Reforco.Dominio;
using Exercicio3Reforco.Dominio.Features.Alocacoes;
using FluentAssertions;
using Moq;
using NDD_Reforco3.Comum;
using NUnit.Framework;
using Projeto_loterica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDD_Reforco3.Aplicacao.Teste.Features.Alocacoes
{
    [TestFixture]
    public class AlocacaoAplicacaoTeste
    {
        AlocacaoServico alocacaoServico;
        Mock<IAlocacaoRepositorio> mockRepositorio;

        [SetUp]
        public void InitializeObjects()
        {

            mockRepositorio = new Mock<IAlocacaoRepositorio>();
            alocacaoServico = new AlocacaoServico(mockRepositorio.Object);
        }
        [Test]
        public void AlocacaoServico_CriarRepositorio_DeveFuncionar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoValida();
            alocacao.Id = 0;
            mockRepositorio.Setup(m => m.Adicionar(alocacao)).Returns(new Alocacao { Id = 1 });

            Alocacao result = alocacaoServico.Adicionar(alocacao);

            result.Id.Should().BeGreaterThan(0);
            mockRepositorio.Verify(m => m.Adicionar(alocacao));
        }

        [Test]
        public void AlocacaoServico_BuscaTodos_DeveFuncionar()
        {
            IList<Alocacao> ListaAlocacao = new List<Alocacao>();
            Alocacao alocacao = ObjectMother.ObterAlocacaoValida();
            ListaAlocacao.Add(alocacao);
            mockRepositorio.Setup(m => m.BuscarTodos()).Returns(ListaAlocacao);

            IList<Alocacao> Result = alocacaoServico.BuscarTodos();

            Result.First().Id.Should().Be(1);
            Result.Count().Should().Be(1);

            mockRepositorio.Verify(m => m.BuscarTodos());
        }

        [Test]
        public void AlocacaoServico_BuscaPorId_DeveFuncionar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoValida();
            mockRepositorio.Setup(m => m.BuscarPorId(alocacao.Id)).Returns(alocacao);

            Alocacao result = alocacaoServico.BuscarPorId(alocacao.Id);

            result.Should().NotBeNull();
            result.Id.Should().Be(1);

            mockRepositorio.Verify(m => m.BuscarPorId(alocacao.Id));
        }

        [Test]
        public void AlocacaoServico_Deletar_DeveFuncionar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoValida();
            mockRepositorio.Setup(m => m.Deletar(alocacao));

            alocacaoServico.Deletar(alocacao);
            mockRepositorio.Verify(m => m.Deletar(alocacao));
        }
        [Test]
        public void AlocacaoServico_AtualizarRepositorio_DeveFuncionar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoValida();

            alocacao.Id = 1;
            alocacao.Funcionario.NomeFuncionario = "Luiz 123";

            mockRepositorio.Setup(m => m.Atualizar(alocacao)).Returns(alocacao);

            Alocacao result = alocacaoServico.Atualizar(alocacao);

            result.Funcionario.NomeFuncionario.Should().Be(alocacao.Funcionario.NomeFuncionario);
        }

        [Test]
        public void AlocacaoServico_AtualizarRepositorio_DeveFalhar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoValida();

            alocacao.Id = 0;

            Action act = () => { alocacaoServico.Atualizar(alocacao); };

            act.Should().Throw<IdentifierUndefinedException>();
        }

        [Test]
        public void AlocacaoServico_DeletarRepositorio_DeveFalhar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoValida();

            alocacao.Id = 0;

            Action act = () => { alocacaoServico.Deletar(alocacao); };

            act.Should().Throw<IdentifierUndefinedException>();
        }

        [Test]
        public void AlocacaoServico_BuscarPorIdRepositorio_DeveFalhar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoValida();

            alocacao.Id = 0;

            Action act = () => { alocacaoServico.BuscarPorId(alocacao.Id); };

            act.Should().Throw<IdentifierUndefinedException>();
        }
        //////////////////////////////Criando os testes Deve falhar////
        [Test]
        public void AlocacaoServico_SalvarRepositorioComSalaNula_DeveFalhar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoInvalidaSala();

            Action act = () => { alocacaoServico.Adicionar(alocacao); };

            act.Should().Throw<NullReferenceException>();
        }
        [Test]
        public void AlocacaoServico_SalvarRepositorioComFuncionarioNulo_DeveFalhar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoInvalidaFuncionario();

            Action act = () => { alocacaoServico.Adicionar(alocacao); };

            act.Should().Throw<NullReferenceException>();
        }
        [Test]
        public void AlocacaoServico_SalvarRepositorioComDataNula_DeveFalhar()
        {
            Alocacao alocacao = ObjectMother.ObterAlocacaoInvalidaData();

            Action act = () => { alocacaoServico.Adicionar(alocacao); };

            act.Should().Throw<NullReferenceException>();
        }

    }
}
