using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Servico.ServicoCarta;
using FluentValidation;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class BaralhoServico : IBaralhoRepository
    {
        private readonly IBaralhoRepository _IBaralhoRepository;
        private readonly CartaServico _cartaServico;
        private readonly IValidator<Baralho> _validadorBaralho;

        public BaralhoServico(IBaralhoRepository baralhoRepository, CartaServico cartaServico,
            IValidator<Baralho> validadorBaralho)
        {
            _IBaralhoRepository = baralhoRepository;
            _cartaServico = cartaServico;
            _validadorBaralho = validadorBaralho;
        }

        private static decimal SomarPrecoDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            try
            {
                return baralho.Sum(carta => carta.Carta.PrecoCarta *
                    carta.QuantidadeCopiasDaCartaNoBaralho);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        private static int SomarQuantidadeDeCartasDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            try
            {
                return baralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        private static string ConferirCoresDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            var cores = baralho
                .SelectMany(carta => carta.Carta.CorCarta.Trim('{', '}').Split(',').Select(cor => cor.Trim()))
                .Where(caractere => !string.IsNullOrWhiteSpace(caractere)).Distinct();

            return "{" + string.Join(", ", cores) + "}";
        }

        private static int SomarCustoDeManaConvertidoDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            try
            {
                return Convert.ToInt32(baralho.Sum(cartas => cartas.Carta.CustoDeManaConvertidoCarta)
                / SomarQuantidadeDeCartasDoBaralho(baralho));
            }
            catch(Exception e)
            {
                return 0;
            }
        }

        private static DateTime GerarDataDeCriacaoBaralho()
        {
            DateTime dataAtual = DateTime.Now;
            return new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        }

        public int Criar(Baralho baralho)
        {
            baralho.QuantidadeDeCartasNoBaralho = SomarQuantidadeDeCartasDoBaralho(baralho.CartasDoBaralho);
            baralho.DataDeCriacaoBaralho = GerarDataDeCriacaoBaralho();
            baralho.PrecoDoBaralho = SomarPrecoDoBaralho(baralho.CartasDoBaralho);
            baralho.CustoDeManaConvertidoDoBaralho = SomarCustoDeManaConvertidoDoBaralho(baralho.CartasDoBaralho);
            baralho.CorBaralho = ConferirCoresDoBaralho(baralho.CartasDoBaralho);

            try
            {
                _validadorBaralho.ValidateAndThrow(baralho);
                var idBaralhoCriado = _IBaralhoRepository.Criar(baralho);

                return idBaralhoCriado;
            }
            catch (ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public void Atualizar(Baralho baralho)
        {
            var baralhoAtualizado = ObterPorId(baralho.IdBaralho);

            baralhoAtualizado.NomeBaralho = baralho.NomeBaralho;
            baralhoAtualizado.FormatoDeJogoBaralho = baralho.FormatoDeJogoBaralho;
            baralhoAtualizado.CartasDoBaralho = baralho.CartasDoBaralho;
            baralhoAtualizado.QuantidadeDeCartasNoBaralho = SomarQuantidadeDeCartasDoBaralho(baralhoAtualizado.CartasDoBaralho);
            baralhoAtualizado.DataDeCriacaoBaralho = GerarDataDeCriacaoBaralho();
            baralhoAtualizado.PrecoDoBaralho = SomarPrecoDoBaralho(baralhoAtualizado.CartasDoBaralho);
            baralhoAtualizado.CustoDeManaConvertidoDoBaralho = SomarCustoDeManaConvertidoDoBaralho(baralhoAtualizado.CartasDoBaralho);
            baralhoAtualizado.CorBaralho = baralho.CorBaralho;

            try
            {
                _validadorBaralho.ValidateAndThrow(baralhoAtualizado);
                _IBaralhoRepository.Atualizar(baralhoAtualizado);
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
                var baralhoExcluir = ObterPorId(idBaralho);
                _IBaralhoRepository.Excluir(idBaralho);
            }
            catch (ValidationException e)
            {
                var mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return _IBaralhoRepository.ObterPorId(idBaralho);
        }

        public List<Baralho> ObterTodos(BaralhoFiltro? filtro)
        {
            return _IBaralhoRepository.ObterTodos(filtro);
        }

        public void CriarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            _IBaralhoRepository.CriarCopiaDeCartas(copiaDeCartasNoBaralho);
        }

        public void AtualizarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            var copiaDeCartasNoBaralhoAtualizar = ObterPorIdCopiaDeCartas(copiaDeCartasNoBaralho.IdCopiaDeCartasNoBaralho);
            copiaDeCartasNoBaralhoAtualizar.QuantidadeCopiasDaCartaNoBaralho = copiaDeCartasNoBaralho.QuantidadeCopiasDaCartaNoBaralho;
            _IBaralhoRepository.AtualizarCopiaDeCartas(copiaDeCartasNoBaralhoAtualizar);
        }

        public void ExcluirCopiaDeCartas(int idCopiaDeCartasNoBaralho)
        {
            _IBaralhoRepository.ExcluirCopiaDeCartas(idCopiaDeCartasNoBaralho);
        }

        public CopiaDeCartasNoBaralho ObterPorIdCopiaDeCartas(int idCopiaDeCartasNoBaralho)
        {
            return _IBaralhoRepository.ObterPorIdCopiaDeCartas(idCopiaDeCartasNoBaralho);
        }

        public List<CopiaDeCartasNoBaralho> ObterTodosCopiaDeCartas(CopiaDeCartasNoBaralhoFiltro filtro)
        {
            return _IBaralhoRepository.ObterTodosCopiaDeCartas(filtro);
        }
    }
}