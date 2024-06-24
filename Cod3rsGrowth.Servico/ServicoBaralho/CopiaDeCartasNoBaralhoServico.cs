using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoCarta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class CopiaDeCartasNoBaralhoServico : ICopiaDeCartasNoBaralhoRepository
    {
        private ICopiaDeCartasNoBaralhoRepository _copiaDeCartasNoBaralho;
        private CartaServico _cartaServico;

        public CopiaDeCartasNoBaralhoServico(ICopiaDeCartasNoBaralhoRepository copiaDeCartasNoBaralho, CartaServico cartaServico)
        {
            _copiaDeCartasNoBaralho = copiaDeCartasNoBaralho;
            _cartaServico = cartaServico;
        }

        public void Criar(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            _copiaDeCartasNoBaralho.ObterPorId(copiaDeCartasNoBaralho.IdCopiaDeCartasNoBaralho);
        }

        public void Excluir(int idCopiaDeCartasNoBaralho)
        {
            throw new NotImplementedException();
        }

        public CopiaDeCartasNoBaralho ObterPorId(int idCopiaDeCartasNoBaralho)
        {
            var copiaDeCarta = new CopiaDeCartasNoBaralho();
            copiaDeCarta = _copiaDeCartasNoBaralho.ObterPorId(idCopiaDeCartasNoBaralho);
            copiaDeCarta.Carta = _cartaServico.ObterPorId(copiaDeCarta.Carta.IdCarta);

            return copiaDeCarta;
        }

        public List<CopiaDeCartasNoBaralho> ObterTodos(CopiaDeCartasNoBaralhoFiltro filtro)
        {
            throw new NotImplementedException();
        }
    }
}