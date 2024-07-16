using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class CartaValidador : AbstractValidator<Carta>
    {
        public CartaValidador()
        {
            const int CUSTO_DE_MANA_CONVERTIDO_MINIMO = -1;

            RuleFor(carta => carta.NomeCarta)
                .NotEmpty()
                .WithMessage("Nome da carta nao pode ser vazio");

            RuleFor(carta => carta.CustoDeManaConvertidoCarta)
                .NotNull()
                .WithMessage("Custo de Mana Convertido da Carta não pode ser nulo")
                .GreaterThan(CUSTO_DE_MANA_CONVERTIDO_MINIMO)
                .WithMessage("Custo de Mana Convertido da Carta deve ser igual ou maior que 0");

            RuleFor(carta => carta.TipoDeCarta)
                .NotNull()
                .WithMessage("Campo TipoDeCarta nao pode ser nulo");

            RuleFor(carta => carta.RaridadeCarta)
                .NotNull().WithMessage("Campo RaridadeCarta nao pode ser nulo");
        }
    }
}