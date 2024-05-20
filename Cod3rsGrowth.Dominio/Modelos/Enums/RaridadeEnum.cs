using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio.Modelos.Enums
{
    public enum RaridadeEnum
    {
        [Description("Common")]
        Common = 'C',
        [Description("Uncommon")]
        Uncommon = 'U',
        [Description("Rare")]
        Rare = 'R',
        [Description("Mythic")]
        Mythic = 'M'
    }
}
