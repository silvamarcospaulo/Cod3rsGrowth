using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using Cod3rsGrowth.Test.TestesJogador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Test.TestesBaralho
{
    public class BaralhoRepositoryMock : IBaralhoRepository
    {
        public void Excluir(int idBaralho)
        {
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return new Baralho();
        }

        public List<Baralho> ObterTodos()
        {
            return new List<Baralho>();
        }
    }
}