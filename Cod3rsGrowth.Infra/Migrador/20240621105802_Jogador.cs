using FluentMigrator;

namespace Cod3rsGrowth.Dominio.Migrador
{
    [Migration(20240621105802)]
    public class _20240621105802_Jogador : Migration
    {
        const int valorPadraoZero = 0;
        const string roleJogador = "Jogador";
        public override void Up()
        {
            Create.Table("Jogador")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("Nome").AsString(255).NotNullable()
                .WithColumn("Sobrenome").AsString(255).NotNullable()
                .WithColumn("Usuario").AsString(255).Unique().NotNullable()
                .WithColumn("SenhaHash").AsString(255).NotNullable()
                .WithColumn("Role").AsString(255).NotNullable().WithDefaultValue(roleJogador)
                .WithColumn("DataDeNascimento").AsDateTime().NotNullable()
                .WithColumn("DataDeCriacaoConta").AsDateTime().NotNullable()
                .WithColumn("PrecoDasCartas").AsDecimal().WithDefaultValue(Convert.ToDecimal(valorPadraoZero)).NotNullable()
                .WithColumn("QuantidadeDeBaralhos").AsInt64().WithDefaultValue(valorPadraoZero).NotNullable()
                .WithColumn("ContaAtiva").AsBoolean().WithDefaultValue(false).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Jogador");
        }
    }
}