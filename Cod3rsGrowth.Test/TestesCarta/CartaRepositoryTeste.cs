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
    public class CartaRepositoryTeste : ServicoCarta
    {
        public CartaRepositoryTeste() {
            List<Carta> Cartas = new List<Carta>();

            Cartas.Add(new Carta(GerarIdCarta(Cartas), "Sol Ring", 1, RaridadeEnum.Common,
                GerarPrecoCarta(RaridadeEnum.Common), AdicionarCoresDaCarta("")));
            Cartas.Add(new Carta(GerarIdCarta(Cartas), "Counter Spell", 2, RaridadeEnum.Common,
                GerarPrecoCarta(RaridadeEnum.Common), AdicionarCoresDaCarta("{U}{U}")));
            Cartas.Add(new Carta(GerarIdCarta(Cartas), "Niv-Mizzet, Parun", 6, RaridadeEnum.Rare,
                GerarPrecoCarta(RaridadeEnum.Rare), AdicionarCoresDaCarta("{U}{U}{U}{R}{R}{R}")));
            Cartas.Add(new Carta(GerarIdCarta(Cartas), "Erebos, Bleak-Hearted", 4, RaridadeEnum.Mythic,
                GerarPrecoCarta(RaridadeEnum.Mythic), AdicionarCoresDaCarta("{3}{B}")));
        }
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