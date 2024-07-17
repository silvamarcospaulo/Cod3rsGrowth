using FluentMigrator;

namespace Cod3rsGrowth.Dominio.Migrador
{
    [Migration(20240621105803)]
    public class _20240621105803_Baralho : Migration
    {
        const int valorPadraoZero = 0;
        public override void Up()
        {
            Create.Table("Baralho")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("IdJogador").AsInt64().NotNullable().ForeignKey("Jogador", "Id")
                .WithColumn("Nome").AsString(255).NotNullable()
                .WithColumn("DataDeCriacao").AsDateTime().NotNullable()
                .WithColumn("FormatoDeJogo").AsInt32().NotNullable()
                .WithColumn("QuantidadeDeCartas").AsInt64().WithDefaultValue(valorPadraoZero).NotNullable()
                .WithColumn("Preco").AsDecimal().WithDefaultValue(Convert.ToDecimal(valorPadraoZero)).NotNullable()
                .WithColumn("CustoDeManaConvertido").AsInt64().WithDefaultValue(valorPadraoZero).NotNullable()
                .WithColumn("Cor").AsString(255).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Baralho");
        }
    }
}