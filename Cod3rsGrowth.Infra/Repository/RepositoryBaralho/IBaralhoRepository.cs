using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryBaralho
{
    public interface IBaralhoRepository
    {
        void Excluir(Baralho baralho);
        Baralho ObterPorId(int idBaralho);
        void Criar(Baralho baralho);
        void Atualizar(Baralho baralho);
        List<Baralho> ObterTodos();
    }
}