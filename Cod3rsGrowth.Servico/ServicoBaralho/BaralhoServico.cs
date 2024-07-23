using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoCarta;
using FluentValidation;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class BaralhoServico : IBaralhoRepository
    {
        private readonly IBaralhoRepository _IBaralhoRepository;
        private readonly CartaServico _cartaServico;
        private readonly IValidator<Baralho> _validadorBaralho;
        private const int VALOR_NULO = 0;

        public BaralhoServico(IBaralhoRepository baralhoRepository, CartaServico cartaServico,
            IValidator<Baralho> validadorBaralho)
        {
            _IBaralhoRepository = baralhoRepository;
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

        public int Criar(Baralho baralho)
        {
            var baralhoCriar = new Baralho();

            try
            {
                baralhoCriar.IdJogador = baralho.IdJogador;
                baralhoCriar.NomeBaralho = baralho.NomeBaralho;
                baralhoCriar.FormatoDeJogoBaralho = baralho.FormatoDeJogoBaralho;
                baralhoCriar.CartasDoBaralho = baralho.CartasDoBaralho;
                baralhoCriar.PrecoDoBaralho = SomarPrecoDoBaralho(baralho.CartasDoBaralho);
                baralhoCriar.QuantidadeDeCartasNoBaralho = SomarQuantidadeDeCartasDoBaralho(baralho.CartasDoBaralho);
                baralhoCriar.CorBaralho = ConferirCoresDoBaralho(baralho.CartasDoBaralho);
                baralhoCriar.CustoDeManaConvertidoDoBaralho = SomarCustoDeManaConvertidoDoBaralho(baralho.CartasDoBaralho);
                var dataDeCriacao = GerarDataDeCriacaoBaralho();
                baralhoCriar.DataDeCriacaoBaralho = dataDeCriacao;

                _validadorBaralho.ValidateAndThrow(baralhoCriar);
                var idBaralhoCriado = _IBaralhoRepository.Criar(baralhoCriar);

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

                baralhoExcluir.CartasDoBaralho.ForEach(copia => ExcluirCopiaDeCartas(copia.Id));

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
            var baralho = _IBaralhoRepository.ObterPorId(idBaralho);

            baralho.CartasDoBaralho = ObterTodosCopiaDeCartas(new CopiaDeCartasNoBaralhoFiltro() { IdBaralho = baralho.Id });

            return baralho;
        }

        public List<Baralho> ObterTodos(BaralhoFiltro? filtro)
        {
            var baralhos = _IBaralhoRepository.ObterTodos(filtro);

            return baralhos;
        }

        public void CriarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            _IBaralhoRepository.CriarCopiaDeCartas(copiaDeCartasNoBaralho);
        }

        public void AtualizarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            var copiaDeCartasNoBaralhoAtualizar = ObterPorIdCopiaDeCartas(copiaDeCartasNoBaralho.Id);
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
            var copiaDeCartas = _IBaralhoRepository.ObterTodosCopiaDeCartas(filtro);

            foreach (var copia in copiaDeCartas)
            {
                copia.Carta = _cartaServico.ObterPorId(copia.IdCarta);
                copia.NomeCarta = copia.Carta.NomeCarta;
            }

            return copiaDeCartas;
        }
    }
}