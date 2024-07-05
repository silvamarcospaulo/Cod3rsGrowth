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
            if (baralhosJogador == null) return 0;
            return baralhosJogador.SelectMany(baralhos => baralhos.CartasDoBaralho)
                .Sum(carta => carta.QuantidadeCopiasDaCartaNoBaralho * carta.Carta.PrecoCarta);
        }

        private static int SomarQuantidadeDeBaralhosDoJogador(List<Baralho>? baralhosJogador)
        {
            if (baralhosJogador == null) return 0;
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
                    options.IncludeRuleSets("CriarAtualizar");
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

        public void Atualizar(Jogador jogador)
        {
            var jogadorAtualizado = ObterPorId(jogador.Id);

            jogadorAtualizado.BaralhosJogador = jogador.BaralhosJogador;
            jogadorAtualizado.ContaAtivaJogador = VerificaJogadorAtivoOuDesavado(jogadorAtualizado.BaralhosJogador);
            jogadorAtualizado.PrecoDasCartasJogador = SomarPrecoDeTodasAsCartasDoJogador(jogadorAtualizado.BaralhosJogador);
            jogadorAtualizado.QuantidadeDeBaralhosJogador = SomarQuantidadeDeBaralhosDoJogador(jogadorAtualizado.BaralhosJogador);

            try
            {
                _validadorJogador.Validate(jogadorAtualizado, options =>
                {
                    options.ThrowOnFailures();
                    options.IncludeRuleSets("CriarAtualizar");

                });
                _IJogadorRepository.Atualizar(jogadorAtualizado);
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
            jogador.BaralhosJogador = ObterTodosBaralhoJogador(idJogador);
            return jogador;
        }

        public Jogador AutenticaLogin(Jogador jogador)
        {
            var jogadorExistente = ObterTodos(new JogadorFiltro() { UsuarioJogador = jogador.UsuarioJogador}).First();
            if (HashServico.Comparar(jogador.SenhaHashJogador, jogadorExistente.SenhaHashJogador)) return jogadorExistente;
            else return null;
        }

        public List<Baralho> ObterTodosBaralhoJogador(int idJogador)
        {
            return _baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = idJogador });
        }

        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            var jogadores = _IJogadorRepository.ObterTodos(filtro);
            return jogadores;
        }
    }
}