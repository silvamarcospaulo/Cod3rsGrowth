using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio.Filtros
{
    public class BaralhoFiltro
    {
        public int? IdJogador { get; set; }
        public List<FormatoDeJogoEnum>? FormatoDeJogoBaralho { get; set; }
        public decimal? PrecoDoBaralhoMinimo { get; set; }
        public decimal? PrecoDoBaralhoMaximo { get; set; }
        public List<string>? CorBaralho { get; set; }
    }
}