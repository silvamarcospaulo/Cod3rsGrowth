using Cod3rsGrowth.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Infra.Repository
{
    public class CartaRepository : ICartaRepository
    {
        public bool Atualizar(int idCarta)
        {
            return new bool();
        }

        public bool Excluir(int idCarta)
        {
            return new bool();
        }

        public Carta ObterPorId(int idCarta)
        {
            return new Carta();
        }

        public List<Carta> ObterTodos()
        {
            return new List<Carta>();
        }
    }
}