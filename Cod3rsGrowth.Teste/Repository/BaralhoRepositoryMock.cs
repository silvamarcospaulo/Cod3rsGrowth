using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using Cod3rsGrowth.Teste.Singleton;
using System;

namespace Cod3rsGrowth.Teste.Repository
{
    public class BaralhoRepositoryMock : IBaralhoRepository
    {
        public List<Baralho> tabelasBaralhos = SingletonTabelas.InstanciaBaralhos;

        public void Inserir(Baralho baralho)
        {
            tabelasBaralhos.Add(baralho);
        }
        public void Excluir(int idBaralho)
        {
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return tabelasBaralhos.FirstOrDefault(carta => carta.IdBaralho == idBaralho) ?? throw new Exception($"Baralho {idBaralho} Nao Encontrado");
        }

        public List<Baralho> ObterTodos()
        {
            return tabelasBaralhos;
        }
    }
}