using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra.Repository;
using Cod3rsGrowth.Servico.ServicoCarta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Test.TestesCarta
{
    public class CartaRepositoryTeste : ICartaRepository
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