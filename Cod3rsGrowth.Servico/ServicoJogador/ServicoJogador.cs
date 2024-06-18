using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation;
using FluentValidation.Results;

namespace Cod3rsGrowth.Servico.ServicoJogador
{
    public class ServicoJogador : IJogadorRepository
    {
        private readonly IJogadorRepository _IJogadorRepository;
        private readonly IValidator<Jogador> _validadorJogador;
        public ServicoJogador(IJogadorRepository jogadorRepository, IValidator<Jogador> validadorJogador)
        {
            _IJogadorRepository = jogadorRepository;
            _validadorJogador = validadorJogador;
        }

        private int GerarIdJogador()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var jogadores = _IJogadorRepository.ObterTodos();
            var ultimoId = jogadores.Any() ? jogadores.Max(carta => carta.IdJogador) : ValorInicial - Incremento;

            return ultimoId + Incremento;
        }

        private static decimal SomarPrecoDeTodasAsCartasDoJogador(List<Baralho> baralhosJogador)
        {
            if (baralhosJogador == null) return 0;
            return baralhosJogador.SelectMany(baralhos => baralhos.CartasDoBaralho)
                .Sum(carta => carta.QuantidadeCopiasDaCartaNoBaralho * carta.Carta.PrecoCarta);
        }

        private static int SomarQuantidadeDeBaralhosDoJogador(List<Baralho> baralhosJogador)
        {
            if (baralhosJogador == null) return 0;
            return baralhosJogador.Count;
        }

        public void Criar(Jogador jogador)
        {
            jogador.IdJogador = GerarIdJogador();
            jogador.PrecoDasCartasJogador = SomarPrecoDeTodasAsCartasDoJogador(jogador.BaralhosJogador);
            jogador.QuantidadeDeBaralhosJogador = SomarQuantidadeDeBaralhosDoJogador(jogador.BaralhosJogador);

            try
            {
                _validadorJogador.ValidateAndThrow(jogador);
                _IJogadorRepository.Criar(jogador);
            }
            catch (ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public void Atualizar(Jogador jogador)
        {
            var jogadorAtualizado = ObterPorId(jogador.IdJogador);
            jogadorAtualizado.BaralhosJogador = jogador.BaralhosJogador;
            jogadorAtualizado.PrecoDasCartasJogador = SomarPrecoDeTodasAsCartasDoJogador(jogadorAtualizado.BaralhosJogador);
            jogadorAtualizado.QuantidadeDeBaralhosJogador = SomarQuantidadeDeBaralhosDoJogador(jogadorAtualizado.BaralhosJogador);

            try
            {
                _validadorJogador.Validate(jogadorAtualizado, options =>
                {
                    options.ThrowOnFailures();
                    options.IncludeRuleSets("Atualizar");

                });
                _IJogadorRepository.Atualizar(jogadorAtualizado);
            }
            catch (ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public void Excluir(Jogador jogador)
        {
            var jogadorExcluir = ObterPorId(jogador.IdJogador);

            try
            {
                _validadorJogador.Validate(jogadorExcluir, options =>
                {
                    options.ThrowOnFailures();
                    options.IncludeRuleSets("Excluir");

                });
                _IJogadorRepository.Excluir(jogadorExcluir);
            }
            catch (ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public Jogador ObterPorId(int idJogador)
        {
            return _IJogadorRepository.ObterPorId(idJogador);
        }
        public List<Jogador> ObterTodos()
        {
            return _IJogadorRepository.ObterTodos();
        }
    }
}