using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface ICorBaralhoRepository
    {
        void Criar(CorBaralho corBaralho);
        void Excluir (int idCorBaralho);
        CorBaralho ObterPorId(int idCorBaralho);
        List<CorBaralho> ObterTodos(CorBaralhoFiltro? filtro);
    }
}