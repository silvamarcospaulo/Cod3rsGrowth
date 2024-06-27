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
        [Description("Basic Land")]
        TerrenoBasico = 'B',
        [Description("Land")]
        Terreno = 'L',
        [Description("Creature")]
        Criatura = 'C',
        [Description("Socery")]
        Feitico = 'S',
        [Description("Instant")]
        Instantanea = 'I',
        [Description("Artifact")]
        Artefato = 'A'
    }
}