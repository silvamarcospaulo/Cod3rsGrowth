using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;

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
            return conexaoDados.GetTable<Carta>().FirstOrDefault(carta => carta.Id == idCarta) ??
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

            if (filtro?.CorCarta?.Count > 0)
            {
                foreach (var cor in filtro?.CorCarta)
                {
                    query = from q in query
                            where q.CorCarta == cor
                            select q;
                }
            }

            if (filtro?.TipoDeCarta?.Count > 0)
            {
                foreach (var tipo in filtro?.TipoDeCarta)
                {
                    query = from q in query
                            where q.TipoDeCarta.Contains(tipo)
                            select q;
                }
            }

            if (filtro?.RaridadeCarta?.Count > 0)
            {
                foreach (var raridade in filtro?.RaridadeCarta)
                {
                    query = from q in query
                            where q.RaridadeCarta == raridade
                            select q;
                }
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

            return query.ToList();
        }
    }
}