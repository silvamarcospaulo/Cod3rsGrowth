using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using FluentValidation;
using FluentValidation.Results;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class ServicoBaralho : IServicoBaralho
    {
        private IBaralhoRepository _IBaralhoRepository;
        private IValidator<Baralho> _validadorBaralho;

        public ServicoBaralho(IBaralhoRepository baralhoRepository, IValidator<Baralho> validadorBaralho)
        {
            _IBaralhoRepository = baralhoRepository;
            _validadorBaralho = validadorBaralho;
        }
        private void Inserir(Baralho baralho)
        {
            _IBaralhoRepository.Inserir(baralho);
        }
        private int GerarIdBaralho()
        {
            int valorUm = 1;
            return _IBaralhoRepository.ObterTodos().Any() ? _IBaralhoRepository.ObterTodos().Max(baralho => baralho.IdBaralho) + valorUm : valorUm;
        }
        private decimal SomarPrecoDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            return baralho.Sum(carta => carta.Carta.PrecoCarta *
            carta.QuantidadeCopiasDaCartaNoBaralho);
        }
        private int SomarQuantidadeDeCartasDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            return baralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho);
        }
        private int SomarCustoDeManaConvertidoDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            return Convert.ToInt32(baralho.Sum(cartas => cartas.Carta.CustoDeManaConvertidoCarta)
                /SomarQuantidadeDeCartasDoBaralho(baralho));
        }
        private List<CoresEnum> ConferirCoresDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            return baralho.SelectMany(carta => carta.Carta.CorCarta).Distinct().ToList();
        }

        private DateTime GerarDataDeCriacaoBaralho()
        {
            DateTime dataAtual = DateTime.Now;
            return new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return _IBaralhoRepository.ObterPorId(idBaralho);
        }
        public List<Baralho> ObterTodos()
        {
            return _IBaralhoRepository.ObterTodos();
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