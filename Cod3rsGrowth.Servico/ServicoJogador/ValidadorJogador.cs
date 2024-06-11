using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Servico.ServicoJogador
{
    public class ValidadorJogador : AbstractValidator<Jogador>
    {
        public ValidadorJogador()
        {
            RuleFor(jogador => jogador.NomeJogador)
                .NotEmpty().WithMessage("Nome do Jogador nao pode ser vazio");

            RuleFor(jogador => jogador.DataNascimentoJogador)
                .NotNull().WithMessage("Campo data de nascimento do jogador nao pode ser nulo");
        }
    }
}