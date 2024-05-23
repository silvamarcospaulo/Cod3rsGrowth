using Cod3rsGrowth.Dominio.Modelos;

public class Singleton
{
    public sealed class SingletonTabelas
    {
        public static List<Carta> instanceCarta;
        public static List<CopiaDeCartasNoBaralho> instanceCopiaDeCartasNoBaralho;
        public static List<Baralho> instanceBaralho;
        public static List<Jogador> instanceJogador;

        public static List<Carta> GetInstanceCarta()
        {
            lock (typeof(List<Carta>))
            {
                if (instanceCarta == null)
                {
                    instanceCarta = new List<Carta>();
                }
            }
            return instanceCarta;
        }

        public static List<CopiaDeCartasNoBaralho> GetInstanceCopiaDeCartasNoBaralho()
        {
            lock (typeof(List<CopiaDeCartasNoBaralho>))
            {
                if (instanceCopiaDeCartasNoBaralho == null)
                {
                    instanceCopiaDeCartasNoBaralho = new List<CopiaDeCartasNoBaralho>();
                }
            }
            return instanceCopiaDeCartasNoBaralho;
        }

        public static List<Baralho> GetInstanceBaralho()
        {
            lock (typeof(List<Baralho>))
            {
                if (instanceBaralho == null)
                {
                    instanceBaralho = new List<Baralho>();
                }
            }
            return instanceBaralho;
        }

        public static List<Jogador> GetInstanceJogador()
        {
            lock (typeof(List<Jogador>))
            {
                if (instanceJogador == null)
                {
                    instanceJogador = new List<Jogador>();
                }
            }
            return instanceJogador;
        }
    }
}