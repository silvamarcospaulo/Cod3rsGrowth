using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;

namespace Cod3rsGrowth.Servicos.ServicoJogador
{
    public class ServicoJogador : IServicoJogador
    {
        public IJogadorRepository _IJogadorRepository;
        public ServicoJogador(IJogadorRepository jogadorRepository)
        {
            _IJogadorRepository = jogadorRepository;
        }
        public void Inserir(Jogador jogador)
        {
            _IJogadorRepository.Inserir(jogador);
        }
        public Jogador ObterPorId(string idJogador)
        {
            return _IJogadorRepository.ObterPorId(idJogador);
        }
        public List<Jogador> ObterTodos()
        {
            return _IJogadorRepository.ObterTodos();
        }
        public decimal SomarPrecoDeTodasAsCartasDoJogador(Jogador jogador)
        {
            return jogador.BaralhosJogador.SelectMany(baralhos => baralhos.CartasDoBaralho)
                .Sum(carta => carta.QuantidadeCopiasDaCartaNoBaralho * carta.Carta.PrecoCarta);
        }

        public int SomarQuantidadeDeBaralhosDoJogador(Jogador jogador)
        {
            return jogador.QuantidadeDeBaralhosJogador;
        }

        public bool verificaIdJdogador(string idJogador)
        {
            var quantidadeDeDigitosCpf = 11;
            if(idJogador == null) return false;
            if(idJogador.Length != quantidadeDeDigitosCpf) return false;

            int verificacaoValorNumerosEsquerdaCpfDigitoUm = 0;
            for (int contador = 0; contador < 9; contador++){
                verificacaoValorNumerosEsquerdaCpfDigitoUm += (Convert.ToInt32(idJogador[contador]) * (quantidadeDeDigitosCpf - (contador + 1)));
            }
            if ((((verificacaoValorNumerosEsquerdaCpfDigitoUm * 10) % quantidadeDeDigitosCpf) < 2) && (idJogador[10] != 0)) return false;
            if (idJogador[10] != (quantidadeDeDigitosCpf - (verificacaoValorNumerosEsquerdaCpfDigitoUm % quantidadeDeDigitosCpf))) return false;

            int verificacaoValorNumerosEsquerdaCpfDigitoDois = 0;
            for (int contador = 0; contador < 10; contador++)
            {
                verificacaoValorNumerosEsquerdaCpfDigitoDois += (Convert.ToInt32(idJogador[contador]) * (quantidadeDeDigitosCpf - contador));
            }
            if ((((verificacaoValorNumerosEsquerdaCpfDigitoDois * 10) % quantidadeDeDigitosCpf) < 2) && (idJogador[11] != 0)) return false;
            if (idJogador[11] != (quantidadeDeDigitosCpf - (verificacaoValorNumerosEsquerdaCpfDigitoDois % quantidadeDeDigitosCpf))) return false;

            return true;
        }
    }
}