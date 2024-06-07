using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ValidadorBaralho()
        {
            RuleFor(baralho => baralho.IdBaralho)
                .NotNull().WithMessage("Campo IdBaralho não pode ser nulo");
            
            RuleFor(baralho => baralho.IdJogador)
                .NotNull().WithMessage("Campo IdJogado não pode ser nulo");
            
            RuleFor(baralho => baralho.NomeBaralho)
                .NotNull().WithMessage("Campo IdNome não pode ser nulo");

            RuleFor(baralho => baralho.FormatoDeJogoBaralho)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Campo IdFormatoDeJogoBaralho não pode ser nulo")
                .IsInEnum().WithMessage("Campo IdFormatoDeJogoBaralho valor invalido");

            RuleFor(baralho => baralho.CartasDoBaralho)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Campo CartasDoBaralho não pode ser nulo")
                .NotEmpty().WithMessage("Campo CartasDoBaralho não pode ser vazio");

            RuleFor(baralho => baralho.QuantidadeDeCartasNoBaralho)
                .NotNull().WithMessage("Campo QuantidadeDeCartasNoBaralho não pode ser nulo");

            RuleFor(baralho => baralho).Must(ValidacaoTipoDeBaralho)
                .WithMessage("Quantidade de CartasDoBaralho não condiz com o FormatoDeJogoBaralho");

            RuleFor(baralho => baralho.CorBaralho)
                .NotEmpty().WithMessage("Campo CorBaralho não pode ser vazio");
        }

        private static bool ValidacaoTipoDeBaralho(Baralho baralho)
        {
            switch (baralho.FormatoDeJogoBaralho)
            {
                case FormatoDeJogoEnum.Commander:
                    if (baralho.CartasDoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) != quantidadeBaralhoCommander) return false;
                    if (baralho.CartasDoBaralho.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (c.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasCommander))) return false;
                    break;

                case FormatoDeJogoEnum.Pauper:
                    if (baralho.CartasDoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) < quantidadeBaralhoPauper) return false;
                    if (baralho.CartasDoBaralho.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (c.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasPauper))) return false;
                    if (baralho.CartasDoBaralho.All(c => c.Carta.RaridadeCarta != RaridadeEnum.Common)) return false;
                    break;

                case FormatoDeJogoEnum.Standard:
                    if (baralho.CartasDoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) < quantidadeBaralhoStandard) return false;
                    if (baralho.CartasDoBaralho.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (c.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasStandard))) return false;
                    break;
            }
            return true;
        }
    }    
}