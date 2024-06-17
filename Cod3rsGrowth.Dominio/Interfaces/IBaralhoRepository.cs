using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryBaralho
{
    public interface IBaralhoRepository
    {
        void Criar(Baralho baralho);
        void Atualizar(Baralho baralho);
        void Excluir(Baralho baralho);
        List<Baralho> ObterTodos();
        Baralho ObterPorId(int idBaralho);
    }
}