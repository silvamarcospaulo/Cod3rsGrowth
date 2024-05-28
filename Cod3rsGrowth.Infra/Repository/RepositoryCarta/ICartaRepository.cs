using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryCarta
{
    public interface ICartaRepository
    {
        public void Excluir(int idCarta);

        public Carta ObterPorId(int idCarta);

        public List<Carta> ObterTodos();
    }
}