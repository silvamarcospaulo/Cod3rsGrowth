using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra.Repository;
using FluentValidation;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class CartaServico : ICartaRepository
    {
        private readonly ICartaRepository _ICartaRepository;
        private readonly CorCartaServico _corCartaServico;
        private readonly IValidator<Carta> _validadorCarta;
        private const decimal precoCartaCommon = 0.5m;
        private const decimal precoCartaUncommon = 2.5m;
        private const decimal precoCartaRare = 5m;
        private const decimal precoCartaMythic = 7.5m;

        public CartaServico(ICartaRepository cartaRepository, CorCartaServico corCartaServico,
            IValidator<Carta> validadorCarta)
        {
            _ICartaRepository = cartaRepository;
            _corCartaServico = corCartaServico;
            _validadorCarta = validadorCarta;
        }

        private static decimal GerarPrecoCarta(RaridadeEnum raridadeDaCarta)
        {
            decimal valorCarta = 0;

            switch (raridadeDaCarta)
            {
                case RaridadeEnum.Common:
                    valorCarta = precoCartaCommon;
                    break;
                case RaridadeEnum.Uncommon:
                    valorCarta = precoCartaUncommon;
                    break;
                case RaridadeEnum.Rare:
                    valorCarta = precoCartaRare;
                    break;
                case RaridadeEnum.Mythic:
                    valorCarta = precoCartaMythic;
                    break;
            }
            return valorCarta;
        }

        public void Criar(Carta carta)
        {
            carta.PrecoCarta = GerarPrecoCarta(carta.RaridadeCarta);

            try
            {
                _validadorCarta.ValidateAndThrow(carta);
                _ICartaRepository.Criar(carta);

                foreach (var cor in carta.CorCarta)
                {
                    CorCarta _corDaCarta = new CorCarta()
                    {
                        IdCarta = carta.IdCarta,
                        Cor = cor.Cor
                    };
                    _corCartaServico.Criar(_corDaCarta);
                }
            }
            catch (ValidationException e)
            {
                var mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public void Atualizar(Carta carta)
        {
            var cartaAtualizada = ObterPorId(carta.IdCarta);
            cartaAtualizada.RaridadeCarta = carta.RaridadeCarta;
            cartaAtualizada.PrecoCarta = GerarPrecoCarta(cartaAtualizada.RaridadeCarta);

            try
            {
                _validadorCarta.ValidateAndThrow(cartaAtualizada);
                _ICartaRepository.Atualizar(cartaAtualizada);
            }
            catch (ValidationException e)
            {
                var mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public Carta ObterPorId(int idCarta)
        {
            var carta = _ICartaRepository.ObterPorId(idCarta);
            var filtro = new CorCartaFiltro() { idCarta = idCarta };
            carta.CorCarta.AddRange(_corCartaServico.ObterTodos(filtro));
            return carta;
        }

        public List<Carta> ObterTodos(CartaFiltro? filtro)
        {
            var todasAsCartas = new List<Carta>();
            todasAsCartas.AddRange(_ICartaRepository.ObterTodos(filtro));
            todasAsCartas.ForEach(carta => carta.CorCarta =
                _corCartaServico.ObterTodos(new CorCartaFiltro() { idCarta = carta.IdCarta }));
            return todasAsCartas;
        }
    }
}