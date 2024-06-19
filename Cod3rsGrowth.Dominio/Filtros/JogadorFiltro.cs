using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Dominio.Filtros
{
    public class JogadorFiltro
    {
        public string? NomeJogador { get; set; }
        public DateTime? DataNascimentoJogadorMinimo { get; set; }
        public DateTime? DataNascimentoJogadorMaximo { get; set; }
        public decimal? PrecoDasCartasJogadorMinimo { get; set; }
        public decimal? PrecoDasCartasJogadorMaximo { get; set; }
        public int? QuantidadeDeBaralhosJogadorMinimo { get; set; }
        public int? QuantidadeDeBaralhosJogadorMaximo { get; set; }
        public bool? ContaAtivaJogador { get; set; }
    }
}