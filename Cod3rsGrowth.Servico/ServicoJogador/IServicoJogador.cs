using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation.Results;

namespace Cod3rsGrowth.Servicos.ServicoJogador
{
    public interface IServicoJogador
    {
        Jogador ObterPorId(int idJogador);
        List<Jogador> ObterTodos();
        ValidationResult CriarJogador(Jogador jogador);
    }
}