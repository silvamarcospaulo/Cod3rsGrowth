using FluentMigrator;

namespace Cod3rsGrowth.Dominio.Migrador
{
    [Migration(20240621105804)]
    public class _20240621105804_CopiaDeCartas : Migration
    {
        public override void Up()
        {
            Create.Table("CopiaDeCartas")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("IdBaralho").AsInt64().NotNullable().ForeignKey("Baralho", "Id")
                .WithColumn("IdCarta").AsInt64().NotNullable().ForeignKey("Carta", "Id")
                .WithColumn("Quantidade").AsInt64().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("CopiaDeCartas");
        }
    }
}