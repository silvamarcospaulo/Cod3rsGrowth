using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using FluentValidation;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class CartaServico : ICartaRepository
    {
        private readonly ICartaRepository _ICartaRepository;
        private readonly IValidator<Carta> _validadorCarta;

        public CartaServico(ICartaRepository cartaRepository, IValidator<Carta> validadorCarta)
        {
            _ICartaRepository = cartaRepository;
            _validadorCarta = validadorCarta;
        }

        public int Criar(Carta carta)
        {
            try
            {
                _validadorCarta.ValidateAndThrow(carta);
                return _ICartaRepository.Criar(carta);
            }
            catch (ValidationException e)
            {
                var mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public void Atualizar(Carta carta)
        {
            var cartaAtualizada = ObterPorId(carta.Id);
            cartaAtualizada.RaridadeCarta = carta.RaridadeCarta;
            cartaAtualizada.PrecoCarta = carta.PrecoCarta;

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
            return carta;
        }

        public List<Carta> ObterTodos(CartaFiltro? filtro)
        {
            var todasAsCartas = _ICartaRepository.ObterTodos(filtro);

            return todasAsCartas;
        }
    }
}