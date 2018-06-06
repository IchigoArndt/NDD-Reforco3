using System;
using Exercicio3Reforco.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NDD_Reforco3.Comum
{
    public static partial class ObjectMother
    {
      public static Funcionario ObterFuncionarioValido()
       {
            return new Funcionario
            {
                Id = 1,
                Cargo = "Desenvolvedor",
                NomeFuncionario = "Luiz",
                Ramal = 4667
            };
       }
      public static Funcionario ObterFuncionarioInvalidoNomeFuncionario()
        {
            return new Funcionario
            {
             Id = 1, Cargo = "Desenvolvedor", NomeFuncionario = "", Ramal = 0467,
            };
        }
        public static Funcionario ObterFuncionarioInvalidoCargo()
        {
            return new Funcionario
            {
               Id = 1, Cargo = "", NomeFuncionario = "Luiz", Ramal = 0467,
            };
        }
        public static Funcionario ObterFuncionarioInvalidoRamalZerado()
        {
            return new Funcionario
            {
               Id = 1, Cargo = "Desenvolvedor", NomeFuncionario = "Luiz ", Ramal = 0,
            };
        }
    }
}
