using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Cod3rsGrowth.Servico.ServicoJogador
{
    public class JogadorValidador : AbstractValidator<Jogador>
    {
        private const int quantidadeBaralhoPauper = 60;
        private const int quantidadeMaximaDeCopiaDeCartasStandard = 4;
        private const int quantidadeBaralhoStandard = 60;
        private const int quantidadeMaximaDeCopiaDeCartasCommander = 1;
        private const int quantidadeMaximaDeCopiaDeCartasPauper = 4;
        private const int quantidadeBaralhoCommander = 100;
        private const int tamanhoMinimoSenha = 8;
        private const int tamanhoMinimoUsuario = 6;

        public JogadorValidador()
        {
            DateTime valorDataHoje = DateTime.Now;
            const int valorMinimoDeIdadeParaCriarConta = 13;
            int valorAnoDeNascimentoMinimo = Convert.ToInt32(valorDataHoje.Year) - valorMinimoDeIdadeParaCriarConta;
            DateTime valorDataNascimentoMinima = new DateTime(valorAnoDeNascimentoMinimo, valorDataHoje.Month, valorDataHoje.Day);

            RuleSet("Criar", () => {
                RuleFor(jogador => jogador.NomeJogador)
                .NotNull().WithMessage("Campo NOME obrigatório.")
                .NotEmpty().WithMessage("Campo NOME obrigatório.");

                RuleFor(jogador => jogador.DataNascimentoJogador)
                .NotNull().WithMessage("Campo DATA DE NASCIMENTO obrigatório.")
                .NotEmpty().WithMessage("Campo DATA DE NASCIMENTO obrigatório.")
                .LessThanOrEqualTo(valorDataNascimentoMinima).WithMessage("O jogador deve possuir mais de 13 anos para criar conta");

                RuleFor(jogador => jogador.UsuarioJogador)
                .NotNull().WithMessage("Campo USUÁRIO obrigatório.")
                .NotEmpty().WithMessage("Campo USUÁRIO obrigatório.")
                .Must(ValidacaoJogadorUsuario).WithMessage("O Nome deve conter:" +
                    "Somente letras minúsculas [a-z];" +
                    "Conter mais de 8 dígitos.");

                RuleFor(jogador => jogador.SenhaHashJogador)
                .NotNull().WithMessage("Campo SENHA obrigatório.")
                .NotEmpty().WithMessage("Campo SENHA obrigatório.")
                .Must(ValidacaoJogadorSenha).WithMessage("A Senha deve conter:" +
                    "Ao menos uma letra maiúscula [A-Z];" +
                    "Ao menos uma letra minúscula [a-z];" +
                    "Ao menos um número [0123456789];" +
                    "Não deve conter caracteres especiais;" +
                    "Conter mais de 8 dígitos.");
            });
            
            RuleSet("Atualizar", () =>
            {

                RuleFor(jogador => jogador.UsuarioJogador)
                .NotNull().WithMessage("Campo USUÁRIO obrigatório.")
                .NotEmpty().WithMessage("Campo USUÁRIO obrigatório.")
                .Must(ValidacaoJogadorUsuario).WithMessage("O Nome deve conter:" +
                    "Somente letras minúsculas [a-z];" +
                    "Conter ao menos 6 dígitos.");

                RuleFor(jogador => jogador.SenhaHashJogador)
                .NotNull().WithMessage("Campo SENHA obrigatório.")
                .NotEmpty().WithMessage("Campo SENHA obrigatório.")
                .Must(ValidacaoJogadorSenha).WithMessage("A Senha deve conter:" +
                    "Ao menos uma letra maiúscula [A-Z];" +
                    "Ao menos uma letra minúscula [a-z];" +
                    "Ao menos um número [0123456789];" +
                    "Não deve conter caracteres especiais;" +
                    "Conter ao menos 8 dígitos.");
            });

            RuleSet("Excluir", () =>
            {
                RuleFor(jogador => jogador.BaralhosJogador)
                .Must(ValidacaoExclusaoDeJogador).WithMessage("Não e possivel excluir a conta, pois o jogador possui baralhos ativos");
            });
        }

        private static bool ValidacaoExclusaoDeJogador(List<Baralho> baralhosJogador)
        {
            const int quantidadeDeBaralhosParaExclusao = 0;

            return baralhosJogador.Count == quantidadeDeBaralhosParaExclusao;
        }

        private static bool ValidacaoJogadorUsuario(String usuario)
        {
            if (usuario.Length < tamanhoMinimoUsuario) return false;
            return Regex.IsMatch(usuario, "^[a-z]$");
        }

        private static bool ValidacaoJogadorSenha(String senha)
        {
            if (senha.Length < tamanhoMinimoSenha) return false;
            return Regex.IsMatch(senha, "^[a-zA-Z_0-9]$");
        }
    }
}