﻿using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryCarta;
using Cod3rsGrowth.Test.Singleton;

namespace Cod3rsGrowth.Test.TestesCarta
{
    public class CartaRepositoryMock : ICartaRepository
    {
        List<Carta> tabelasCartas = SingletonTabelas.InstanciaCartas;

        public void Excluir(int idCarta)
        {
        }

        public Carta ObterPorId(int idCarta)
        {
            return new Carta();
        }

        public List<Carta> ObterTodos()
        {
            return tabelasCartas;
        }
    }
}