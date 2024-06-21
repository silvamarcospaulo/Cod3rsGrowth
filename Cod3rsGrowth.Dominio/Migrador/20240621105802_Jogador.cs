using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio.Migrador
{
    [Migration(20240621105802)]
    public class _20240621105802_Jogador : Migration
    {
        const int valorPadraoZero = 0;
        public override void Down()
        {
            Create.Table("Jogador")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("Nome").AsString(255).NotNullable()
                .WithColumn("DataDeNascimento").AsTime().NotNullable()
                .WithColumn("PrecoDasCartas").AsDecimal().WithDefaultValue(Convert.ToDecimal(valorPadraoZero)).NotNullable()
                .WithColumn("QuantidadeDeBaralhos").AsInt64().WithDefaultValue(valorPadraoZero).NotNullable()
                .WithColumn("ContaAtiva").AsBoolean().WithDefaultValue(false).NotNullable();
        }

        public override void Up()
        {
            Delete.Table("Jogador");
        }
    }
}