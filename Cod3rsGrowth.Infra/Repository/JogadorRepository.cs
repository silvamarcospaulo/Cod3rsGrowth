using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;

namespace Cod3rsGrowth.Infra.Repository
{
    public class JogadorRepository : IJogadorRepository
    {
        private ConexaoDados conexaoDados;

        public JogadorRepository(ConexaoDados _conexaoDados)
        {
            conexaoDados = _conexaoDados;
        }

        public int Criar(Jogador jogador)
        {
            return conexaoDados.InsertWithInt32Identity(jogador);
        }

        public Jogador Atualizar(Jogador jogador)
        {
            conexaoDados.Update(jogador);
            return jogador;
        }

        public void Excluir(int idJogador)
        {
            var jogadorExcluir = ObterPorId(idJogador);
            conexaoDados.Delete(jogadorExcluir);
        }

        public Jogador ObterPorId(int idJogador)
        {
            return conexaoDados.GetTable<Jogador>().FirstOrDefault(jogador => jogador.Id == idJogador);
        }

        public Jogador AutenticaLogin(Jogador jogador)
        {
            IQueryable<Jogador> query = from q in conexaoDados.TabelaJogador
                                        select q;

            if (jogador?.UsuarioJogador is not null)
            {
                query = from q in query
                        where q.UsuarioJogador == jogador.UsuarioJogador && q.SenhaHashJogador == jogador.SenhaHashJogador
                        select q;
            }

            return query.FirstOrDefault() ?? throw new Exception("Conta não existente. Verifique os dados inseridos ou crie uma conta");
        }

        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            IQueryable<Jogador> query = from q in conexaoDados.TabelaJogador
                                        select q;

            if (filtro?.NomeJogador != null)
            {
                query = from q in query
                        where q.NomeJogador == filtro.NomeJogador
                        select q;
            }

            if (filtro?.SobrenomeJogador != null)
            {
                query = from q in query
                        where q.SobrenomeJogador == filtro.SobrenomeJogador
                        select q;
            }

            if (filtro?.UsuarioJogador != null)
            {
                query = from q in query
                        where q.UsuarioJogador == filtro.UsuarioJogador
                        select q;
            }

            if (filtro?.DataNascimentoJogador != null)
            {
                query = from q in query
                        where q.DataNascimentoJogador == filtro.DataNascimentoJogador
                        select q;
            }

            if (filtro?.ContaAtivaJogador != null)
            {
                query = from q in query
                        where q.ContaAtivaJogador == filtro.ContaAtivaJogador
                        select q;
            }

            return query.ToList();
        }
    }
}