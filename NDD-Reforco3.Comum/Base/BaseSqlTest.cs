using Projeto_loterica.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_loterica.Common.Tests.Base
{
    public static class BaseSqlTest
    {
        private const string DELETE_ALOCACAO_TABLE = "DELETE FROM [dbo].[TBAlocacao] DBCC CHECKIDENT('[dbo].[TBAlocacao]', RESEED, 0)";
        private const string DELETE_FUNCIONARIO_TABLE = "DELETE FROM [dbo].[TBFuncionario] DBCC CHECKIDENT('[dbo].[TBFuncionario]', RESEED, 0)";
        private const string DELETE_SALA_TABLE = "DELETE FROM [dbo].[TBSala] DBCC CHECKIDENT('[dbo].[TBSala]', RESEED, 0)";
        
        private const string INSERT_ALOCACAO = "INSERT INTO TBAlocacao(IdSala,IdFuncionario,DataAlocacao) VALUES (1,1,GETDATE())";
        private const string INSERT_FUNCIONARIO = "INSERT INTO TBFuncionario(Nome,Cargo,Ramal) VALUES ('Luiz','Desenvolvedor',4667)";
        private const string INSERT_SALA = "INSERT INTO TBSala(Nome,QuantidadeLugares) VALUES ('Sala de Reunião',32)";

        public static void SeedDatabase()
        {
            Db.Update(DELETE_ALOCACAO_TABLE);
            Db.Update(DELETE_FUNCIONARIO_TABLE);
            Db.Update(DELETE_SALA_TABLE);
            //inserts
            Db.Update(INSERT_FUNCIONARIO);
            Db.Update(INSERT_SALA);
            Db.Update(INSERT_ALOCACAO);
        }
    }
}
