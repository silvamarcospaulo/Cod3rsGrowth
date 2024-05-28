using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using Cod3rsGrowth.Teste.TestesJogador;
using System;

namespace Cod3rsGrowth.Teste.TestesBaralho
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
            return new List<Baralho>();
        }
    }
}