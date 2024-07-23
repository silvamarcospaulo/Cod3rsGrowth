using System;
using LinqToDB.Mapping;

namespace Cod3rsGrowth.Dominio.Modelos
{
    [Table("CopiaDeCartas")]
    public class CopiaDeCartasNoBaralho
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column("IdBaralho")]
        public int IdBaralho { get; set; }

        [Column("IdCarta")]
        public int IdCarta { get; set; }

        [Column("Quantidade")]
        public int QuantidadeCopiasDaCartaNoBaralho { get; set; }

        public Carta? Carta { get; set; }
        public string? NomeCarta { get; set; }
    }
}