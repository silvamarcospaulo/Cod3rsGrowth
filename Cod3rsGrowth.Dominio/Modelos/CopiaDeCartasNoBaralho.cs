using System;
using LinqToDB.Mapping;

namespace Cod3rsGrowth.Dominio.Modelos
{
    [Table("CopiaDeCartas")]
    public class CopiaDeCartasNoBaralho
    {
        [PrimaryKey, Identity]
        public int IdCopiaDeCartasNoBaralho { get; set; }
        [Column("Id")]
        public int IdBaralho { get; set; }
        [Column("IdCarta")]
        public Carta Carta { get; set; }
        [Column("Quantidade")]
        public int QuantidadeCopiasDaCartaNoBaralho { get; set; }
    }
}