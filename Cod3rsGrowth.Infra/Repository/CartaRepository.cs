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
        public bool Excluir(int idCarta, List<Carta> cartas)
        {
            return cartas.Remove(ObterPorId(idCarta, cartas));
        }

        public Carta ObterPorId(int idCarta, List<Carta> cartas)
        {
            return cartas.FirstOrDefault(carta => carta.idCarta == idCarta);
        }

        public List<Carta> ObterTodos(List<Carta> Cartas)
        {
            return Cartas;
        }
    }
}