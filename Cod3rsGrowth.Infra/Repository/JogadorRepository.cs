using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;

namespace Cod3rsGrowth.Infra.Repository
{
    public class JogadorRepository : IJogadorRepository
    {
        private ConexaoDados conexaoDados = new ConexaoDados();

        public void Criar(Jogador jogador)
        {
            conexaoDados.Insert(jogador);
        }

        public void Atualizar(Jogador jogador)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Jogador jogador)
        {
            throw new NotImplementedException();
        }

        public Jogador ObterPorId(int idJogador)
        {
            throw new NotImplementedException();
        }

        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            if (filtro == null) return conexaoDados.TabelaJogadores.ToList();

            IQueryable<Jogador> query = conexaoDados.TabelaJogadores.AsQueryable();

            if (filtro.NomeJogador != null) query = query.Where(q => q.NomeJogador.Contains(filtro.NomeJogador));

            if (filtro.ContaAtivaJogador.HasValue) query = query.Where(q => q.ContaAtivaJogador == filtro.ContaAtivaJogador);

            if (filtro.DataNascimentoJogadorMinimo.HasValue) query = query.Where(q => q.DataNascimentoJogador >= filtro.DataNascimentoJogadorMinimo);

            if (filtro.DataNascimentoJogadorMaximo.HasValue) query = query.Where(q => q.DataNascimentoJogador <= filtro.DataNascimentoJogadorMaximo);

            if (filtro.PrecoDasCartasJogadorMinimo.HasValue) query = query.Where(q => q.PrecoDasCartasJogador >= filtro.PrecoDasCartasJogadorMinimo);

            if (filtro.PrecoDasCartasJogadorMaximo.HasValue) query = query.Where(q => q.PrecoDasCartasJogador <= filtro.PrecoDasCartasJogadorMaximo);

            if (filtro.QuantidadeDeBaralhosJogadorMinimo.HasValue) query = query.Where(q => q.QuantidadeDeBaralhosJogador >= filtro.QuantidadeDeBaralhosJogadorMinimo);

            if (filtro.QuantidadeDeBaralhosJogadorMaximo.HasValue) query = query.Where(q => q.QuantidadeDeBaralhosJogador >= filtro.QuantidadeDeBaralhosJogadorMaximo);

            return query.ToList();
        }
    }
}