﻿using Cod3rsGrowth.Dominio.Filtros;
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

        public int Criar(Carta carta)
        {
            carta.PrecoCarta = GerarPrecoCarta(carta.RaridadeCarta);

            try
            {
                _validadorCarta.ValidateAndThrow(carta);
                var cartaCriada = _ICartaRepository.Criar(carta);

                carta.CorCarta.ForEach(cor => _ICartaRepository.CriarCorCarta(
                    new CorCarta() { IdCarta = cartaCriada, Cor = cor }));

                return cartaCriada;
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
            carta.CorCarta.AddRange(_ICartaRepository.ObterTodosCorCarta(filtro).Select(cor => cor.Cor));
            return carta;
        }

        public List<Carta> ObterTodos(CartaFiltro? filtro)
        {
            var todasAsCartas = _ICartaRepository.ObterTodos(filtro);
            todasAsCartas?.ForEach(carta => carta.CorCarta.AddRange(_ICartaRepository.ObterTodosCorCarta(
                new CorCartaFiltro() { idCarta = carta.IdCarta }).Select(cor => cor.Cor)));
            return todasAsCartas;
        }

        public void CriarCorCarta(CorCarta corCarta)
        {
            _ICartaRepository.CriarCorCarta(corCarta);
        }

        public List<CorCarta> ObterTodosCorCarta(CorCartaFiltro? filtro)
        {
            if (filtro?.idCarta != null) return _ICartaRepository.ObterTodosCorCarta(filtro);
            return _ICartaRepository.ObterTodosCorCarta(null);
        }
    }
}