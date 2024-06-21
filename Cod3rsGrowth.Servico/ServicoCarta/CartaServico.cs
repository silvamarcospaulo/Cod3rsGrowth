﻿using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using FluentValidation;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class CartaServico : ICartaRepository
    {
        private readonly ICartaRepository _ICartaRepository;
        private readonly IValidator<Carta> _validadorCarta;
        private const decimal precoCartaCommon = 0.5m;
        private const decimal precoCartaUncommon = 2.5m;
        private const decimal precoCartaRare = 5m;
        private const decimal precoCartaMythic = 7.5m;

        public CartaServico(ICartaRepository cartaRepository, IValidator<Carta> validadorCarta)
        {
            _ICartaRepository = cartaRepository;
            _validadorCarta = validadorCarta;
        }

        private int GerarIdCarta()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var cartas = _ICartaRepository.ObterTodos(null);
            var ultimoId = cartas.Any() ? cartas.Max(carta => carta.IdCarta) : ValorInicial - Incremento;

            return ultimoId + Incremento;
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
            carta.IdCarta = GerarIdCarta();
            carta.PrecoCarta = GerarPrecoCarta(carta.RaridadeCarta);

            try
            {
                _validadorCarta.ValidateAndThrow(carta);
                _ICartaRepository.Criar(carta);
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
            return _ICartaRepository.ObterPorId(idCarta);
        }
        public List<Carta> ObterTodos(CartaFiltro? filtro)
        {
            return _ICartaRepository.ObterTodos(null);
        }
    }
}