﻿using Cod3rsGrowth.Dominio.Filtros;
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

        public Carta Criar(Carta carta)
        {
            conexaoDados.Insert(carta);
            return IQueryable <Carta> query = from  in conexaoDados.TabelaCartas select ;
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
            const int valorMinimoCoresCarta = 1;
            IQueryable<Carta> query = from q in conexaoDados.TabelaCartas
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

            if (filtro?.CorCarta.Count() >= valorMinimoCoresCarta)
            {
                query = from q in query
                        where q.CorCarta.All(corCarta => filtro.CorCarta.All(cor => cor == corCarta.Cor))
                        select q;
            }

            return query.ToList();
        }
    }
}