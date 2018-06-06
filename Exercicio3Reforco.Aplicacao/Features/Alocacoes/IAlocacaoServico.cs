using Exercicio3Reforco.Aplicacao.Base;
using Exercicio3Reforco.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Reforco.Aplicacao.Features.Alocacoes
{
   public interface IAlocacaoServico : IServico<Alocacao>
    {
        Alocacao ReaLocarSala(Sala sala, DateTime Data, Funcionario funcionario, Sala NovaSala, DateTime NovaData);
        bool VerificarDisponibilidadeSala(Sala sala, DateTime data);
    }
}
