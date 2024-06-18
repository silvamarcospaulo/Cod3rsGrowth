using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;
using LinqToDB.Data;

namespace Cod3rsGrowth.Infra
{
    public class ConexaoDados : DataConnection
    {
        public ConexaoDados(DataOptions<ConexaoDados> options) : base(options.Options){}

        public ITable<Carta> Cartas => this.GetTable<Carta>();
        public ITable<CopiaDeCartasNoBaralho> CartasDoBaralho => this.GetTable<CopiaDeCartasNoBaralho>();
        public ITable<Baralho> Baralhos => this.GetTable<Baralho>();
        public ITable<Jogador> Jogadores => this.GetTable<Jogador>();
    }
}