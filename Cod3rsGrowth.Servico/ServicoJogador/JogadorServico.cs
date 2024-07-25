using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoAuth;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace Cod3rsGrowth.Servico.ServicoJogador
{
    public class JogadorServico : IJogadorRepository
    {
        private readonly IJogadorRepository _IJogadorRepository;
        private readonly BaralhoServico _baralhoServico;
        private readonly CartaServico _cartaServico;
        private readonly IValidator<Jogador> _validadorJogador;
        private const int VALOR_NULO = 0;

        public JogadorServico(IJogadorRepository jogadorRepository, BaralhoServico baralhoServico,
            CartaServico cartaServico, IValidator<Jogador> validadorJogador)
        {
            _IJogadorRepository = jogadorRepository;
            _baralhoServico = baralhoServico;
            _cartaServico = cartaServico;
            _validadorJogador = validadorJogador;
        }

        private bool ValidacaoUsuarioDisponível(string usuario)
        {
            return ObterTodos(new JogadorFiltro { UsuarioJogador = usuario }).Any() ? throw new Exception($"Usuário {usuario} indisponível.") : true;
        }

        private static decimal SomarPrecoDeTodasAsCartasDoJogador(List<Baralho>? baralhosJogador)
        {
            if (baralhosJogador.IsNullOrEmpty()) return VALOR_NULO;
            return baralhosJogador.SelectMany(baralhos => baralhos.CartasDoBaralho)
                .Sum(carta => carta.QuantidadeCopiasDaCartaNoBaralho * carta.Carta.PrecoCarta);
        }

        private static int SomarQuantidadeDeBaralhosDoJogador(List<Baralho>? baralhosJogador)
        {
            if (baralhosJogador.IsNullOrEmpty()) return VALOR_NULO;
            return baralhosJogador.Count;
        }

        private static bool VerificaJogadorAtivoOuDesavado(List<Baralho>? baralhosJogador)
        {
            if (baralhosJogador.IsNullOrEmpty()) return false;
            return true;
        }

        public int Criar(Jogador jogador)
        {
            const string roleJogador = "Jogador";

            jogador.BaralhosJogador = null;
            jogador.QuantidadeDeBaralhosJogador = VALOR_NULO;
            jogador.PrecoDasCartasJogador = VALOR_NULO;
            jogador.ContaAtivaJogador = false;
            jogador.Role = roleJogador;

            try
            {
                ValidacaoUsuarioDisponível(jogador.UsuarioJogador);

                _validadorJogador.Validate(jogador, options =>
                {
                    options.ThrowOnFailures();
                    options.IncludeRuleSets("Criar");
                });

                jogador.SenhaHashJogador = HashServico.Gerar(jogador.SenhaHashJogador);
                return _IJogadorRepository.Criar(jogador);
            }
            catch (ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public Jogador? Atualizar(Jogador jogador)
        {
            try
            {
                var jogadorBanco = ObterPorId(jogador.Id);

                var jogadorAtualizar = new Jogador();

                jogadorAtualizar.ContaAtivaJogador = VerificaJogadorAtivoOuDesavado(jogador.BaralhosJogador);
                jogadorAtualizar.PrecoDasCartasJogador = SomarPrecoDeTodasAsCartasDoJogador(jogador.BaralhosJogador);
                jogadorAtualizar.QuantidadeDeBaralhosJogador = SomarQuantidadeDeBaralhosDoJogador(jogador.BaralhosJogador);
                jogadorAtualizar.SenhaHashJogador = jogador.SenhaHashJogador;
                jogadorAtualizar.SenhaHashConfirmacaoJogador = jogador.SenhaHashConfirmacaoJogador;
                jogadorAtualizar.UsuarioJogador = jogador.UsuarioJogador;
                jogadorAtualizar.UsuarioConfirmacaoJogador = jogador.UsuarioConfirmacaoJogador;

                _validadorJogador.Validate(jogadorAtualizar, options =>
                {
                    options.ThrowOnFailures();
                    options.IncludeRuleSets("Atualizar");
                });

                jogadorAtualizar.SenhaHashJogador = jogador?.SenhaHashJogador is not null ? HashServico.Gerar(jogador.SenhaHashJogador) : jogadorBanco.SenhaHashJogador;
                jogadorAtualizar.UsuarioJogador = jogador?.UsuarioJogador is not null ? (ValidacaoUsuarioDisponível(jogador.UsuarioJogador) ? jogador.UsuarioJogador : jogadorBanco.UsuarioJogador) : jogadorBanco.UsuarioJogador;

                jogadorAtualizar.NomeJogador = jogadorBanco.NomeJogador;
                jogadorAtualizar.SobrenomeJogador = jogadorBanco.SobrenomeJogador;
                jogadorAtualizar.Role = jogadorBanco.Role;
                jogadorAtualizar.DataNascimentoJogador = jogadorBanco.DataNascimentoJogador;
                jogadorAtualizar.DataDeCriacaoContaJogador = jogadorBanco.DataDeCriacaoContaJogador;
                jogadorAtualizar.Id = jogadorBanco.Id;

                return _IJogadorRepository.Atualizar(jogadorAtualizar);
            }
            catch (ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public void AlterarSenha(Jogador jogador)
        {
            try
            {
                var jogadorBanco = ObterTodos(new JogadorFiltro()
                {
                    NomeJogador = jogador.NomeJogador,
                    SobrenomeJogador = jogador.SobrenomeJogador,
                    UsuarioJogador = jogador.UsuarioJogador,
                    DataNascimentoJogador = jogador.DataNascimentoJogador
                }).FirstOrDefault() ?? throw new Exception("Nenhum resultado para os dados inseridos. Tente novamente com outras informações.");

                _validadorJogador.Validate(jogador, options =>
                {
                    options.ThrowOnFailures();
                    options.IncludeRuleSets("AlterarSenha");
                });

                jogadorBanco.SenhaHashJogador = HashServico.Gerar(jogador.SenhaHashJogador);

                _IJogadorRepository.Atualizar(jogadorBanco);
            }
            catch (ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public void Excluir(int idJogador)
        {
            try
            {
                _IJogadorRepository.Excluir(idJogador);
            }
            catch (ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public Jogador ObterPorId(int idJogador)
        {
            var jogador = _IJogadorRepository.ObterPorId(idJogador);
            jogador.BaralhosJogador = _baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = idJogador });

            return jogador;
        }

        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            var jogadores = _IJogadorRepository.ObterTodos(filtro);

            return jogadores;
        }

        public static Jogador AutenticaUsuarioSenhaJogador(Jogador jogador, JogadorServico jogadorServico)
        {
            var jogadorBanco = jogadorServico.ObterTodos(new JogadorFiltro() { UsuarioJogador = jogador.UsuarioJogador }).First();

            if (HashServico.Comparar(jogador.SenhaHashJogador, jogadorBanco?.SenhaHashJogador)) return jogadorBanco;

            return null;
        }

        public static Jogador ObtemIdJogador(string nomeJogador, JogadorServico jogadorServico)
        {
            var jogador = jogadorServico.ObterTodos(new JogadorFiltro() { UsuarioJogador = nomeJogador }).First();
            return jogador;
        }
    }
}