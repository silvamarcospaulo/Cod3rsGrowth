using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;
using static LinqToDB.Reflection.Methods.LinqToDB;

namespace Cod3rsGrowth.Infra.Repository
{
    public class CartaRepository : ICartaRepository
    {
        private ConexaoDados conexaoDados;

        public CartaRepository(ConexaoDados _conexaoDados)
        {
            conexaoDados = _conexaoDados;
        }

        public int Criar(Carta carta)
        {
            return conexaoDados.InsertWithInt32Identity(carta);
        }

        public void Atualizar(Carta carta)
        {
            conexaoDados.Update(carta);
        }

        public Carta ObterPorId(int idCarta)
        {
            return conexaoDados.GetTable<Carta>().FirstOrDefault(carta => carta.IdCarta == idCarta) ??
                throw new Exception($"Carta {idCarta} Nao Encontrada");
        }

        public List<Carta> ObterTodos(CartaFiltro? filtro)
        {
            IQueryable<Carta> query = from q in conexaoDados.TabelaCarta
                                        select q;

            if (filtro?.NomeCarta != null)
            {
                query = from q in query
                        where q.NomeCarta.Contains(filtro.NomeCarta)
                        select q;
            }

            if (filtro?.CustoDeManaConvertidoCarta != null)
            {
                query = from q in query
                        where q.CustoDeManaConvertidoCarta == filtro.CustoDeManaConvertidoCarta
                        select q;
            }

            if (filtro?.TipoDeCarta != null)
            {
                query = from q in query
                        where q.TipoDeCarta == filtro.TipoDeCarta
                        select q;
            }

            if (filtro?.RaridadeCarta != null)
            {
                query = from q in query
                        where q.RaridadeCarta == filtro.RaridadeCarta
                        select q;
            }

            if (filtro?.PrecoCartaMinimo != null)
            {
                query = from q in query
                        where q.PrecoCarta >= filtro.PrecoCartaMinimo
                        select q;
            }

            if (filtro?.PrecoCartaMaximo != null)
            {
                query = from q in query
                        where q.PrecoCarta >= filtro.PrecoCartaMaximo
                        select q;
            }

            if (filtro?.PrecoCartaMaximo != null)
            {
                query = from q in query
                        where q.PrecoCarta >= filtro.PrecoCartaMaximo
                        select q;
            }

            return query.ToList();
        }

        public void CriarCorCarta(CorCarta corCarta)
        {
            conexaoDados.Insert(corCarta);
        }

        public List<CorCarta> ObterTodosCorCarta(CorCartaFiltro? filtro)
        {
            IQueryable<CorCarta> query = from q in conexaoDados.TabelaCorCarta
                select q;

            if (filtro?.idCarta != null)
            {
                query = from q in query
                        where q.IdCarta == filtro.idCarta
                        select q;
            }

            return query.ToList();
        }
    }
}