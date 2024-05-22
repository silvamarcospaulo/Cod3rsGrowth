using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Test.TestesBaralho
{
    public class BaralhoRepositoryTeste : IBaralhoRepository
    {
        public void Excluir(int idBaralho)
        {
            //baralhos.Remove(ObterPorId(idBaralho));
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return baralhos.FirstOrDefault(baralho => baralho.IdBaralho == idBaralho);
        }

        public List<Baralho> ObterTodos()
        {
            return baralhos;
        }
    }
}