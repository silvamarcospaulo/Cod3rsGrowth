using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryBaralho
{
    public interface IBaralhoRepository
    {
        void Inserir(Baralho baralho);
        void Excluir(int idBaralho);
        Baralho ObterPorId(int idBaralho);
        List<Baralho> ObterTodos();
    }
}