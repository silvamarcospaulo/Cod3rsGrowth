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
        public JogadorServico(IJogadorRepository jogadorRepository, BaralhoServico baralhoServico,
            CartaServico cartaServico, IValidator<Jogador> validadorJogador)
        {
            _IJogadorRepository = jogadorRepository;
            _baralhoServico = baralhoServico;
            _cartaServico = cartaServico;
            _validadorJogador = validadorJogador;
        }

        private static decimal SomarPrecoDeTodasAsCartasDoJogador(List<Baralho>? baralhosJogador)
        {
            const int valorNulo = 0;

            if (baralhosJogador.IsNullOrEmpty()) return valorNulo;
            return baralhosJogador.SelectMany(baralhos => baralhos.CartasDoBaralho)
                .Sum(carta => carta.QuantidadeCopiasDaCartaNoBaralho * carta.Carta.PrecoCarta);
        }

        private static int SomarQuantidadeDeBaralhosDoJogador(List<Baralho>? baralhosJogador)
        {
            const int valorNulo = 0;

            if (baralhosJogador.IsNullOrEmpty()) return valorNulo;
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
            const int valorNulo = 0;

            jogador.BaralhosJogador = null;
            jogador.QuantidadeDeBaralhosJogador = valorNulo;
            jogador.PrecoDasCartasJogador = valorNulo;
            jogador.ContaAtivaJogador = false;
            jogador.Role = roleJogador;

            try
            {
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
            const int valorNulo = 0;

            var jogadorAtualizar = ObterPorId(jogador.Id);

            jogadorAtualizar.ContaAtivaJogador = VerificaJogadorAtivoOuDesavado(jogadorAtualizar.BaralhosJogador);
            jogadorAtualizar.PrecoDasCartasJogador = SomarPrecoDeTodasAsCartasDoJogador(jogadorAtualizar.BaralhosJogador);
            jogadorAtualizar.QuantidadeDeBaralhosJogador = SomarQuantidadeDeBaralhosDoJogador(jogadorAtualizar.BaralhosJogador);

            if (jogador?.SenhaHashConfirmacaoJogador is not null)
            {
                jogadorAtualizar.SenhaHashJogador = HashServico.Gerar(jogador.SenhaHashJogador);
                jogadorAtualizar.SenhaHashConfirmacaoJogador = HashServico.Gerar(jogador.SenhaHashConfirmacaoJogador);
            }

            if(jogador?.UsuarioConfirmacaoJogador is not null)
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
            jogador.BaralhosJogador = _baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = idJogador });
            return jogador;
        }

        public Jogador AutenticaLogin(Jogador jogador)
        {
            var jogadorExistente = ObterTodos(new JogadorFiltro() { UsuarioJogador = jogador.UsuarioJogador }).First();

            if (HashServico.Comparar(jogador.SenhaHashJogador, jogadorExistente.SenhaHashJogador))
            {
                return Atualizar(jogadorExistente);
            }

            return null;
        }

        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            const int valorNulo = 0;

            var jogadores = _IJogadorRepository.ObterTodos(filtro);

            foreach (var jogador in jogadores)
            {
                if (jogador?.BaralhosJogador?.Count > valorNulo)
                {
                    jogador.BaralhosJogador = _baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = jogador?.Id });
                }
            }
            return jogadores;
        }
    }
}