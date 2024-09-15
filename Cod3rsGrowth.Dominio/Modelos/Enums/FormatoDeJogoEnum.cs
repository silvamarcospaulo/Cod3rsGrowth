using System.ComponentModel;

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