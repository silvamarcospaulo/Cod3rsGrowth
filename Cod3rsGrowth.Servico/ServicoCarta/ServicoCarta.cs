using System;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra.Repository.RepositoryCarta;
using Cod3rsGrowth.Servico.ServicoBaralho;
using FluentValidation;
using FluentValidation.Results;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class ServicoCarta : IServicoCarta
    {
        private ICartaRepository _ICartaRepository;
        private IValidator<Carta> _validadorCarta;
        private const decimal precoCartaCommon = 0.5m;
        private const decimal precoCartaUncommon = 2.5m;
        private const decimal precoCartaRare = 5m;
        private const decimal precoCartaMythic = 7.5m;

        public ServicoCarta(ICartaRepository cartaRepository, IValidator<Carta> validadorCarta)
        {
            _ICartaRepository = cartaRepository;
            _validadorCarta = validadorCarta;
        }
        private void Inserir(Carta carta)
        {
            _ICartaRepository.Inserir(carta);
        }

        public Carta ObterPorId(int idCarta)
        {
            return _ICartaRepository.ObterPorId(idCarta);
        }

        public List<Carta> ObterTodos()
        {
            return _ICartaRepository.ObterTodos();
        }

        private int GerarIdCarta()
        {
            int valorUm = 1;
            return _ICartaRepository.ObterTodos().Any() ? _ICartaRepository.ObterTodos().Max(carta => carta.IdCarta) + valorUm : valorUm;
        }

        private decimal GerarPrecoCarta(RaridadeEnum raridadeDaCarta)
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

        public ValidationResult CriarCarta(Carta carta)
        {
            carta.IdCarta = GerarIdCarta();
            carta.PrecoCarta = GerarPrecoCarta(carta.RaridadeCarta);

            try
            {
                _validadorCarta.ValidateAndThrow(carta);
                Inserir(carta);
                return new ValidationResult();
            }
            catch (ValidationException e)
            {
                return new ValidationResult(e.Errors);
            }
        }
    }
}