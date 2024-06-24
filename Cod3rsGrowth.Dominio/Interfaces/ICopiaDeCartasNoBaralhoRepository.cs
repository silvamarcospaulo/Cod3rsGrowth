using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface ICopiaDeCartasNoBaralhoRepository
    {
        void Criar(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho);
        void Atualizar(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho);
        void Excluir(int idCopiaDeCartasNoBaralho);
        CopiaDeCartasNoBaralho ObterPorId(int idCopiaDeCartasNoBaralho);
        List<CopiaDeCartasNoBaralho> ObterTodos(CopiaDeCartasNoBaralhoFiltro filtro);
    }
}