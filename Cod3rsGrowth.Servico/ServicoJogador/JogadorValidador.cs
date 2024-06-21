using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using FluentValidation;

namespace Cod3rsGrowth.Servico.ServicoJogador
{
    public class JogadorValidador : AbstractValidator<Jogador>
    {
        private const int quantidadeBaralhoPauper = 60;
        private const int quantidadeMaximaDeCopiaDeCartasStandard = 4;
        private const int quantidadeBaralhoStandard = 60;
        private const int quantidadeMaximaDeCopiaDeCartasCommander = 1;
        private const int quantidadeMaximaDeCopiaDeCartasPauper = 4;
        private const int quantidadeBaralhoCommander = 100;

        public JogadorValidador()
        {
            DateTime valorDataHoje = DateTime.Now;
            const int valorMinimoDeIdadeParaCriarConta = 13;
            int valorAnoDeNascimentoMinimo = Convert.ToInt32(valorDataHoje.Year) - valorMinimoDeIdadeParaCriarConta;
            DateTime valorDataNascimentoMinima = new DateTime(valorAnoDeNascimentoMinimo, valorDataHoje.Month, valorDataHoje.Day);


            RuleFor(jogador => jogador.NomeJogador)
            .NotEmpty().WithMessage("Nome do Jogador nao preenchido");

            RuleFor(jogador => jogador.DataNascimentoJogador)
            .NotNull().WithMessage("Data de nascimente nao pode ser nula")
            .NotEmpty().WithMessage("Data de nascimente nao preenchida")
            .LessThanOrEqualTo(valorDataNascimentoMinima).WithMessage("O jogador deve possuir mais de 13 anos para criar conta");

            RuleSet("Atualizar", () =>
            {
                RuleFor(jogador => jogador.BaralhosJogador)
                .Must(ValidacaoTipoDeBaralho).WithMessage("Quantidade de cartas do baralho nao compativel com o formato de jogo selecionado");
                
                RuleFor(jogador => jogador.NomeJogador)
                .NotEmpty().WithMessage("Nome do Jogador nao preenchido")
                .NotNull().WithMessage("Nome do Jogador nao preenchido2");

                RuleFor(jogador => jogador.DataNascimentoJogador)
                .NotNull().WithMessage("Data de nascimente nao pode ser nula")
                .NotEmpty().WithMessage("Data de nascimente nao preenchida")
                .LessThanOrEqualTo(valorDataNascimentoMinima).WithMessage("O jogador deve possuir mais de 13 anos para criar conta");
            });

            RuleSet("Excluir", () =>
            {
                RuleFor(jogador => jogador.BaralhosJogador)
                .Must(ValidacaoExclusaoDeJogador).WithMessage("Não e possivel excluir a conta, pois o jogador possui baralhos ativos");
            });
        }

        private static bool ValidacaoTipoDeBaralho(List<Baralho> baralhosJogador)
        {
            const int quantidadeDeBaralhosParaValidacao = 1;
            if (baralhosJogador.Count() >= quantidadeDeBaralhosParaValidacao)
            {
                foreach(var baralho in  baralhosJogador)
                {
                    switch (baralho.FormatoDeJogoBaralho)
                    {
                        case FormatoDeJogoEnum.Commander:
                            if (baralho.CartasDoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) != quantidadeBaralhoCommander) return false;

                            if (baralho.CartasDoBaralho.All(cartas => (cartas.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) && (cartas.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasCommander))) return false;

                            break;

                        case FormatoDeJogoEnum.Pauper:
                            if (baralho.CartasDoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) < quantidadeBaralhoPauper) return false;

                            if (baralho.CartasDoBaralho.All(cartas => (cartas.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) && (cartas.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasPauper))) return false;

                            if (baralho.CartasDoBaralho.All(cartas => cartas.Carta.RaridadeCarta != RaridadeEnum.Common)) return false;

                            break;

                        case FormatoDeJogoEnum.Standard:
                            if (baralho.CartasDoBaralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho) < quantidadeBaralhoStandard) return false;

                            if (baralho.CartasDoBaralho.All(cartas => (cartas.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) && (cartas.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasStandard))) return false;

                            break;
                    }
                }
            }
            return true;
        }

        private static bool ValidacaoExclusaoDeJogador(List<Baralho> baralhosJogador)
        {
            const int quantidadeDeBaralhosParaExclusao = 0;

            return baralhosJogador.Count == quantidadeDeBaralhosParaExclusao;
        }
    }
}