using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Servico.ServicoJogador
{
    public class ValidadorJogador : AbstractValidator<Jogador>
    {
        public ValidadorJogador()
        {
            DateTime valorDataHoje = DateTime.Now;
            const int valorMinimoDeIdadeParaCriarConta = 13;
            int valorAnoDeNascimentoMinimo = Convert.ToInt32(valorDataHoje.Year) - valorMinimoDeIdadeParaCriarConta;
            DateTime valorDataNascimentoMinima = new DateTime(day: valorDataHoje.Day, month: valorDataHoje.Month, year: valorAnoDeNascimentoMinimo);

            RuleFor(jogador => jogador.NomeJogador)
                .NotEmpty().WithMessage("Nome do Jogador nao preenchido");

            RuleFor(jogador => jogador.DataNascimentoJogador)
                .NotEmpty().WithMessage("Data de nascimente nao preenchida")
                .LessThanOrEqualTo(valorDataNascimentoMinima).WithMessage("O jogador deve possuir mais de 13 anos para criar conta");
        }
    }
}