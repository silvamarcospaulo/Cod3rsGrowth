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
            return _ICartaRepository.ObterTodos().Count + 1;
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

        private List<CoresEnum> AdicionarCoresDaCarta(string cor)
        {
            List<CoresEnum> cores = new();

            foreach (char c in cor)
            {
                switch (c)
                {
                    case 'W':
                        cores.Add(CoresEnum.Branco);
                        break;
                    case 'B':
                        cores.Add(CoresEnum.Preto);
                        break;
                    case 'G':
                        cores.Add(CoresEnum.Verde);
                        break;
                    case 'R':
                        cores.Add(CoresEnum.Vermelho);
                        break;
                    case 'U':
                        cores.Add(CoresEnum.Azul);
                        break;
                    default:
                        break;
                }
            }
            return cores.Distinct().ToList();
        }

        public void CriarCarta(string nomeCarta, int custoDeManaConvertidoCarta,
            TipoDeCartaEnum tipoDeCarta, RaridadeEnum raridadeCarta, List<CoresEnum> corCarta)
        {
            Carta carta = new Carta()
            {
                IdCarta = GerarIdCarta(),
                NomeCarta = nomeCarta,
                CustoDeManaConvertidoCarta = custoDeManaConvertidoCarta,
                TipoDeCarta = tipoDeCarta,
                RaridadeCarta = raridadeCarta,
                PrecoCarta = GerarPrecoCarta(raridadeCarta),
                CorCarta = corCarta
            };

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