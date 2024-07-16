using System;
using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface ICartaRepository
    {
        int Criar(Carta carta);
        void Atualizar(Carta carta);
        Carta ObterPorId(int idCarta);
        List<Carta> ObterTodos(CartaFiltro? filtro);
    }
}