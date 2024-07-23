﻿using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using FluentValidation;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class BaralhoValidador : AbstractValidator<Baralho>
    {
        private const int QUANTIDADE_MINIMA_DE_CARTAS_PAUPER = 60;
        private const int QUANTIDADE_MAXIMA_DE_COPIA_DE_CARTAS_STANDARD_E_PAUPER = 4;
        private const int QUANTIDADE_MINIMA_DE_CARTAS_STANDARD = 60;
        private const int QUANTIDADE_MAXIMA_DE_COPIA_DE_CARTAS_COMMANDER = 1;
        private const int QUANTIDADE_MINIMA_DE_CARTAS_COMMANDER = 100;
        private const int VALOR_MINIMO_ID_JOGADOR = -1;

        public BaralhoValidador()
        {
            RuleFor(baralho => baralho.NomeBaralho)
                .NotNull().WithMessage("Insira um nome para o baralho.\n")
                .NotEmpty().WithMessage("Insira um nome para o baralho.\n");

            RuleFor(baralho => baralho.CartasDoBaralho)
                .NotEmpty().WithMessage("Não é possível criar um baralho com uma lista vazia.\n");

            RuleFor(baralho => baralho.CartasDoBaralho).NotNull().DependentRules(() =>
            {
                RuleFor(baralho => baralho.FormatoDeJogoBaralho)
                .Must((baralho, formatoDeJogo) => ValidacaoTipoDeBaralho(baralho.CartasDoBaralho, formatoDeJogo))
                .WithMessage("Quantidade de cartas do baralho não compativel com o formato de jogo selecionado.\n");
            });
        }

        private static bool ValidacaoTipoDeBaralho(List<CopiaDeCartasNoBaralho> copiaDeCartasNoBaralho, FormatoDeJogoEnum formatoDeJogoBaralho)
        {
            const int quantidadeDeCartasNoBaralhosParaValidacao = 1;
            if (copiaDeCartasNoBaralho.Count >= quantidadeDeCartasNoBaralhosParaValidacao)
            {
                switch (formatoDeJogoBaralho)
                {
                    case FormatoDeJogoEnum.Commander:
                        if (copiaDeCartasNoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) != QUANTIDADE_MINIMA_DE_CARTAS_COMMANDER) return false;

                        if (copiaDeCartasNoBaralho.All(cartas => (!cartas.Carta.TipoDeCarta.Contains("Basic Land")) && (cartas.QuantidadeCopiasDaCartaNoBaralho > QUANTIDADE_MAXIMA_DE_COPIA_DE_CARTAS_COMMANDER))) return false;

                        break;

                    case FormatoDeJogoEnum.Pauper:
                        if (copiaDeCartasNoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) < QUANTIDADE_MINIMA_DE_CARTAS_PAUPER) return false;

                        if (copiaDeCartasNoBaralho.All(cartas => (!cartas.Carta.TipoDeCarta.Contains("Basic Land")) && (cartas.QuantidadeCopiasDaCartaNoBaralho > QUANTIDADE_MAXIMA_DE_COPIA_DE_CARTAS_STANDARD_E_PAUPER))) return false;

                        if (copiaDeCartasNoBaralho.All(cartas => cartas.Carta.RaridadeCarta != RaridadeEnum.Comum)) return false;

                        break;

                    case FormatoDeJogoEnum.Standard:
                        if (copiaDeCartasNoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) < QUANTIDADE_MINIMA_DE_CARTAS_STANDARD) return false;

                        if (copiaDeCartasNoBaralho.All(cartas => (!cartas.Carta.TipoDeCarta.Contains("Basic Land")) && (cartas.QuantidadeCopiasDaCartaNoBaralho > QUANTIDADE_MAXIMA_DE_COPIA_DE_CARTAS_STANDARD_E_PAUPER))) return false;

                        break;
                }
            }
            return true;
        }
    }
}