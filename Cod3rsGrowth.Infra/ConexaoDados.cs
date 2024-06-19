using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;
using LinqToDB.Data;

namespace Cod3rsGrowth.Infra
{
    public class ConexaoDados : DataConnection
    {
        public ConexaoDados() : base("contextoPadrao") {}
        public ITable<Carta> TabelaCartas => this.GetTable<Carta>();
        public ITable<CopiaDeCartasNoBaralho> TabelaCartasDoBaralhos => this.GetTable<CopiaDeCartasNoBaralho>();
        public ITable<Baralho> TabelaBaralhos => this.GetTable<Baralho>();
        public ITable<Jogador> TabelaJogadores => this.GetTable<Jogador>();
    }
}