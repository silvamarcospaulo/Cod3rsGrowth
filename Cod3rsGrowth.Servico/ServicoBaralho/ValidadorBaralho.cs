using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using FluentValidation;
using System;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class ValidadorBaralho : AbstractValidator<Baralho>
    {
        private const int quantidadeBaralhoPauper = 60;
        private const int quantidadeMaximaDeCopiaDeCartasStandard = 4;
        private const int quantidadeBaralhoStandard = 60;
        private const int quantidadeMaximaDeCopiaDeCartasCommander = 1;
        private const int quantidadeMaximaDeCopiaDeCartasPauper = 4;
        private const int quantidadeBaralhoCommander = 100;
        private const int valorMinimoIdJogador = 1;
        private readonly DateTime dataDeCriacaoMinima = new DateTime(06/05/2024);

        public ValidadorBaralho()
        {   
            RuleFor(baralho => baralho.IdJogador)
                .NotNull()
                .WithMessage("Campo Id do jogador não pode ser nulo")
                .GreaterThanOrEqualTo(valorMinimoIdJogador)
                .WithMessage("Campo Id do jogador tem quer ser maior do que Um");
            
            RuleFor(baralho => baralho.NomeBaralho)
                .NotNull()
                .WithMessage("Campo nome de baralho não pode ser nulo")
                .NotEmpty()
                .WithMessage("Campo nome de baralho não pode ser vazio");

            RuleFor(baralho => baralho.FormatoDeJogoBaralho)
                .IsInEnum()
                .WithMessage("Campo FormatoDeJogoBaralho valor invalido");

            RuleFor(baralho => baralho)
                .Must(ValidacaoTipoDeBaralho)
                .WithMessage("Quantidade de cartas do baralho não condiz com o formato de jogo selecionado");
        }

        private static bool ValidacaoTipoDeBaralho(Baralho baralho)
        {
            switch (baralho.FormatoDeJogoBaralho)
            {
                case FormatoDeJogoEnum.Commander:
                    if (baralho.CartasDoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) != quantidadeBaralhoCommander) return false;
                    if (baralho.CartasDoBaralho.All(cartas => (cartas.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (cartas.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasCommander))) return false;
                    break;

                case FormatoDeJogoEnum.Pauper:
                    if (baralho.CartasDoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) < quantidadeBaralhoPauper) return false;
                    if (baralho.CartasDoBaralho.All(cartas => (cartas.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (cartas.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasPauper))) return false;
                    if (baralho.CartasDoBaralho.All(cartas => cartas.Carta.RaridadeCarta != RaridadeEnum.Common)) return false;
                    break;

                case FormatoDeJogoEnum.Standard:
                    if (baralho.CartasDoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) < quantidadeBaralhoStandard) return false;
                    if (baralho.CartasDoBaralho.All(cartas => (cartas.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (cartas.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasStandard))) return false;
                    break;
            }
            return true;
        }
    }    
}