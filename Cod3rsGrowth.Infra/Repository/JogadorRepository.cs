using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;
using static LinqToDB.Reflection.Methods.LinqToDB.Insert;

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
            return conexaoDados.GetTable<Jogador>().FirstOrDefault(jogador => jogador.Id == idJogador) ?? throw new NullReferenceException("Jogador não encontrado");
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

            if (filtro?.NomeJogador is not null)
            {
                query = from q in query
                        where q.NomeJogador == filtro.NomeJogador
                        select q;
            }

            if (filtro?.SobrenomeJogador is not null)
            {
                query = from q in query
                        where q.SobrenomeJogador == filtro.SobrenomeJogador
                        select q;
            }

            if (filtro?.UsuarioJogador is not null)
            {
                query = from q in query
                        where q.UsuarioJogador == filtro.UsuarioJogador
                        select q;
            }

            if (filtro?.DataNascimentoJogador is not null)
            {
                query = from q in query
                        where q.DataNascimentoJogador == Convert.ToDateTime(filtro.DataNascimentoJogador)
                        select q;
            }

            if (filtro?.DataDeCriacaoContaJogador is not null)
            {
                const double MAXIMO_HORAS = 23;
                const double MAXIMO_MINUTOS_SEGUNDOS = 59;
                const double MAXIMO_MILISEGUNDOS = 999;


                var dataFiltroMin = Convert.ToDateTime(filtro.DataDeCriacaoContaJogador);

                var dataFiltroMax = dataFiltroMin.AddHours(MAXIMO_HORAS)
                                 .AddMinutes(MAXIMO_MINUTOS_SEGUNDOS)
                                 .AddSeconds(MAXIMO_MINUTOS_SEGUNDOS)
                                 .AddMilliseconds(MAXIMO_MILISEGUNDOS);

                query = from q in query
                        where q.DataDeCriacaoContaJogador >= dataFiltroMin
                        where q.DataDeCriacaoContaJogador <= dataFiltroMax
                        select q;
            }

            if (filtro?.ContaAtivaJogador is not null)
            {
                query = from q in query
                        where q.ContaAtivaJogador == filtro.ContaAtivaJogador
                        select q;
            }

            return query.ToList();
        }
    }
}