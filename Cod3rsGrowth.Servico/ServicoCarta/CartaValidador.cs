﻿using System;
using System.Data;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using FluentValidation;
using FluentValidation.TestHelper;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class CartaValidador : AbstractValidator<Carta>
    {
        public CartaValidador()
        {
            const int valorMinimo = -1;

            RuleFor(carta => carta.NomeCarta)
                .NotEmpty()
                .WithMessage("Nome da carta nao pode ser vazio");

            RuleFor(carta => carta.CustoDeManaConvertidoCarta)
                .NotNull()
                .WithMessage("Custo de Mana Convertido da Carta não pode ser nulo")
                .GreaterThan(valorMinimo)
                .WithMessage("Custo de Mana Convertido da Carta deve ser igual ou maior que 0");

            RuleFor(carta => carta.TipoDeCarta)
                .NotNull()
                .WithMessage("Campo TipoDeCarta nao pode ser nulo")
                .IsInEnum()
                .WithMessage("Valor inválido");

            RuleFor(carta => carta.RaridadeCarta)
                .NotNull().WithMessage("Campo RaridadeCarta nao pode ser nulo")
                .IsInEnum().WithMessage("Campo RaridadeCarta valor inválido");
        }
    }
}