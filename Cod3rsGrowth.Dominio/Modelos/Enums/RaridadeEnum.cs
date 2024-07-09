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
        Common = 0,
        [Description("Uncommon")]
        Uncommon = 1,
        [Description("Rare")]
        Rare = 2,
        [Description("Mythic")]
        Mythic = 3,
        [Description("Desconhecido")]
        Desconhecido = 4
    }
}