using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio
{
    public enum FormatoDeJogoEnum
    {
        [Description("Commander")]
        Commander = 'C',
        [Description("Standard")]
        Standard = 'S',
        [Description("Pauper")]
        Pauper = 'P'
    }
}