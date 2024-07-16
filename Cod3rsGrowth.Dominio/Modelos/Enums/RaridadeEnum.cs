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
        [Description("Comum")]
        Comum = 0,
        [Description("Incomum")]
        Incomum = 1,
        [Description("Raro")]
        Raro = 2,
        [Description("Mítico")]
        Mitico = 3,
        [Description("Desconhecido")]
        Desconhecido = 4
    }
}