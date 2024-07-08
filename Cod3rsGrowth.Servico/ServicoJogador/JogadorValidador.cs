using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Cod3rsGrowth.Servico.ServicoJogador
{
    public class JogadorValidador : AbstractValidator<Jogador>
    {
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
                .NotNull().WithMessage("Campo NOME é obrigatório.")
                .NotEmpty().WithMessage("Campo NOME é obrigatório.");

                RuleFor(jogador => jogador.SobrenomeJogador)
                .NotNull().WithMessage("Campo SOBRENOME é obrigatório.")
                .NotEmpty().WithMessage("Campo SOBRENOME é obrigatório.");

                RuleFor(jogador => jogador.DataNascimentoJogador)
                .NotNull().WithMessage("Campo DATA DE NASCIMENTO é obrigatório.")
                .NotEmpty().WithMessage("Campo DATA DE NASCIMENTO é obrigatório.")
                .LessThanOrEqualTo(valorDataNascimentoMinima).WithMessage("O jogador deve possuir mais de 13 anos para criar conta");

                RuleFor(jogador => jogador.UsuarioJogador)
                .NotNull().WithMessage("Campo USUÁRIO é obrigatório.")
                .NotEmpty().WithMessage("Campo USUÁRIO é obrigatório.")
                .Must(ValidacaoJogadorUsuario).WithMessage("O Nome deve conter:\n" +
                    "Somente letras minúsculas [a-z];\n" +
                    "Conter mais de 8 dígitos.");

                RuleFor(jogador => jogador.SenhaHashJogador)
                .NotNull().WithMessage("Campo SENHA é obrigatório.")
                .NotEmpty().WithMessage("Campo SENHA é obrigatório.")
                .Must(ValidacaoJogadorSenha).WithMessage("A Senha deve conter:" +
                    "Ao menos uma letra maiúscula [A-Z];\n" +
                    "Ao menos uma letra minúscula [a-z];\n" +
                    "Ao menos um número [0123456789];\n" +
                    "Não deve conter caracteres especiais;\n" +
                    "Conter mais de 8 dígitos.\n");

                RuleFor(jogador => jogador)
                .Must(ValidacaoSenhaConfirmacaoSenha).WithMessage("A senha e a confirmação devem concidir!");
            });

            RuleSet("Atualizar", () => {

                RuleFor(jogador => jogador.UsuarioJogador)
                .NotNull().WithMessage("Campo USUÁRIO é obrigatório.")
                .NotEmpty().WithMessage("Campo USUÁRIO é obrigatório.")
                .Must(ValidacaoJogadorUsuario).WithMessage("O Nome deve conter:\n" +
                    "Somente letras minúsculas [a-z];\n" +
                    "Conter mais de 8 dígitos.");

                RuleFor(jogador => jogador.SenhaHashJogador)
                .NotNull().WithMessage("Campo SENHA é obrigatório.")
                .NotEmpty().WithMessage("Campo SENHA é obrigatório.")
                .Must(ValidacaoJogadorSenha).WithMessage("A Senha deve conter:" +
                    "Ao menos uma letra maiúscula [A-Z];\n" +
                    "Ao menos uma letra minúscula [a-z];\n" +
                    "Ao menos um número [0123456789];\n" +
                    "Não deve conter caracteres especiais;\n" +
                    "Conter mais de 8 dígitos.\n");

                RuleFor(jogador => jogador)
                .Must(ValidacaoUsuarioConfirmacaoUsuario).WithMessage("O usuário e a confirmação devem concidir!");

                RuleFor(jogador => jogador)
                .Must(ValidacaoSenhaConfirmacaoSenha).WithMessage("A senha e a confirmação devem concidir!");
            });

            RuleSet("AlterarSenha", () => {

                RuleFor(jogador => jogador.SenhaHashJogador)
                .NotNull().WithMessage("Campo SENHA é obrigatório.")
                .NotEmpty().WithMessage("Campo SENHA é obrigatório.")
                .Must(ValidacaoJogadorSenha).WithMessage("A Senha deve conter:" +
                    "Ao menos uma letra maiúscula [A-Z];\n" +
                    "Ao menos uma letra minúscula [a-z];\n" +
                    "Ao menos um número [0123456789];\n" +
                    "Não deve conter caracteres especiais;\n" +
                    "Conter mais de 8 dígitos.\n");

                RuleFor(jogador => jogador)
                .Must(ValidacaoSenhaConfirmacaoSenha).WithMessage("A senha e a confirmação devem concidir!");
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
            return Regex.IsMatch(usuario, "^[a-z]+$");
        }

        private static bool ValidacaoJogadorSenha(String senha)
        {
            if (senha.Length < tamanhoMinimoSenha) return false;
            return Regex.IsMatch(senha, "^[a-zA-Z0-9]+$");
        }

        private static bool ValidacaoSenhaConfirmacaoSenha(Jogador jogador)
        {
            if (jogador?.SenhaHashJogador is not null) return jogador.SenhaHashJogador == jogador.SenhaHashConfirmacaoJogador;

            return true;
        }

        private static bool ValidacaoUsuarioConfirmacaoUsuario(Jogador jogador)
        {
            if(jogador?.UsuarioJogador is not null) return jogador.UsuarioJogador == jogador.UsuarioConfirmacaoJogador;

            return true;
        }
    }
}