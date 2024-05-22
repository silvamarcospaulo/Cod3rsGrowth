using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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