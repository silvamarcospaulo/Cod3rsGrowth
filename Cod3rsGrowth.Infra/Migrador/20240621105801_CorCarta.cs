using FluentMigrator;

namespace Cod3rsGrowth.Dominio.Migrador
{
    [Migration(20240621105801)]
    public class _20240621105801_CorCarta : Migration
    {
        public override void Up()
        {
            Create.Table("CorCarta")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("IdCarta").AsInt64().ForeignKey("Carta", "Id")
                .WithColumn("Cor").AsString(255).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("CorCarta");
        }

    }
}