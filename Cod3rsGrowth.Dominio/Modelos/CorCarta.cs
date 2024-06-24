using Cod3rsGrowth.Dominio.Modelos.Enums;
using LinqToDB.Mapping;

namespace Cod3rsGrowth.Dominio.Modelos
{
    [Table("CorCarta")]
    public class CorCarta
    {
        [PrimaryKey, Identity]
        public int IdCorCarta { get; set; }
        [Column("IdCarta")]
        public int IdCarta { get; set; }
        [Column("Cor")]
        public CoresEnum Cor { get; set; }
    }
}