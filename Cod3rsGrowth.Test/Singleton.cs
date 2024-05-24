using Cod3rsGrowth.Dominio.Modelos;
using NUnit.Framework.Constraints;

public class Singleton
{
    public sealed class SingletonTabelas
    {
        private static  Lazy<SingletonTabelas>? Lazy = new Lazy<SingletonTabelas>(() => new SingletonTabelas());
        public List<Carta> Cartas;
        public List<CopiaDeCartasNoBaralho> CopiaDeCartasNosBaralhos;
        public List<Baralho> Baralhos;
        public List<Jogador> Jogadores;

        private SingletonTabelas()
        {
            Cartas = new List<Carta>();
            CopiaDeCartasNosBaralhos = new List<CopiaDeCartasNoBaralho>();
            Baralhos = new List<Baralho>();
            Jogadores = new List<Jogador>();
        }
        public static SingletonTabelas ObterInstancia
        {
            get{ return Lazy.Value; }
        }
    }
}