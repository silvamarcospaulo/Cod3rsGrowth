using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio.Modelos.Enums
{
    public enum CoresEnum
    {
        [Description("Branco")]
        Branco = 'W',
        [Description("Azul")]
        Azul = 'U',
        [Description("Preto")]
        Preto = 'B',
        [Description("Vermelho")]
        Vermelho = 'R',
        [Description("Verde")]
        Verde = 'G',
    }
}