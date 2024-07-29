using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoCarta;
using FluentValidation;
using LinqToDB;
using LinqToDB.Data;
using Microsoft.Extensions.Options;
using System.Transactions;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class BaralhoServico : IBaralhoRepository
    {
        private readonly IBaralhoRepository _baralhoRepository;
        private readonly CartaServico _cartaServico;
        private readonly IValidator<Baralho> _validadorBaralho;
        private const int VALOR_NULO = 0;

        public BaralhoServico(IBaralhoRepository baralhoRepository, CartaServico cartaServico,
            IValidator<Baralho> validadorBaralho)
        {
            _baralhoRepository = baralhoRepository;
            _cartaServico = cartaServico;
            _validadorBaralho = validadorBaralho;
        }

        public static decimal SomarPrecoDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            if (baralho?.Count() > VALOR_NULO) return baralho.Sum(copia => copia.Carta.PrecoCarta * copia.QuantidadeCopiasDaCartaNoBaralho);
            return VALOR_NULO;
        }

        public static int SomarQuantidadeDeCartasDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {

            if (baralho?.Count() > VALOR_NULO) return baralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho);
            return VALOR_NULO;
        }

        public static string ConferirCoresDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            if (baralho?.Count() > VALOR_NULO)
            {
                var cores = baralho
                .SelectMany(carta => carta?.Carta?.CorCarta.Trim('{', '}').Split(',').Select(cor => cor.Trim()))
                .Where(caractere => !string.IsNullOrWhiteSpace(caractere)).Distinct();

                return string.Join(", ", cores);
            }

            return null;
        }

        public static int SomarCustoDeManaConvertidoDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            try
            {
                var custoDeManaConvertidoDoBaralho = 0;
                baralho.ForEach(carta => custoDeManaConvertidoDoBaralho += (carta.Carta.CustoDeManaConvertidoCarta * carta.QuantidadeCopiasDaCartaNoBaralho));
                custoDeManaConvertidoDoBaralho /= SomarQuantidadeDeCartasDoBaralho(baralho);
                return custoDeManaConvertidoDoBaralho;
            }
            catch (Exception e)
            {
                return VALOR_NULO;
            }
        }

        private static DateTime GerarDataDeCriacaoBaralho()
        {
            DateTime dataAtual = DateTime.Now;
            var dataCriacao = new DateTime(day: dataAtual.Day, month: dataAtual.Month, year: dataAtual.Year);
            return dataCriacao;
        }

        public Baralho ValidarBaralho(Baralho baralho)
        {
            try
            {
                var baralhoCriar = new Baralho
                {
                    IdJogador = baralho.IdJogador,
                    NomeBaralho = baralho.NomeBaralho,
                    FormatoDeJogoBaralho = baralho.FormatoDeJogoBaralho,
                    CartasDoBaralho = baralho.CartasDoBaralho,
                    PrecoDoBaralho = SomarPrecoDoBaralho(baralho.CartasDoBaralho),
                    QuantidadeDeCartasNoBaralho = SomarQuantidadeDeCartasDoBaralho(baralho.CartasDoBaralho),
                    CorBaralho = ConferirCoresDoBaralho(baralho.CartasDoBaralho),
                    CustoDeManaConvertidoDoBaralho = SomarCustoDeManaConvertidoDoBaralho(baralho.CartasDoBaralho),
                    DataDeCriacaoBaralho = GerarDataDeCriacaoBaralho()
                };

                _validadorBaralho.ValidateAndThrow(baralhoCriar);

                return baralhoCriar;
            }
            catch (ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Criar(Baralho baralho)
        {
            try
            {
                var baralhoCriar = ValidarBaralho(baralho);

                var idBaralhoCriado = _baralhoRepository.Criar(baralhoCriar);

                return idBaralhoCriado;
            }
            catch(ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao criar o baralho.\n{e.Message}");
            }
        }

        public void Atualizar(Baralho baralho)
        {
            var baralhoAtualizado = ObterPorId(baralho.Id);

            baralhoAtualizado.NomeBaralho = baralho.NomeBaralho;
            baralhoAtualizado.FormatoDeJogoBaralho = baralho.FormatoDeJogoBaralho;
            baralhoAtualizado.CartasDoBaralho = baralho.CartasDoBaralho;
            baralhoAtualizado.PrecoDoBaralho = SomarPrecoDoBaralho(baralho.CartasDoBaralho);
            baralhoAtualizado.QuantidadeDeCartasNoBaralho = SomarQuantidadeDeCartasDoBaralho(baralho.CartasDoBaralho);
            baralhoAtualizado.CorBaralho = ConferirCoresDoBaralho(baralho.CartasDoBaralho);
            baralhoAtualizado.CustoDeManaConvertidoDoBaralho = SomarCustoDeManaConvertidoDoBaralho(baralho.CartasDoBaralho);

            try
            {
                _validadorBaralho.ValidateAndThrow(baralhoAtualizado);
                _baralhoRepository.Atualizar(baralhoAtualizado);
            }
            catch (ValidationException e)
            {
                var mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public void Excluir(int idBaralho)
        {
            try
            {
                _baralhoRepository.Excluir(idBaralho);
            }
            catch (ValidationException e)
            {
                var mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public Baralho ObterPorId(int idBaralho)
        {
            var baralho = _baralhoRepository.ObterPorId(idBaralho);

            baralho.CartasDoBaralho = ObterTodosCopiaDeCartas(new CopiaDeCartasNoBaralhoFiltro() { IdBaralho = baralho.Id });

            return baralho;
        }

        public List<Baralho> ObterTodos(BaralhoFiltro? filtro)
        {
            var baralhos = _baralhoRepository.ObterTodos(filtro);

            return baralhos;
        }

        public void CriarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            _baralhoRepository.CriarCopiaDeCartas(copiaDeCartasNoBaralho);
        }

        public void AtualizarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            var copiaDeCartasNoBaralhoAtualizar = ObterPorIdCopiaDeCartas(copiaDeCartasNoBaralho.Id);
            copiaDeCartasNoBaralhoAtualizar.QuantidadeCopiasDaCartaNoBaralho = copiaDeCartasNoBaralho.QuantidadeCopiasDaCartaNoBaralho;
            _baralhoRepository.AtualizarCopiaDeCartas(copiaDeCartasNoBaralhoAtualizar);
        }

        public void ExcluirCopiaDeCartas(int idCopiaDeCartasNoBaralho)
        {
            _baralhoRepository.ExcluirCopiaDeCartas(idCopiaDeCartasNoBaralho);
        }

        public CopiaDeCartasNoBaralho ObterPorIdCopiaDeCartas(int idCopiaDeCartasNoBaralho)
        {
            return _baralhoRepository.ObterPorIdCopiaDeCartas(idCopiaDeCartasNoBaralho);
        }

        public List<CopiaDeCartasNoBaralho> ObterTodosCopiaDeCartas(CopiaDeCartasNoBaralhoFiltro filtro)
        {
            var copiaDeCartas = _baralhoRepository.ObterTodosCopiaDeCartas(filtro);

            foreach (var copia in copiaDeCartas)
            {
                copia.Carta = _cartaServico.ObterPorId(copia.IdCarta);
                copia.NomeCarta = copia.Carta.NomeCarta;
            }

            return copiaDeCartas;
        }
    }
}