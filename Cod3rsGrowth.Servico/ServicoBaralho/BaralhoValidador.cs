﻿using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using FluentValidation;
using System;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class BaralhoValidador : AbstractValidator<Baralho>
    {
        private const int quantidadeBaralhoPauper = 60;
        private const int quantidadeMaximaDeCopiaDeCartasStandard = 4;
        private const int quantidadeBaralhoStandard = 60;
        private const int quantidadeMaximaDeCopiaDeCartasCommander = 1;
        private const int quantidadeMaximaDeCopiaDeCartasPauper = 4;
        private const int quantidadeBaralhoCommander = 100;
        private const int valorMinimoIdJogador = -1;

        public BaralhoValidador()
        {   
            RuleFor(baralho => baralho.IdJogador)
                .GreaterThan(valorMinimoIdJogador).WithMessage("Campo Id do jogador tem quer ser maior do que Um");
            
            RuleFor(baralho => baralho.NomeBaralho)
                .NotNull()
                .WithMessage("Campo nome de baralho não pode ser nulo")
                .NotEmpty()
                .WithMessage("Campo nome de baralho não pode ser vazio");

            RuleFor(baralho => baralho.CartasDoBaralho)
                .NotEmpty()
                .WithMessage("O baralho deve possuir uma lista de cartas não vazia");

            RuleFor(baralho => baralho.CartasDoBaralho).NotNull().DependentRules(() =>
            {
                RuleFor(baralho => baralho.FormatoDeJogoBaralho)
                .Must((baralho, formatoDeJogo) => ValidacaoTipoDeBaralho(baralho.CartasDoBaralho, formatoDeJogo))
                .WithMessage("Quantidade de cartas do baralho não compativel com o formato de jogo selecionado");
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
                        if (copiaDeCartasNoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) != quantidadeBaralhoCommander) return false;

                        if (copiaDeCartasNoBaralho.All(cartas => (cartas.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) && (cartas.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasCommander))) return false;

                        break;

                    case FormatoDeJogoEnum.Pauper:
                        if (copiaDeCartasNoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) < quantidadeBaralhoPauper) return false;

                        if (copiaDeCartasNoBaralho.All(cartas => (cartas.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) && (cartas.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasPauper))) return false;

                        if (copiaDeCartasNoBaralho.All(cartas => cartas.Carta.RaridadeCarta != RaridadeEnum.Common)) return false;

                        break;

                    case FormatoDeJogoEnum.Standard:
                        if (copiaDeCartasNoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) < quantidadeBaralhoStandard) return false;

                        if (copiaDeCartasNoBaralho.All(cartas => (cartas.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) && (cartas.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasStandard))) return false;

                        break;
                }
            }
            return true;
        }
    }    
}