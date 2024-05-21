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
        public bool Excluir(int idBaralho, List<Baralho> baralhos)
        {
            return baralhos.Remove(ObterPorId(idBaralho, baralhos));
        }

        public Baralho ObterPorId(int idBaralho, List<Baralho> baralhos)
        {
            return baralhos.FirstOrDefault(baralho => baralho.IdBaralho == idBaralho);
        }

        public List<Baralho> ObterTodos(List<Baralho> baralhos)
        {
            return baralhos;
        }
    }
}