using System;
using System.Data;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using FluentValidation;
using FluentValidation.TestHelper;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class ValidadorCarta : AbstractValidator<Carta>
    {
        private const decimal precoCartaCommon = 0.5m;
        private const decimal precoCartaUncommon = 2.5m;
        private const decimal precoCartaRare = 5m;
        private const decimal precoCartaMythic = 7.5m;
        public ValidadorCarta()
        {
            const int valorMinimo = -1;

            RuleFor(carta => carta.IdCarta)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Campo idCarta nao pode ser nulo")
                .GreaterThan(valorMinimo).WithMessage("Campo idCarta deve ser maior que 0");

            RuleFor(carta => carta.NomeCarta)
                .NotNull().WithMessage("Campo NomeCarta nao pode ser nulo")
                .NotEmpty().WithMessage("Campo NomeCarta nao pode ser vazio");

            RuleFor(carta => carta.CustoDeManaConvertidoCarta)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Campo CustoDeManaConvertidoCarta nao pode ser nulo")
                .GreaterThan(valorMinimo).WithMessage("Campo CustoDeManaConvertidoCarta nao pode ser negativo");

            RuleFor(carta => carta.TipoDeCarta)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Campo TipoDeCarta nao pode ser nulo")
                .IsInEnum().WithMessage("Valor inválido");

            RuleFor(carta => carta.RaridadeCarta)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Campo RaridadeCarta nao pode ser nulo")
                .IsInEnum().WithMessage("Campo RaridadeCarta valor inválido");

            RuleFor(carta => carta.PrecoCarta)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Campo PrecoCarta nao pode ser nulo")
                .GreaterThan(valorMinimo).WithMessage("Campo PrecoCarta deve se maior que 0");

            RuleFor(carta => carta)
                .Cascade(CascadeMode.Stop)
                .Must(ValidarPrecoCarta).WithMessage("Valor do preço da carta nao condiz com a raridade da carta");

            RuleFor(carta => carta.CorCarta)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Campo CorCarta nao pode ser vazio")
                .Must(ValidarListaDeCores).WithMessage("Campo CorCarta com valores inválidos");

            RuleFor(carta => carta.RaridadeCarta)
                .NotNull().WithMessage("Campo CorCarta nao pode ser nulo");
        }

        private static bool ValidarPrecoCarta(Carta carta)
        {
            switch (carta.RaridadeCarta)
            {
                case RaridadeEnum.Common:
                    if (carta.PrecoCarta == precoCartaCommon) return true;
                    break;
                case RaridadeEnum.Uncommon:
                    if (carta.PrecoCarta == precoCartaUncommon) return true;
                    break;
                case RaridadeEnum.Rare:
                    if (carta.PrecoCarta == precoCartaRare) return true;
                    break;
                case RaridadeEnum.Mythic:
                    if (carta.PrecoCarta == precoCartaMythic) return true;
                    break;
            }
            return false;
        }

        private static bool ValidarListaDeCores(List<CoresEnum> CorCarta)
        {
            return CorCarta.All(e => Enum.IsDefined(typeof(CoresEnum), e));
        }
    }
}