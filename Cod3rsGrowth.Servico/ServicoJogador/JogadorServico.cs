using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoAuth;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;

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
            var jogadorBanco = ObterTodos(new JogadorFiltro { UsuarioJogador = usuario });

            if (jogadorBanco?.Count() != VALOR_NULO) throw new Exception ("Usuário indisponível!");

            return true;
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
            var jogadorAtualizar = ObterPorId(jogador.Id);

            jogadorAtualizar.ContaAtivaJogador = VerificaJogadorAtivoOuDesavado(jogadorAtualizar.BaralhosJogador);
            jogadorAtualizar.PrecoDasCartasJogador = SomarPrecoDeTodasAsCartasDoJogador(jogadorAtualizar.BaralhosJogador);
            jogadorAtualizar.QuantidadeDeBaralhosJogador = SomarQuantidadeDeBaralhosDoJogador(jogadorAtualizar.BaralhosJogador);

            if (jogador?.SenhaHashConfirmacaoJogador is not null)
            {
                jogadorAtualizar.SenhaHashJogador = HashServico.Gerar(jogador.SenhaHashJogador);
                jogadorAtualizar.SenhaHashConfirmacaoJogador = HashServico.Gerar(jogador.SenhaHashConfirmacaoJogador);
            }

            if (jogador?.UsuarioConfirmacaoJogador is not null)
            {
                jogadorAtualizar.UsuarioJogador = jogador.UsuarioJogador;
                jogadorAtualizar.UsuarioConfirmacaoJogador = jogador.UsuarioConfirmacaoJogador;
            }

            try
            {
                _validadorJogador.Validate(jogadorAtualizar, options =>
                {
                    options.ThrowOnFailures();
                    options.IncludeRuleSets("Atualizar");
                });
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
            var jogadorExcluir = ObterPorId(idJogador);

            try
            {
                _baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = idJogador })?.ForEach(baralho => _baralhoServico.Excluir(baralho.Id));

                _IJogadorRepository.Excluir(jogadorExcluir.Id);
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
            var oi = _baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = idJogador });
            jogador.BaralhosJogador = oi;
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