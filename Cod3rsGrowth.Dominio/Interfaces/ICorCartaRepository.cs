using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface ICorCartaRepository
    {
        void Criar(CorCarta corCarta);
        List<CorCarta> ObterTodos(CorCartaFiltro? filtro);
    }
}