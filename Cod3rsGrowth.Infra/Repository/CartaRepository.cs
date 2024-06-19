using System;
using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository
{
    public class CartaRepository : ICartaRepository
    {
        public void Atualizar(Carta carta)
        {
            throw new NotImplementedException();
        }

        public void Criar(Carta carta)
        {
            throw new NotImplementedException();
        }

        public Carta ObterPorId(int idCarta)
        {
            throw new NotImplementedException();
        }

        public List<Carta> ObterTodos(CartaFiltro? filtro)
        {
            using (var contextoCarta = new ConexaoDados())
            {
                if (filtro == null) return contextoCarta.TabelaCartas.ToList();

                IQueryable<Carta> query = contextoCarta.TabelaCartas.AsQueryable();

                if (filtro.NomeCarta != null) query = query.Where(q => q.NomeCarta.Contains(filtro.NomeCarta));

                if (filtro.CustoDeManaConvertidoCarta.HasValue) query = query.Where(q => q.CustoDeManaConvertidoCarta == filtro.CustoDeManaConvertidoCarta);

                if (filtro.TipoDeCarta.HasValue) query = query.Where(q => q.TipoDeCarta >= filtro.TipoDeCarta);

                if (filtro.RaridadeCarta.HasValue) query = query.Where(q => q.RaridadeCarta <= filtro.RaridadeCarta);

                if (filtro.PrecoCartaMinimo.HasValue) query = query.Where(q => q.PrecoCarta >= filtro.PrecoCartaMinimo);

                if (filtro.PrecoCartaMaximo.HasValue) query = query.Where(q => q.PrecoCarta <= filtro.PrecoCartaMaximo);

                if (filtro.CorCarta.HasValue) query = query.Where(q => q.CorCarta.All(corCarta => corCarta == filtro.CorCarta));

                return query.ToList();
            };
        }
    }
}