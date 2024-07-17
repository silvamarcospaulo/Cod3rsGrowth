using FluentMigrator;

namespace Cod3rsGrowth.Dominio.Migrador
{
    [Migration(20240621105800)]
    public class _20240621105800_Carta : Migration
    {
        public override void Up()
        {
            Create.Table("Carta")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("Nome").AsString(255).NotNullable()
                .WithColumn("CustoDeManaConvertido").AsInt32().NotNullable()
                .WithColumn("TipoDeCarta").AsString(255).NotNullable()
                .WithColumn("Raridade").AsInt32().NotNullable()
                .WithColumn("Preco").AsDecimal().NotNullable()
                .WithColumn("Cor").AsString(255).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Carta");
        }
    }
}