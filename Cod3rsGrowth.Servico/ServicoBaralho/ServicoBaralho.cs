using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class ServicoBaralho : IServicoBaralho
    {
        private IBaralhoRepository _IBaralhoRepository;
        private ValidadorBaralho _validadorBaralho;

        public ServicoBaralho(IBaralhoRepository baralhoRepository, ValidadorBaralho validadorBaralho)
        {
            _IBaralhoRepository = baralhoRepository;
            _validadorBaralho = validadorBaralho;
        }
        private void Inserir(Baralho baralho)
        {
            _IBaralhoRepository.Inserir(baralho);
        }
        public Baralho ObterPorId(int idBaralho)
        {
            return _IBaralhoRepository.ObterPorId(idBaralho);
        }
        public List<Baralho> ObterTodos()
        {
            return _IBaralhoRepository.ObterTodos();
        }
        private int GerarIdBaralho()
        {
            return _IBaralhoRepository.ObterTodos().Any() ? _IBaralhoRepository.ObterTodos().Max(baralho => baralho.IdBaralho) + 1 : 1;
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

        public void CriarBaralho(Baralho baralho)
        {
            baralho.IdBaralho = GerarIdBaralho();
            baralho.QuantidadeDeCartasNoBaralho = SomarQuantidadeDeCartasDoBaralho(baralho.CartasDoBaralho);
            baralho.PrecoDoBaralho = SomarPrecoDoBaralho(baralho.CartasDoBaralho);
            baralho.CustoDeManaConvertidoDoBaralho = SomarCustoDeManaConvertidoDoBaralho(baralho.CartasDoBaralho);
            baralho.CorBaralho = ConferirCoresDoBaralho(baralho.CartasDoBaralho);

            var validador = _validadorBaralho.Validate(baralho);

            if (validador.IsValid)
            {
                _IBaralhoRepository.Inserir(baralho);
            }
            else
            {
                var erro = string.Join(Environment.NewLine, validador.Errors.Select(e => e.ErrorMessage));
                throw new Exception(erro);
            }
        }
    }
}