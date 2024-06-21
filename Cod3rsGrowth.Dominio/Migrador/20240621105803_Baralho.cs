using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinqToDB.Reflection.Methods.LinqToDB;

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
                .WithColumn("IdJogador").AsInt64().NotNullable().ForeignKey("Jogador", "Id").Identity()
                .WithColumn("Nome").AsString(255).NotNullable()
                .WithColumn("DataDeCriacao").AsTime().NotNullable()
                .WithColumn("FomatoDeJogo").AsString(255).NotNullable()
                .WithColumn("QuantidadDeCartas").AsInt64().WithDefaultValue(valorPadraoZero).NotNullable()
                .WithColumn("Preco").AsDecimal().WithDefaultValue(Convert.ToDecimal(valorPadraoZero)).NotNullable()
                .WithColumn("CustoDeManaConvertido").AsInt64().WithDefaultValue(valorPadraoZero).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Baralho");
        }
    }
}