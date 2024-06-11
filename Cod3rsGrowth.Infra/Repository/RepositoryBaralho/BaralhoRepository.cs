using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryBaralho
{
    public class BaralhoRepository : IBaralhoRepository
    {
        public void Inserir(Baralho baralho)
        {
        }
        public void Excluir(Baralho baralho)
        {
            throw new NotImplementedException();
        }

        public Baralho ObterPorId(int idBaralho)
        {
            throw new NotImplementedException();
        }

        public List<Baralho> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}