using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using FluentValidation;
using FluentValidation.Results;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class ServicoBaralho : IBaralhoRepository
    {
        private readonly IBaralhoRepository _IBaralhoRepository;
        private readonly IValidator<Baralho> _validadorBaralho;

        public ServicoBaralho(IBaralhoRepository baralhoRepository, IValidator<Baralho> validadorBaralho)
        {
            _IBaralhoRepository = baralhoRepository;
            _validadorBaralho = validadorBaralho;
        }
        
        private int GerarIdBaralho()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var baralhos = _IBaralhoRepository.ObterTodos();
            var ultimoId = baralhos.Any() ? baralhos.Max(baralho => baralho.IdBaralho) : ValorInicial - Incremento;

            return ultimoId + Incremento;
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

        private static List<CoresEnum> ConferirCoresDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            try
            {
                return baralho.SelectMany(carta => carta.Carta.CorCarta).Distinct().ToList();
            }
            catch (Exception e)
            {
                return new List<CoresEnum>();
            }
        }

        private static DateTime GerarDataDeCriacaoBaralho()
        {
            DateTime dataAtual = DateTime.Now;
            return new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        }

        public void Inserir(Baralho baralho)
        {
            _IBaralhoRepository.Inserir(baralho);
        }

        public void Excluir(Baralho baralho)
        {
        }

        public List<Baralho> ObterTodos()
        {
            return _IBaralhoRepository.ObterTodos();
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return _IBaralhoRepository.ObterPorId(idBaralho);
        }

        public ValidationResult CriarBaralho(Baralho baralho)
        {
            baralho.IdBaralho = GerarIdBaralho();
            baralho.QuantidadeDeCartasNoBaralho = SomarQuantidadeDeCartasDoBaralho(baralho.CartasDoBaralho);
            baralho.DataDeCriacaoBaralho = GerarDataDeCriacaoBaralho();
            baralho.PrecoDoBaralho = SomarPrecoDoBaralho(baralho.CartasDoBaralho);
            baralho.CustoDeManaConvertidoDoBaralho = SomarCustoDeManaConvertidoDoBaralho(baralho.CartasDoBaralho);
            baralho.CorBaralho = ConferirCoresDoBaralho(baralho.CartasDoBaralho);

            try
            {
                _validadorBaralho.ValidateAndThrow(baralho);
                Inserir(baralho);
                return new ValidationResult();
            }
            catch (ValidationException e)
            {
                return new ValidationResult(e.Errors);
            }
        }
    }
}