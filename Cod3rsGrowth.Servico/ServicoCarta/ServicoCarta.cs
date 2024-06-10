using System;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra.Repository.RepositoryCarta;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class ServicoCarta : IServicoCarta
    {
        private ICartaRepository _ICartaRepository;
        private ValidadorCarta _validadorCarta;
        private const decimal precoCartaCommon = 0.5m;
        private const decimal precoCartaUncommon = 2.5m;
        private const decimal precoCartaRare = 5m;
        private const decimal precoCartaMythic = 7.5m;

        public ServicoCarta(ICartaRepository cartaRepository, ValidadorCarta validadorCarta)
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
            return _ICartaRepository.ObterTodos().Any() ? _ICartaRepository.ObterTodos().Max(carta => carta.IdCarta) + 1 : 1;
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

        public void CriarCarta(Carta carta)
        {
            carta.IdCarta = GerarIdCarta();
            carta.PrecoCarta = GerarPrecoCarta(carta.RaridadeCarta);

            var validador = _validadorCarta.Validate(carta);

            if (validador.IsValid)
            {
                _ICartaRepository.Inserir(carta);
            }
            else
            {
                var erro = string.Join(Environment.NewLine, validador.Errors.Select(e=> e.ErrorMessage));
                throw new Exception(erro);
            }
        }
    }
}