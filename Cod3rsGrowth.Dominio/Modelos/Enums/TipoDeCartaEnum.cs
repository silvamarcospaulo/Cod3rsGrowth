using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio.Modelos.Enums
{
    public enum TipoDeCartaEnum
    {
        [Description("Terreno Basico")]
        TerrenoBasico = 'B',
        [Description("Terreno")]
        Terreno = 'L',
        [Description("Criatura")]
        Criatura = 'C',
        [Description("Feitico")]
        Feitico = 'S',
        [Description("Magica Instantanea")]
        Instantanea = 'I',
        [Description("Artefato")]
        Artefato = 'A'
    }
}