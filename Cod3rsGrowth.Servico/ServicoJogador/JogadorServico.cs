using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;

namespace Cod3rsGrowth.Servico.ServicoJogador
{
    public class JogadorServico : IJogadorRepository
    {
        private readonly IJogadorRepository _IJogadorRepository;
        private readonly IBaralhoRepository _IBaralhoRepository;
        private readonly IValidator<Jogador> _validadorJogador;
        public JogadorServico(IJogadorRepository jogadorRepository, IBaralhoRepository baralhoRepository,
            IValidator<Jogador> validadorJogador)
        {
            _IJogadorRepository = jogadorRepository;
            _IBaralhoRepository = baralhoRepository;
            _validadorJogador = validadorJogador;
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

        private static bool VerificaJogadorAtivoOuDesavado(List<Baralho> baralhosJogador)
        {
            if (baralhosJogador.IsNullOrEmpty()) return false;
            return true;
        }

        public void Criar(Jogador jogador)
        {
            jogador.BaralhosJogador = null;
            jogador.QuantidadeDeBaralhosJogador = SomarQuantidadeDeBaralhosDoJogador(jogador.BaralhosJogador);
            jogador.PrecoDasCartasJogador = SomarPrecoDeTodasAsCartasDoJogador(jogador.BaralhosJogador);
            jogador.ContaAtivaJogador = VerificaJogadorAtivoOuDesavado(jogador.BaralhosJogador);

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
            jogadorAtualizado.ContaAtivaJogador = VerificaJogadorAtivoOuDesavado(jogadorAtualizado.BaralhosJogador);
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

        public void Excluir(int idJogador)
        {
            var jogadorExcluir = ObterPorId(idJogador);

            try
            {
                _validadorJogador.Validate(jogadorExcluir, options =>
                {
                    options.ThrowOnFailures();
                    options.IncludeRuleSets("Excluir");
                });
                _IJogadorRepository.Excluir(jogadorExcluir.IdJogador);
            }
            catch (ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public Jogador ObterPorId(int idJogador)
        {
            var jogador = new Jogador();
            jogador = _IJogadorRepository.ObterPorId(idJogador);
            var filtro = new BaralhoFiltro() { IdJogador = idJogador };
            jogador.BaralhosJogador.AddRange(_IBaralhoRepository.ObterTodos(filtro));
            jogador.BaralhosJogador.ForEach(o => o.CartasDoBaralho.ForEach();
            return jogador;
        }

        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            var jogadores = new List<Jogador>();
            jogadores.AddRange(_IJogadorRepository.ObterTodos(filtro));
            return jogadores;
        }
    }
}