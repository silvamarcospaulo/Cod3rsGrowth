using FluentMigrator;

namespace Cod3rsGrowth.Dominio.Migrador
{
    [Migration(20240621105800)]
    public class _20240621105800 : Migration
    {
        public override void Up()
        {
            Create.Table("Carta")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("Nome").AsString(255).NotNullable()
                .WithColumn("CustoDeManaConvertido").AsInt64().NotNullable()
                .WithColumn("TipoDeCarta").AsInt32().NotNullable()
                .WithColumn("Raridade").AsString(255).NotNullable()
                .WithColumn("Preco").AsDecimal().NotNullable()
                .WithColumn("Cor").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Carta");
        }
    }
}