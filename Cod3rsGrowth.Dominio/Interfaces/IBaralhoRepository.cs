using System;
using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface IBaralhoRepository
    {
        void Criar(Baralho baralho);
        void Atualizar(Baralho baralho);
        void Excluir(int idBaralho);
        Baralho ObterPorId(int idBaralho);
        List<Baralho> ObterTodos(BaralhoFiltro? filtro);
    }
}