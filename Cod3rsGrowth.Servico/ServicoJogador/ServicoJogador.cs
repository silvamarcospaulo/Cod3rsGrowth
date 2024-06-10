using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Microsoft.Extensions.Options;

namespace Cod3rsGrowth.Servicos.ServicoJogador
{
    public class ServicoJogador : IServicoJogador
    {
        private readonly IJogadorRepository _IJogadorRepository;
        private readonly ValidadorJogador _validadorJogador;
        public ServicoJogador(IJogadorRepository jogadorRepository, ValidadorJogador validadorJogador)
        {
            _IJogadorRepository = jogadorRepository;
            _validadorJogador = validadorJogador;
        }
        private void Inserir(Jogador jogador)
        {
            _IJogadorRepository.Inserir(jogador);
        }

        public Jogador ObterPorId(int idJogador)
        {
            return _IJogadorRepository.ObterPorId(idJogador);
        }

        public List<Jogador> ObterTodos()
        {
            return _IJogadorRepository.ObterTodos();
        }

        private int GerarIdJogador()
        {
            return _IJogadorRepository.ObterTodos().Any() ? _IJogadorRepository.ObterTodos().Max(jogador => jogador.IdJogador) + 1 : 1;
        }

        private decimal SomarPrecoDeTodasAsCartasDoJogador(List<Baralho> baralhosJogador)
        {
            if (baralhosJogador == null) return 0;
            return baralhosJogador.SelectMany(baralhos => baralhos.CartasDoBaralho)
                .Sum(carta => carta.QuantidadeCopiasDaCartaNoBaralho * carta.Carta.PrecoCarta);
        }

        private int SomarQuantidadeDeBaralhosDoJogador(List<Baralho> baralhosJogador)
        {
            if (baralhosJogador == null) return 0;
            return baralhosJogador.Count;
        }

        public void CriarJogador(Jogador jogador)
        {
            jogador.IdJogador = GerarIdJogador();
            jogador.PrecoDasCartasJogador = SomarPrecoDeTodasAsCartasDoJogador(jogador.BaralhosJogador);
            jogador.QuantidadeDeBaralhosJogador = SomarQuantidadeDeBaralhosDoJogador(jogador.BaralhosJogador);

            var validador = _validadorJogador.Validate(jogador);

            if (validador.IsValid)
            {
                _IJogadorRepository.Inserir(jogador);
            }else
            {
                var erro = string.Join(Environment.NewLine, validador.Errors.Select(e => e.ErrorMessage));
                throw new Exception(erro);
            };
        }
    }
}