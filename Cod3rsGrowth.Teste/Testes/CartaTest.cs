using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using Microsoft.Extensions.DependencyInjection;
using Cod3rsGrowth.Servico.ServicoCarta;

namespace Cod3rsGrowth.Teste.Testes
{
    public class CartaTest : TesteBase
    {
        private readonly IServicoCarta ObterServico;

        public CartaTest()
        {
            ObterServico = ServiceProvider.GetService<IServicoCarta>() ?? throw new Exception("Erro ao obter servico");
            IniciarListaMock();
        }

        public void IniciarListaMock()
        {
            List<Carta> listaCartasMock = new List<Carta>()
            {
                new Carta()
                {
                    IdCarta = 1,
                    NomeCarta = "Ilha",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                }
            };

            if (ObterServico.ObterTodos().Count() < 1) listaCartasMock.ForEach(carta => ObterServico.Inserir(carta));
        }

        [Fact]
        public void verifica_se_a_lista_nao_esta_vazia()
        {
            var cartas = ObterServico.ObterTodos();

            Assert.NotEmpty(cartas);
        }

        [Fact]
        public void ao_ObterTodos_deve_retornar_uma_lista_com_uma_carta()
        {
            var quantidadeDeCartas = ObterServico.ObterTodos().Count();

            Assert.Equal(1, quantidadeDeCartas);
        }

        [Fact]
        public void ao_ObterTodos_compara_se_os_primeiros_elementos_sao_iguais()
        {
            List<Carta> listaDeCartas = new()
            {
                new Carta()
                {
                    IdCarta = 1,
                    NomeCarta = "Ilha",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                }
            };

            var cartas = ObterServico.ObterTodos();

            Assert.Equal(cartas.First().IdCarta, listaDeCartas.First().IdCarta);
            Assert.Equal(cartas.First().NomeCarta, listaDeCartas.First().NomeCarta);
            Assert.Equal(cartas.First().CustoDeManaConvertidoCarta, listaDeCartas.First().CustoDeManaConvertidoCarta);
            Assert.Equal(cartas.First().TipoDeCarta, listaDeCartas.First().TipoDeCarta);
            Assert.Equal(cartas.First().RaridadeCarta, listaDeCartas.First().RaridadeCarta);
            Assert.Equal(cartas.First().PrecoCarta, listaDeCartas.First().PrecoCarta);
            Assert.Equal(cartas.First().CorCarta, listaDeCartas.First().CorCarta);
        }
    }
}