using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;
using LinqToDB.Data;

namespace Cod3rsGrowth.Infra
{
    public class ConexaoDados : DataConnection
    {
        const string stringDeConexao = "DeckBuilderDb";
        public ConexaoDados(DataOptions<ConexaoDados> options) : base(options.Options) { }
        public ITable<Carta> TabelaCartas => this.GetTable<Carta>();
        public ITable<CopiaDeCartasNoBaralho> TabelaCartasDoBaralhos => this.GetTable<CopiaDeCartasNoBaralho>();
        public ITable<Baralho> TabelaBaralhos => this.GetTable<Baralho>();
        public ITable<Jogador> TabelaJogadores => this.GetTable<Jogador>();
    }
}