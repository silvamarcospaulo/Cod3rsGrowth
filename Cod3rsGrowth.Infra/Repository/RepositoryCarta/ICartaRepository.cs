using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryCarta
{
    public interface ICartaRepository
    {
        void Inserir(Carta carta);
        void Excluir(Carta carta);
        Carta ObterPorId(int idCarta);
        List<Carta> ObterTodos();
    }
}