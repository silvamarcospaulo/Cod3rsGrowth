﻿using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra.Repository.RepositoryCarta;
using Cod3rsGrowth.Servico.ServicoCarta;

namespace Cod3rsGrowth.Test.TestesCarta
{
    public class CartaRepositoryMock
    {
        public void Excluir(int idCarta)
        {
            //cartas.Remove(ObterPorId(idCarta, cartas));
        }

        public Carta ObterPorId(int idCarta)
        {
            //return cartas.FirstOrDefault(carta => carta.IdCarta == idCarta);
            return new Carta();
        }

        public List<Carta> ObterTodos()
        {
            return new List<Carta>();
        }
    }
}