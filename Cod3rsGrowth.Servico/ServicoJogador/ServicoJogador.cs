using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using FluentValidation;
using FluentValidation.Results;

namespace Cod3rsGrowth.Servicos.ServicoJogador
{
    public class ServicoJogador : IServicoJogador
    {
        private readonly IJogadorRepository _IJogadorRepository;
        private readonly IValidator<Jogador> _validadorJogador;
        public ServicoJogador(IJogadorRepository jogadorRepository, IValidator<Jogador> validadorJogador)
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

        public ValidationResult CriarJogador(Jogador jogador)
        {
            jogador.IdJogador = GerarIdJogador();
            jogador.PrecoDasCartasJogador = SomarPrecoDeTodasAsCartasDoJogador(jogador.BaralhosJogador);
            jogador.QuantidadeDeBaralhosJogador = SomarQuantidadeDeBaralhosDoJogador(jogador.BaralhosJogador);

            try
            {
                _validadorJogador.ValidateAndThrow(jogador);
                Inserir(jogador);
                return new ValidationResult();
            }
            catch (ValidationException e)
            {
                return new ValidationResult(e.Errors);
            }
        }
    }
}