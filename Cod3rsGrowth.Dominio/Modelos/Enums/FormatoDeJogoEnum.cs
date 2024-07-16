using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio.Modelos.Enums
{
    public enum FormatoDeJogoEnum
    {
        [Description("Commander")]
        Commander = 0,
        [Description("Standard")]
        Standard = 1,
        [Description("Pauper")]
        Pauper = 2
    }
}