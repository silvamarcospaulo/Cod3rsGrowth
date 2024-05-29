using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Teste.Singleton
{
    public static class TabelaJogadores
    {
        public static List<Jogador> TabelaDeJogadores()
        {
            return new List<Jogador>()
            {
                new Jogador()
                {
                    IdJogador = 1,
                    NomeJogador = "Marcos",
                    DataNascimentoJodador = Convert.ToDateTime("08/03/1999"),
                    CustoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                },
                new Jogador()
                {
                    IdJogador = 2,
                    NomeJogador = "Paulo",
                    DataNascimentoJodador = Convert.ToDateTime("09/03/1999"),
                    CustoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                },
                new Jogador()
                {
                    IdJogador = 3,
                    NomeJogador = "Silva",
                    DataNascimentoJodador = Convert.ToDateTime("10/03/1999"),
                    CustoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                }
            };
        }
    }
}