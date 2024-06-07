using System;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Dominio.Modelos
{
    public class Baralho
    {
        public int IdBaralho { get; set; }
        public int IdJogador { get; set; }
        public string NomeBaralho { get; set; }
        public FormatoDeJogoEnum FormatoDeJogoBaralho { get; set; }
        public List<CopiaDeCartasNoBaralho> CartasDoBaralho { get; set; }
        public int QuantidadeDeCartasNoBaralho { get; set; }
        public decimal PrecoDoBaralho { get; set; }
        public int CustoDeManaConvertidoDoBaralho { get; set; }
        public List<CoresEnum> CorBaralho { get; set; }
    }
}