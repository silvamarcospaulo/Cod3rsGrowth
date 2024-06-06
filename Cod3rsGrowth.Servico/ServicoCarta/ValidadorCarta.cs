using System;
using System.Data;
using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation;
using FluentValidation.TestHelper;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class ValidadorCarta : AbstractValidator<Carta>
    {
        public ValidadorCarta()
        {
            const int valorMinimo = -1;

            RuleFor(carta => carta.IdCarta)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Campo idCarta nao pode ser nulo")
                .GreaterThan(valorMinimo).WithMessage("Campo idCarta deve ser maior que 0");

            RuleFor(carta => carta.NomeCarta)
                .NotNull().WithMessage("Campo NomeCarta nao pode ser nulo");

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

            RuleFor(carta => carta.PrecoCarta)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Campo PrecoCarta nao pode ser nulo")
                .GreaterThan(valorMinimo).WithMessage("Campo PrecoCarta deve se maior que 0");

            RuleFor(carta => carta.CorCarta)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Campo CorCarta nao pode ser nulo")
                .IsInEnum().WithMessage("Campo CorCarta valor inválido");
        }
    }
}