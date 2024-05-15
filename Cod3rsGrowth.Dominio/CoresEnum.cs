using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio
{
    public enum CoresEnum
    {
        [Description("Energia")]
        Energia = 'E',
        [Description("Phyrexiano")]
        Phyrexiano = 'P',
        [Description("Branco")]
        Branco = 'W',
        [Description("Azul")]
        Azul = 'U',
        [Description("Preto")]
        Preto = 'B',
        [Description("Vermelho")]
        Vermelho = 'R',
        [Description("Incolor")]
        ManaGenerica = 'C',
    }
}