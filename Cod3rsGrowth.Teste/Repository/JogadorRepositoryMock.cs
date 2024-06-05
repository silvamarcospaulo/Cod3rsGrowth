using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Teste.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste.Repository
{
    public class JogadorRepositoryMock : IJogadorRepository
    {
        public List<Jogador> tabelasJogadores = SingletonTabelas.InstanciaJogadores;

        public void Inserir(Jogador jogador)
        {
            tabelasJogadores.Add(jogador);
        }

        public void Excluir(int idJogador)
        {
        }

        public Jogador ObterPorId(string idJogador)
        {
            return verificaIdJdogador(idJogador) == false ? throw new Exception("Valor Invalido")
                : tabelasJogadores.FirstOrDefault(carta => carta.IdJogador == idJogador) ?? throw new Exception("Jogador Nao Encontrado");
        }

        public List<Jogador> ObterTodos()
        {
            return tabelasJogadores;
        }

        public bool verificaIdJdogador(string idJogador)
        {
            var quantidadeDeDigitosCpf = 11;
            if (idJogador == null) return false;
            if (idJogador.Length != quantidadeDeDigitosCpf) return false;

            int verificacaoValorNumerosEsquerdaCpfDigitoUm = 0;
            for (int contador = 0; contador < 9; contador++)
            {
                verificacaoValorNumerosEsquerdaCpfDigitoUm += (Convert.ToInt32(idJogador[contador]) * (quantidadeDeDigitosCpf - (contador + 1)));
            }
            if ((((verificacaoValorNumerosEsquerdaCpfDigitoUm * 10) % quantidadeDeDigitosCpf) < 2) && (idJogador[10] != 0)) return false;
            if (Convert.ToInt32(idJogador[10]) != (quantidadeDeDigitosCpf - ((verificacaoValorNumerosEsquerdaCpfDigitoUm * 10) % quantidadeDeDigitosCpf))) return false;

            int verificacaoValorNumerosEsquerdaCpfDigitoDois = 0;
            for (int contador = 0; contador < 10; contador++)
            {
                verificacaoValorNumerosEsquerdaCpfDigitoDois += (Convert.ToInt32(idJogador[contador]) * (quantidadeDeDigitosCpf - contador));
            }
            if ((((verificacaoValorNumerosEsquerdaCpfDigitoDois * 10) % quantidadeDeDigitosCpf) < 2) && (idJogador[11] != 0)) return false;
            if (Convert.ToInt32(idJogador[11]) != (quantidadeDeDigitosCpf - ((verificacaoValorNumerosEsquerdaCpfDigitoDois * 10) % quantidadeDeDigitosCpf))) return false;

            return true;
        }
    }
}