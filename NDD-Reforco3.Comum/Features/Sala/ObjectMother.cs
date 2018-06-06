using System;
using Exercicio3Reforco.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NDD_Reforco3.Comum
{
    public static partial class ObjectMother
    {
      public static Sala ObterSalaValido()
       {
            return new Sala
            {
                Id = 1, nomeSala = "Sala de Reunião", QuantidadeLugares = 32
            };
       }
      public static Sala ObterSalaInvalidoNomeSala()
        {
            return new Sala
            {
                Id = 1, nomeSala = "", QuantidadeLugares = 32
            };
        }
        public static Sala ObterSalaInvalidoQuantidadeLugares()
        {
            return new Sala
            {
               Id = 1, nomeSala = "Sala de Reunião",QuantidadeLugares = 0
            };
        }

    }
}
