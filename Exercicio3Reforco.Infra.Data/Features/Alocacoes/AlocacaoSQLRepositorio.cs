using Exercicio3Reforco.Dominio;
using Exercicio3Reforco.Dominio.Features.Alocacoes;
using Projeto_loterica.Infra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Reforco.Infra.Data
{
    public class AlocacaoSQLRepositorio : IAlocacaoRepositorio
    {

        #region Queries
        private const string SQLInsert = "insert into   TBAlocacao(IdSala,IdFuncionario,DataAlocacao)values(@Sala,@Funcionario,@Data)";
        private const string SQLDelete = "delete from   TBAlocacao";
        private const string SQLGetById = "select * from TBAlocacao where Id = @Id";
        private const string SQLGetAll = "select * from TBAlocacao";
        private const string SQLUpdate = "update TBAlocacao set IdSala = @Sala, IdFuncionario = @Funcionario, DataAlocacao = @Data";
        #endregion


        public Alocacao Adicionar(Alocacao entidade)
        {
            entidade.Id = Db.Insert(SQLInsert, Take(entidade));
            return entidade;
        }

        public Alocacao Atualizar(Alocacao entidade)
        {
            Db.Update(SQLUpdate, Take(entidade));
            return entidade;
        }

        public Alocacao BuscarPorId(long id)
        {
            return Db.Get(SQLGetById, Make);
        }

        public IList<Alocacao> BuscarTodos()
        {
            return Db.GetAll(SQLGetAll, Make);
        }

        public void Deletar(Alocacao entidade)
        {
            Db.Delete(SQLDelete, Take(entidade));
        }

        private static Func<IDataReader, Alocacao> Make = reader =>
           new Alocacao
           {
               Id = Convert.ToInt64(reader["Id"]),
               DataAlocacao = Convert.ToDateTime(reader["DataAlocacao"]),
               Sala = new Sala { Id = Convert.ToInt64(reader["IdSala"]) },
               Funcionario = new Funcionario { Id = Convert.ToInt64(reader["IdFuncionario"]) }
           };
        public object[] Take(Alocacao alocacao)
        {
            return new object[]
            {
              "@Id",alocacao.Id,
              "@Data",alocacao.DataAlocacao,
              "@Sala",alocacao.Sala.Id,
              "@Funcionario",alocacao.Funcionario.Id
            };
        }
    }
}
