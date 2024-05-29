using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using Cod3rsGrowth.Teste.Singleton;
using System;

namespace Cod3rsGrowth.Teste.Repository
{
    public class BaralhoRepositoryMock : IBaralhoRepository
    {
        public void Excluir(int idBaralho)
        {
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return new Baralho();
        }

        public List<Baralho> ObterTodos()
        {
            return tabelasBaralhos;
        }
    }
}