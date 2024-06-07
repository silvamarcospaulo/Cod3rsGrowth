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
            const int valorMinimo = 0;

            RuleFor(jogador => jogador.IdJogador)
                .NotNull().WithMessage("Campo IdJogador nao pode ser nulo");

            RuleFor(jogador => jogador.NomeJogador)
                .NotNull().WithMessage("Campo NomeJogador nao pode ser nulo");

            RuleFor(jogador => jogador.DataNascimentoJodador)
                .NotNull().WithMessage("Campo DataNascimentoJodador nao pode ser nulo");

            RuleFor(jogador => jogador.PrecoDasCartasJogador)
                .NotNull().WithMessage("Campo PrecoDasCartasJogador nao pode ser nulo")
                .GreaterThanOrEqualTo(Convert.ToDecimal(valorMinimo)).WithMessage("Valor PrecoDasCartasJogador na pode ser negativo");

            RuleFor(jogador => jogador.QuantidadeDeBaralhosJogador)
                .NotNull().WithMessage("Campo QuantidadeDeBaralhosJogador nao pode ser nulo")
                .GreaterThanOrEqualTo(valorMinimo).WithMessage("Valor PrecoDasCartasJogador na pode ser negativo");
        }
    }
}