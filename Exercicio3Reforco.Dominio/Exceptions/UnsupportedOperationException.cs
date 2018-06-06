﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_loterica.Domain.Exceptions
{
    public class UnsupportedOperationException : Exception
    {
        public UnsupportedOperationException() : base("Operação não suportada")
        {

        }
    }
}
