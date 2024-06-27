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
        [Description("common")]
        Common = 'c',
        [Description("uncommon")]
        Uncommon = 'u',
        [Description("rare")]
        Rare = 'r',
        [Description("mythic")]
        Mythic = 'm'
    }
}