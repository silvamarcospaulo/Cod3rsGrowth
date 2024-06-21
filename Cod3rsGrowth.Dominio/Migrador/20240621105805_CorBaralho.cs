using FluentMigrator;

namespace Cod3rsGrowth.Dominio.Migrador
{
    [Migration(20240621105805)]
    public class _20240621105805_CorBaralho : Migration
    {
        public override void Up()
        {
            Create.Table("CorBaralho")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("IdBaralho").AsInt64().NotNullable().ForeignKey("Baralho", "Id")
                .WithColumn("Cor").AsString(255).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("CorBaralho");
        }
    }
}