using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;
using LinqToDB.Data;

namespace Cod3rsGrowth.Infra
{
    public class ConexaoDados : DataConnection
    {
        public ConexaoDados(DataOptions<ConexaoDados> options) : base(options.Options) { }
        public ITable<Carta> TabelaCarta => this.GetTable<Carta>();
        public ITable<CorCarta> TabelaCorCarta => this.GetTable<CorCarta>();
        public ITable<CopiaDeCartasNoBaralho> TabelaCartasDoBaralho => this.GetTable<CopiaDeCartasNoBaralho>();
        public ITable<Baralho> TabelaBaralho => this.GetTable<Baralho>();
        public ITable<CorBaralho> TabelaCorBaralho => this.GetTable<CorBaralho>();
        public ITable<Jogador> TabelaJogador => this.GetTable<Jogador>();
    }
}