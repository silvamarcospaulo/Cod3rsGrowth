using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation;
using LinqToDB.DataProvider.SapHana;
using System.Text.RegularExpressions;

namespace Cod3rsGrowth.Servico.ServicoJogador
{
    public class JogadorValidador : AbstractValidator<Jogador>
    {
        private const int TAMANHO_MINIMO_SENHA = 8;
        private const int TAMANHO_MINIMO_USUARIO = 6;
        private const int VALOR_NULO = 0;

        public JogadorValidador()
        {
            DateTime valorDataHoje = DateTime.Now;
            const int VALOR_MINIMO_DE_IDADE_PARA_CRIAR_CONTA = 13;
            int valorAnoDeNascimentoMinimo = Convert.ToInt32(valorDataHoje.Year) - VALOR_MINIMO_DE_IDADE_PARA_CRIAR_CONTA;
            DateTime valorDataNascimentoMinima = new DateTime(valorAnoDeNascimentoMinimo, valorDataHoje.Month, valorDataHoje.Day);

            RuleSet("Criar", () =>
            {
                RuleFor(jogador => jogador.NomeJogador)
                    .NotNull().WithMessage("Preencha seu nome no campo indicado.\n")
                    .NotEmpty().WithMessage("Preencha seu nome no campo indicado.\n");

                RuleFor(jogador => jogador.SobrenomeJogador)
                    .NotNull().WithMessage("Preencha seu sobrenome no campo indicado.\n")
                    .NotEmpty().WithMessage("Preencha seu sobrenome no campo indicado.\n");

                RuleFor(jogador => jogador.DataNascimentoJogador)
                    .NotNull().WithMessage("Preencha sua data de nascimento no campo indicado.\n")
                    .NotEmpty().WithMessage("Preencha sua data de nascimento no campo indicado.\n")
                    .LessThanOrEqualTo(valorDataNascimentoMinima).WithMessage("MTG Deckbuilder possui conteúdo exclusivo para maiores de 13 anos.\n");

                RuleFor(jogador => jogador.UsuarioJogador)
                    .NotNull().WithMessage("Preencha seu nome de usuário no campo indicado.\n")
                    .NotEmpty().WithMessage("Preencha seu nome de usuário no campo indicado.\n");

                RuleFor(jogador => jogador.UsuarioJogador)
                    .Must(ValidacaoJogadorUsuario).WithMessage(
                        "O usuário deve conter:\n" +
                        "Somente letras minúsculas [a-z].\n" +
                        "Conter mais de 6 dígitos.\n")
                    .When(jogador => !string.IsNullOrEmpty(jogador.UsuarioJogador));

                RuleFor(jogador => jogador)
                    .Must(ValidacaoUsuarioEConfirmacaoCorrepondem).WithMessage("O usuário e a confirmação devem coincidir!\n")
                    .When(jogador => !string.IsNullOrEmpty(jogador.UsuarioJogador));

                RuleFor(jogador => jogador.SenhaHashJogador)
                    .NotNull().WithMessage("Preencha sua senha no campo indicado.\n")
                    .NotEmpty().WithMessage("Preencha sua senha no campo indicado.\n");

                RuleFor(jogador => jogador.SenhaHashJogador)
                    .Must(ValidacaoJogadorSenha).WithMessage(
                        "A Senha deve conter:\n" +
                        "Ao menos uma letra maiúscula [A-Z].\n" +
                        "Ao menos uma letra minúscula [a-z].\n" +
                        "Ao menos um número [0123456789].\n" +
                        "Não deve conter caracteres especiais.\n" +
                        "Conter mais de 8 dígitos.\n")
                    .When(jogador => !string.IsNullOrEmpty(jogador.SenhaHashJogador));


                RuleFor(jogador => jogador)
                    .Must(ValidacaoSenhaEConfirmacaoCorrepondem).WithMessage("A senha e a confirmação devem coincidir!\n")
                    .When(jogador => !string.IsNullOrEmpty(jogador.SenhaHashJogador));
            });

            RuleSet("Atualizar", () =>
            {
                RuleFor(jogador => jogador.UsuarioJogador)
                    .Must(ValidacaoJogadorUsuario).WithMessage(
                        "O usuário deve conter:\n" +
                        "Somente letras minúsculas [a-z].\n" +
                        "Conter mais de 6 dígitos.\n")
                    .When(jogador => !string.IsNullOrEmpty(jogador.UsuarioJogador));

                RuleFor(jogador => jogador)
                    .Must(ValidacaoUsuarioEConfirmacaoCorrepondem).WithMessage("O usuário e a confirmação devem coincidir!\n")
                    .When(jogador => !string.IsNullOrEmpty(jogador.UsuarioJogador));

                RuleFor(jogador => jogador.SenhaHashJogador)
                    .Must(ValidacaoJogadorSenha).WithMessage(
                        "A Senha deve conter:\n" +
                        "Ao menos uma letra maiúscula [A-Z].\n" +
                        "Ao menos uma letra minúscula [a-z].\n" +
                        "Ao menos um número [0123456789].\n" +
                        "Não deve conter caracteres especiais.\n" +
                        "Conter mais de 8 dígitos.\n")
                    .When(jogador => !string.IsNullOrEmpty(jogador.SenhaHashJogador));

                RuleFor(jogador => jogador)
                    .Must(ValidacaoSenhaEConfirmacaoCorrepondem).WithMessage("A senha e a confirmação devem coincidir!\n")
                    .When(jogador => !string.IsNullOrEmpty(jogador.SenhaHashJogador));
            });

            RuleSet("AlterarSenha", () =>
            {
                RuleFor(jogador => jogador.SenhaHashJogador)
                    .NotNull().WithMessage("Preencha sua senha no campo indicado.\n")
                    .NotEmpty().WithMessage("Preencha sua senha no campo indicado.\n");

                RuleFor(jogador => jogador.SenhaHashJogador)
                    .Must(ValidacaoJogadorSenha).WithMessage(
                        "A Senha deve conter:\n" +
                        "Ao menos uma letra maiúscula [A-Z].\n" +
                        "Ao menos uma letra minúscula [a-z].\n" +
                        "Ao menos um número [0123456789].\n" +
                        "Não deve conter caracteres especiais.\n" +
                        "Conter mais de 8 dígitos.\n")
                    .When(jogador => !string.IsNullOrEmpty(jogador.SenhaHashJogador));


                RuleFor(jogador => jogador)
                    .Must(ValidacaoSenhaEConfirmacaoCorrepondem).WithMessage("A senha e a confirmação devem coincidir!\n")
                    .When(jogador => !string.IsNullOrEmpty(jogador.SenhaHashJogador));
            });
        }

        private static bool ValidacaoExclusaoDeJogador(List<Baralho> baralhosJogador)
        {
            const int quantidadeDeBaralhosParaExclusao = 0;
            return baralhosJogador.Count == quantidadeDeBaralhosParaExclusao;
        }

        private static bool ValidacaoJogadorUsuario(String usuario)
        {
            if (usuario.Length < TAMANHO_MINIMO_USUARIO) return false;
            return Regex.IsMatch(usuario, "^[a-z]+$");
        }

        private static bool ValidacaoJogadorSenha(String senha)
        {
            if (senha.Length < TAMANHO_MINIMO_SENHA) return false;
            return Regex.IsMatch(senha, "^[a-zA-Z0-9]+$");
        }

        private static bool ValidacaoSenhaEConfirmacaoCorrepondem(Jogador jogador)
        {
            if (jogador?.SenhaHashJogador.Length >= VALOR_NULO) return jogador.SenhaHashJogador == jogador.SenhaHashConfirmacaoJogador;
            return true;
        }

        private static bool ValidacaoUsuarioEConfirmacaoCorrepondem(Jogador jogador)
        {
            if (jogador?.UsuarioJogador.Length >= VALOR_NULO) return jogador.UsuarioJogador == jogador.UsuarioConfirmacaoJogador;
            return true;
        }
    }
}