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
                .WithColumn("TipoDeCarta").AsString(255).NotNullable()
                .WithColumn("Raridade").AsString(255).NotNullable()
                .WithColumn("Preco").AsDecimal().NotNullable();

            Create.Table("CorBaralho")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("IdBaralho").AsInt64().NotNullable().ForeignKey("Baralho", "Id")
                .WithColumn("Cor").AsInt64().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("CorBaralho");
            Delete.Table("CopiaDeCartasNoBaralho");
            Delete.Table("Baralho");
            Delete.Table("Jogador");
            Delete.Table("Carta");
        }
    }
}