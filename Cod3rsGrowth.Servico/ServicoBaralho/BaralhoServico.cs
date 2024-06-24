using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra;
using FluentValidation;
using System.Runtime.InteropServices;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class BaralhoServico : IBaralhoRepository
    {
        private readonly IBaralhoRepository _IBaralhoRepository;        
        private readonly IValidator<Baralho> _validadorBaralho;

        public BaralhoServico(IBaralhoRepository baralhoRepository, IValidator<Baralho> validadorBaralho)
        {
            _IBaralhoRepository = baralhoRepository;
            _validadorBaralho = validadorBaralho;
        }

        private static decimal SomarPrecoDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            try
            {
                return baralho.Sum(carta => carta.Carta.PrecoCarta *
                    carta.QuantidadeCopiasDaCartaNoBaralho);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        private static int SomarQuantidadeDeCartasDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            try
            {
                return baralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        private static int SomarCustoDeManaConvertidoDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            try
            {
                return Convert.ToInt32(baralho.Sum(cartas => cartas.Carta.CustoDeManaConvertidoCarta)
                / SomarQuantidadeDeCartasDoBaralho(baralho));
            }
            catch(Exception e)
            {
                return 0;
            }
        }

        private static List<CoresEnum> ConferirCoresDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            try
            {
                var cores = new List<CoresEnum>();

                foreach (var item in baralho)
                {
                    foreach (var i in item.Carta.CorCarta)
                    {
                        cores.Add(i.Cor);
                    }
                }
            }
            catch (Exception e)
            {
                return new List<CoresEnum>();
            }
        }

        private static DateTime GerarDataDeCriacaoBaralho()
        {
            DateTime dataAtual = DateTime.Now;
            return new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day);
        }

        public void Criar(Baralho baralho)
        {
            baralho.QuantidadeDeCartasNoBaralho = SomarQuantidadeDeCartasDoBaralho(baralho.CartasDoBaralho);
            baralho.DataDeCriacaoBaralho = GerarDataDeCriacaoBaralho();
            baralho.PrecoDoBaralho = SomarPrecoDoBaralho(baralho.CartasDoBaralho);
            baralho.CustoDeManaConvertidoDoBaralho = SomarCustoDeManaConvertidoDoBaralho(baralho.CartasDoBaralho);
            baralho.CorBaralho = ConferirCoresDoBaralho(baralho.CartasDoBaralho);

            try
            {
                _validadorBaralho.ValidateAndThrow(baralho);
                _IBaralhoRepository.Criar(baralho);

                foreach (var cor in baralho.CorBaralho)
                {
                    var corDoBaralho = new CorBaralho()
                    {
                        IdCorBaralho = baralho.IdBaralho,
                        Cor = cor
                    };

                    _IBaralhoRepository.CriarCorBaralho(corDoBaralho);
                }
            }
            catch (ValidationException e)
            {
                string mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public void Atualizar(Baralho baralho)
        {
            var baralhoAtualizado = ObterPorId(baralho.IdBaralho);

            baralhoAtualizado.NomeBaralho = baralho.NomeBaralho;
            baralhoAtualizado.FormatoDeJogoBaralho = baralho.FormatoDeJogoBaralho;
            baralhoAtualizado.CartasDoBaralho = baralho.CartasDoBaralho;
            baralhoAtualizado.QuantidadeDeCartasNoBaralho = SomarQuantidadeDeCartasDoBaralho(baralhoAtualizado.CartasDoBaralho);
            baralhoAtualizado.DataDeCriacaoBaralho = GerarDataDeCriacaoBaralho();
            baralhoAtualizado.PrecoDoBaralho = SomarPrecoDoBaralho(baralhoAtualizado.CartasDoBaralho);
            baralhoAtualizado.CustoDeManaConvertidoDoBaralho = SomarCustoDeManaConvertidoDoBaralho(baralhoAtualizado.CartasDoBaralho);
            baralhoAtualizado.CorBaralho = ConferirCoresDoBaralho(baralhoAtualizado.CartasDoBaralho);

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
                ObterPorId(idBaralho);
                _IBaralhoRepository.Excluir(idBaralho);
            }
            catch (ValidationException e)
            {
                var mensagemDeErro = string.Join(Environment.NewLine, e.Errors.Select(error => error.ErrorMessage));
                throw new Exception($"{mensagemDeErro}");
            }
        }

        public List<Baralho> ObterTodos(BaralhoFiltro? filtro)
        {
            return _IBaralhoRepository.ObterTodos(null);
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return _IBaralhoRepository.ObterPorId(idBaralho);
        }

        public void CriarCorBaralho(CorBaralho corBaralho)
        {
            _IBaralhoRepository.CriarCorBaralho(corBaralho);
        }

        public void ExcluirCorBaralho(int idCorBaralho)
        {
            _IBaralhoRepository.Excluir(idCorBaralho);
        }

        public CorBaralho ObterPorIdCorBaralho(int idCorBaralho)
        {
            return _IBaralhoRepository.ObterPorIdCorBaralho(idCorBaralho);
        }

        public List<CorBaralho> ObterTodosCorBaralho(CorBaralhoFiltro? filtro)
        {
            if (filtro?.idBaralho != null) return _IBaralhoRepository.ObterTodosCorBaralho(filtro);
            return _IBaralhoRepository.ObterTodosCorBaralho(filtro);
        }

        public void CriarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            _IBaralhoRepository.CriarCopiaDeCartas(copiaDeCartasNoBaralho);
        }

        public void AtualizarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            var copiaDeCartasNoBaralhoAtualizar = new CopiaDeCartasNoBaralho();
            copiaDeCartasNoBaralhoAtualizar = ObterPorIdCopiaDeCartas(copiaDeCartasNoBaralho.IdCopiaDeCartasNoBaralho);
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
            if (filtro?.IdBaralho != null) return _IBaralhoRepository.ObterTodosCopiaDeCartas(filtro);
            return _IBaralhoRepository.ObterTodosCopiaDeCartas(null);
        }
    }
}