using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class CorCartaServico : ICorCartaRepository
    {
        private readonly ICorCartaRepository _corCartaRepository;
        public CorCartaServico(ICorCartaRepository corCartaRepository)
        {
            _corCartaRepository = corCartaRepository;
        }

        public void Criar(CorCarta corCarta)
        {
            _corCartaRepository.Criar(corCarta);
        }

        public List<CorCarta> ObterTodos(CorCartaFiltro? filtro)
        {
            return _corCartaRepository.ObterTodos(filtro);
        }
    }
}