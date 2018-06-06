using Exercicio3Reforco.Aplicacao.Features.Alocacoes;
using Exercicio3Reforco.Dominio;
using Exercicio3Reforco.Dominio.Features.Alocacoes;
using Projeto_loterica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Reforco.Aplicacao
{
    public class AlocacaoServico : IAlocacaoServico
    {
        IAlocacaoRepositorio _repositorio;

        public AlocacaoServico(IAlocacaoRepositorio Repositorio)
        {
            _repositorio = Repositorio;
        }

        public Alocacao Adicionar(Alocacao entidade)
        {
            entidade.Validar();
            return entidade = _repositorio.Adicionar(entidade);
        }

        public Alocacao Atualizar(Alocacao entidade)
        {
            entidade.Validar();
            if (entidade.Id != 0)
                entidade = _repositorio.Atualizar(entidade);
            else
                throw new IdentifierUndefinedException();
            return entidade;
        }

        public Alocacao BuscarPorId(long id)
        {
            if (id != 0)
                return _repositorio.BuscarPorId(id);
            else
                throw new IdentifierUndefinedException();
        }

        public IList<Alocacao> BuscarTodos()
        {
            return _repositorio.BuscarTodos();
        }

        public void Deletar(Alocacao entidade)
        {
            if (entidade.Id != 0)
                _repositorio.Deletar(entidade);
            else
                throw new IdentifierUndefinedException();
        }
        public Alocacao ReaLocarSala(Sala sala, DateTime data,Funcionario funcionario,Sala NovaSala,DateTime NovaData)
        {
            Alocacao alocacao = new Alocacao();
            IList<Alocacao> ListaAlocacao = _repositorio.BuscarTodos();
            foreach(var item in ListaAlocacao)
            {
                if (item.Sala == sala && item.DataAlocacao == data && item.Funcionario == funcionario)
                {
                    item.Sala = NovaSala;
                    item.DataAlocacao = data;
                    alocacao = item;
                }
            }
            alocacao = _repositorio.Atualizar(alocacao);
            return alocacao;
        }

        public bool VerificarDisponibilidadeSala(Sala sala, DateTime data)
        {
            bool Disponivel = false;
            IList<Alocacao> ListaAlocacao = _repositorio.BuscarTodos();
            foreach(var item in ListaAlocacao)
            {
                if (item.Sala == sala && item.DataAlocacao == data)
                    Disponivel =  false;
                else
                    Disponivel =  true;
            }
            return Disponivel;
        }
    }
}
