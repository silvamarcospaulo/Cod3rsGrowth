using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Dominio.Filtros
{
    public class JogadorFiltro
    {
        public string? NomeJogador { get; set; }
        public string? SobrenomeJogador { get; set; }
        public string? UsuarioJogador { get; set; }
        public DateTime? DataNascimentoJogador { get; set; }
        public string? DataDeCriacaoContaJogador { get; set; }
        public bool? ContaAtivaJogador { get; set; }
    }
}