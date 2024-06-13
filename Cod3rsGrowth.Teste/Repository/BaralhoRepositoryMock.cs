using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using Cod3rsGrowth.Teste.Singleton;
using System;

namespace Cod3rsGrowth.Teste.Repository
{
    public class BaralhoRepositoryMock : IBaralhoRepository
    {
        public List<Baralho> tabelasBaralhos = SingletonTabelas.InstanciaBaralhos;

        public void Criar(Baralho baralho)
        {
            tabelasBaralhos.Add(baralho);
        }

        public void Atualizar(Baralho baralho)
        {
            var baralhoBanco = ObterPorId(baralho.IdJogador);
            baralhoBanco = baralho;
        }
        public void Excluir(Baralho baralho)
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