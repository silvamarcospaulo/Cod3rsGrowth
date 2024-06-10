using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation.Results;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public interface IServicoBaralho
    {
        public Baralho ObterPorId(int idBaralho);
        public List<Baralho> ObterTodos();
        ValidationResult CriarBaralho(Baralho baralho);
    }
}