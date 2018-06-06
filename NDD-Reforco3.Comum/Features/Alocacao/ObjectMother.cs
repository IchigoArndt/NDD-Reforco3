using System;
using Exercicio3Reforco.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NDD_Reforco3.Comum
{
    public static partial class ObjectMother
    {
      public static Alocacao ObterAlocacaoValida()
       {
            return new Alocacao
            {
                Id = 1,
                DataAlocacao = DateTime.Now,
                Funcionario  = new Funcionario { Id = 1,Cargo  = "Desenvolvedor",NomeFuncionario = "Luiz",Ramal = 0467 },
                Sala = new Sala { Id = 1,nomeSala = "Sala de Reunião",QuantidadeLugares = 32}
            };
       }
      public static Alocacao ObterAlocacaoInvalidaSala()
        {
            return new Alocacao
            {
                Id = 1,
                DataAlocacao = DateTime.Now,
                Funcionario = new Funcionario { Id = 1, Cargo = "Desenvolvedor", NomeFuncionario = "Luiz", Ramal = 0467 },
                Sala = null
            };
        }
        public static Alocacao ObterAlocacaoInvalidaFuncionario()
        {
            return new Alocacao
            {
                Id = 1,
                DataAlocacao = DateTime.Now,
                Funcionario = null,
                Sala = new Sala { Id = 1, nomeSala = "Sala de Reunião", QuantidadeLugares = 32 }
            };
        }
        public static Alocacao ObterAlocacaoInvalidaData()
        {
            return new Alocacao
            {
                Id = 1,
                DataAlocacao = null,
                Funcionario = new Funcionario { Id = 1, Cargo = "Desenvolvedor", NomeFuncionario = "Luiz", Ramal = 0467 },
                Sala = new Sala { Id = 1, nomeSala = "Sala de Reunião", QuantidadeLugares = 32 }
            };
        }
        public static Alocacao ObterAlocacaoInvalidaId()
        {
            return new Alocacao
            {
                Id = 0,
                DataAlocacao = DateTime.Now,
                Funcionario = new Funcionario { Id = 1, Cargo = "Desenvolvedor", NomeFuncionario = "Luiz", Ramal = 0467 },
                Sala = new Sala { Id = 1, nomeSala = "Sala de Reunião", QuantidadeLugares = 32 }
            };
        }
    }
}
