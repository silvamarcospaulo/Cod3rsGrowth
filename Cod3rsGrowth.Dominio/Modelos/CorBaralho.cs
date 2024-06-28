using Cod3rsGrowth.Dominio.Modelos.Enums;
using LinqToDB.Mapping;

namespace Cod3rsGrowth.Dominio.Modelos
{
    [Table("CorBaralho")]
    public class CorBaralho
    {
        [PrimaryKey, Identity]
        public int IdCorBaralho { get; set; }
        [Column("Id")]
        public int IdBaralho { get; set; }
        [Column("Cor")]
        public CoresEnum Cor { get; set; }
    }
}