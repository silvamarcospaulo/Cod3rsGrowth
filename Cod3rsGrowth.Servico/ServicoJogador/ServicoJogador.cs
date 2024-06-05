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
    }
}