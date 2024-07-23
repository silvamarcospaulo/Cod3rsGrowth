using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Teste.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste.Testes
{
    public class CartaTest : TesteBase
    {
        private readonly CartaServico servicoCarta;

        private List<Carta> tabelaCarta = SingletonTabelasTeste.InstanciaCarta;

        public CartaTest()
        {
            servicoCarta = ServiceProvider.GetService<CartaServico>() ?? throw new Exception("Erro ao obter servico Carta");

            tabelaCarta.Clear();

            IniciarListaMock();
        }

        private void IniciarListaMock()
        {
            var listaCartasMock = new List<Carta>()
            {
                new Carta()
                {
                    Id = 1,
                    NomeCarta = "Ilha",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = "Basic Land",
                    RaridadeCarta = RaridadeEnum.Comum,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = ""
                },
                new Carta()
                {
                    Id = 2,
                    NomeCarta = "Pantano",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = "Basic Land",
                    RaridadeCarta = RaridadeEnum.Comum,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = ""
                },
                new Carta()
                {
                    Id = 3,
                    NomeCarta = "Floresta",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = "Basic Land",
                    RaridadeCarta = RaridadeEnum.Comum,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = ""
                },
                new Carta()
                {
                    Id = 4,
                    NomeCarta = "Planice",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = "Basic Land",
                    RaridadeCarta = RaridadeEnum.Comum,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = ""
                },
                new Carta()
                {
                    Id = 5,
                    NomeCarta = "Montanha",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = "Basic Land",
                    RaridadeCarta = RaridadeEnum.Comum,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = ""
                },
                new Carta()
                {
                    Id = 6,
                    NomeCarta = "Niv-Mizzet, Parum",
                    CustoDeManaConvertidoCarta = 6,
                    TipoDeCarta = "Creature",
                    RaridadeCarta = RaridadeEnum.Raro,
                    PrecoCarta = Convert.ToDecimal(5),
                    CorCarta = "Azul, Vermelho"
                },
                new Carta()
                {
                    Id = 7,
                    NomeCarta = "Ghalta, Fome Primordial",
                    CustoDeManaConvertidoCarta = 12,
                    TipoDeCarta = "Creature",
                    RaridadeCarta = RaridadeEnum.Raro,
                    PrecoCarta = Convert.ToDecimal(5),
                    CorCarta = "Verde"
                }
            };

            listaCartasMock.ForEach(carta => servicoCarta.Criar(carta));
        }

        [Fact]
        public void ao_ObterTodos_verifica_se_a_lista_nao_esta_vazia()
        {
            IniciarListaMock();

            var cartas = servicoCarta.ObterTodos(new CartaFiltro());

            Assert.NotEmpty(cartas);
        }

        [Fact]
        public void ao_ObterTodos_deve_retornar_uma_lista_com_sete_cartas()
        {
            const int quantidadeDeCartasEsperadas = 7;

            var quantidadeDeCartasMock = servicoCarta.ObterTodos(new CartaFiltro()).Count();

            Assert.Equal(quantidadeDeCartasEsperadas, quantidadeDeCartasMock);
        }

        [Fact]
        public void ao_ObterTodos_com_filtro_raridade_carta_rara_deve_retornar_uma_lista_com_duas_cartas()
        {
            const int quantidadeDeCartasEsperadas = 2;
            const RaridadeEnum raridadeFiltro = RaridadeEnum.Raro;

            var quantidadeDeCartasMock = servicoCarta.ObterTodos(new CartaFiltro() { RaridadeCarta = new List<RaridadeEnum>() { raridadeFiltro } }).Count();

            Assert.Equal(quantidadeDeCartasEsperadas, quantidadeDeCartasMock);
        }

        [Fact]
        public void ao_ObterTodos_com_filtro_tipo_de_carta_terreno_deve_retornar_uma_lista_com_cinco_cartas()
        {
            const int quantidadeDeCartasEsperadas = 5;
            const string tipoDeCartaFiltro = "Basic Land";

            var quantidadeDeCartasMock = servicoCarta.ObterTodos(new CartaFiltro() { TipoDeCarta = new List<string>() { tipoDeCartaFiltro } }).Count();

            Assert.Equal(quantidadeDeCartasEsperadas, quantidadeDeCartasMock);
        }

        [Fact]
        public void ao_ObterPorId_com_id_seis_retornar_baralho_niv_mizzet_parum()
        {
            var cartaTeste = new Carta()
            {
                Id = 6,
                NomeCarta = "Niv-Mizzet, Parum",
                CustoDeManaConvertidoCarta = 6,
                TipoDeCarta = "Creature",
                RaridadeCarta = RaridadeEnum.Raro,
                PrecoCarta = Convert.ToDecimal(5),
                CorCarta = "Azul, Vermelho"
            };

            var cartaMock = servicoCarta.ObterPorId(cartaTeste.Id);

            Assert.Equivalent(cartaTeste, cartaMock);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(8)]
        public void ao_ObterPorId_com_id_invalido_ou_inexistente_deve_retornar_Exception(int idCartaTeste)
        {
            Assert.Throws<Exception>(() => servicoCarta.ObterPorId(idCartaTeste));
        }

        [Fact]
        public void ao_Criar_com_nome_vazio_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "Nome da carta nao pode ser vazio";

            var cartaTeste = new Carta()
            {
                Id = 8,
                NomeCarta = "",
                CustoDeManaConvertidoCarta = 2,
                TipoDeCarta = "Artifact",
                RaridadeCarta = RaridadeEnum.Comum,
                PrecoCarta = 0.5m,
                CorCarta = ""
            };

            var resultado = Assert.Throws<Exception>(() => servicoCarta.Criar(cartaTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_custo_de_mana_convertido_negativo_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "Custo de Mana Convertido da Carta deve ser igual ou maior que 0";

            var cartaTeste = new Carta()
            {
                Id = 8,
                NomeCarta = "Sol Ring",
                CustoDeManaConvertidoCarta = -1,
                TipoDeCarta = "Artifact",
                RaridadeCarta = RaridadeEnum.Comum,
                PrecoCarta = 0.5m,
                CorCarta = ""
            };

            var resultado = Assert.Throws<Exception>(() => servicoCarta.Criar(cartaTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_dados_validos_deve_adicionar_uma_nova_carta()
        {
            var cartaTeste = new Carta()
            {
                Id = 8,
                NomeCarta = "Sol Ring",
                CustoDeManaConvertidoCarta = 2,
                TipoDeCarta = "Artifact",
                RaridadeCarta = RaridadeEnum.Comum,
                PrecoCarta = 0.5m,
                CorCarta = ""
            };

            servicoCarta.Criar(cartaTeste);

            Assert.Equivalent(cartaTeste, servicoCarta.ObterPorId(cartaTeste.Id));
        }
    }
}