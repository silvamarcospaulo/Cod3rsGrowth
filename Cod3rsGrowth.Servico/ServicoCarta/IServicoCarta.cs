using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using FluentValidation.Results;


namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public interface IServicoCarta
    {
        Carta ObterPorId(int idCarta);
        List<Carta> ObterTodos();
    }
}