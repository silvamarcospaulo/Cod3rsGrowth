using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Teste.Singleton
{
    public class SingletonTabelas
    {
        private static Lazy<List<Carta>> instanciaCartas = new Lazy<List<Carta>>(() => new List<Carta>());
        private static Lazy<List<Baralho>> instanciaBaralhos = new Lazy<List<Baralho>>(() => new List<Baralho>());
        private static Lazy<List<Jogador>> instanciaJogadores = new Lazy<List<Jogador>>(() => new List<Jogador>());

        private SingletonTabelas()
        {
        }
        public static List<Carta> InstanciaCartas
        {
            get => instanciaCartas.Value;
            set => instanciaCartas = new Lazy<List<Carta>>(() => value ?? new List<Carta>());
        }
        public static List<Baralho> InstanciaBaralhos => instanciaBaralhos.Value;
        public static List<Jogador> InstanciaJogadores => instanciaJogadores.Value;
    }
}