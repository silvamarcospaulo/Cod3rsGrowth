using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoCarta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class CorBaralhoServico : ICorBaralhoRepository
    {
        private readonly ICorBaralhoRepository _corBaralhoRepository;
        private readonly CartaServico _servicoCarta;

        public CorBaralhoServico(ICorBaralhoRepository corBaralhoRepository, CartaServico servicoCarta)
        {
            _corBaralhoRepository = corBaralhoRepository;
            _servicoCarta = servicoCarta;
        }

        public void Criar(CorBaralho corBaralho)
        {
            _corBaralhoRepository.Criar(corBaralho);
        }

        public void Excluir(int idCorBaralho)
        {
            _corBaralhoRepository.Excluir(idCorBaralho);
        }

        public CorBaralho ObterPorId(int idCorBaralho)
        {
            return _corBaralhoRepository.ObterPorId(idCorBaralho);
        }

        public List<CorBaralho> ObterTodos(CorBaralhoFiltro? filtro)
        {
            throw new NotImplementedException();
        }
    }
}