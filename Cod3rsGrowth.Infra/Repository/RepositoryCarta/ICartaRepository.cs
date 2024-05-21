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
        public bool Excluir(int idCarta, List<Carta> cartas);

        public Carta ObterPorId(int idCarta, List<Carta> cartas);

        public List<Carta> ObterTodos(List<Carta> Cartas);
    }
}