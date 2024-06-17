using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryCarta
{
    public interface ICartaRepository
    {
        void Criar(Carta carta);
        void Atualizar(Carta carta);
        Carta ObterPorId(int idCarta);
        List<Carta> ObterTodos();
    }
}