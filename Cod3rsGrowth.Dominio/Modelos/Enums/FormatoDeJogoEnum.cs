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
        Commander = 1,
        [Description("Standard")]
        Standard = 2,
        [Description("Pauper")]
        Pauper = 3
    }
}