using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio
{
    public enum CoresEnum
    {
        [Description("Energia")]
        Energia = 'E',
        [Description("Phyrexiano")]
        Phyrexiano = 'P',
        [Description("Branco")]
        Branco = 'W',
        [Description("Azul")]
        Azul = 'U',
        [Description("Preto")]
        Preto = 'B',
        [Description("Vermelho")]
        Vermelho = 'R',
        [Description("Mana Generica")]
        ManaGenerica = 'C',
        [Description("Zero Mana")]
        ZeroMana = '0',
        [Description("Meia Mana Generica")]
        MeiaManaGenerica = '½',
        [Description("Uma Mana Generica")]
        UmaMana = '1',
        [Description("Duas Manas Genericas")]
        DuasManas = '2',
        [Description("Tres Manas Genericas")]
        TresManas = '3',
        [Description("Quatro Manas Genericas")]
        QuatroManas = '4',
        [Description("Cinco Manas Genericas")]
        CincoManas = '5',
        [Description("Seis Manas Genericas")]
        SeisManas = '6',
        [Description("Sete Manas Genericas")]
        SeteManas = '7',
        [Description("Oito Manas Genericas")]
        OitoManas = '8',
        [Description("Nove Manas Genericas")]
        NoveManas = '9'
    }
}
