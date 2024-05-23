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
        public BaralhoRepositoryMock()
        {
            List<ListaDeCartasTabela> _listDeCartasTabelas = Singleton.SingletonTabelas<List<ListaDeCartasTabela>>.Instance();
            List<Baralho> _baralho = Singleton.SingletonTabelas<List<Baralho>>.Instance();
        }
        public void Excluir(int idBaralho)
        {
            //baralhos.Remove(ObterPorId(idBaralho));
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return new Baralho();
            //baralhos.FirstOrDefault(baralho => baralho.IdBaralho == idBaralho);
        }

        public List<Baralho> ObterTodos()
        {
            return new List<Baralho>();
        }
    }
}