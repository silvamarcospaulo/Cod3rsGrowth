using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Teste.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste.Testes
{
    public class JogadorTest : TesteBase
    {
        private readonly JogadorServico servicoJogador;
        private List<Jogador> tabelaJogador = SingletonTabelasTeste.InstanciaJogador;

        public JogadorTest()
        {
            servicoJogador = ServiceProvider.GetService<JogadorServico>() ?? throw new Exception("Erro ao obter servico Jogador");

            tabelaJogador.Clear();

            IniciarListaMock();
        }

        public void IniciarListaMock()
        {
            var listaJogadoresMock = new List<Jogador>()
            {
                new Jogador()
                {
                    NomeJogador = "Marcos",
                    SobrenomeJogador = "Silva",
                    UsuarioJogador = "marcos",
                    UsuarioConfirmacaoJogador = "marcos",
                    SenhaHashJogador = "Senha123",
                    SenhaHashConfirmacaoJogador = "Senha123",
                    Role = "Jogador",
                    DataNascimentoJogador = new DateTime(day: 8, month: 3, year: 1999),
                },
                new Jogador()
                {
                    NomeJogador = "Paulo",
                    SobrenomeJogador = "Silva",
                    UsuarioJogador = "pauloo",
                    UsuarioConfirmacaoJogador = "pauloo",
                    SenhaHashJogador = "Senha123",
                    SenhaHashConfirmacaoJogador = "Senha123",
                    Role = "Jogador",
                    DataNascimentoJogador = new DateTime(day: 9, month: 3, year: 1999),
                },
                new Jogador()
                {
                    NomeJogador = "Silva",
                    SobrenomeJogador = "Silva",
                    UsuarioJogador = "silvaa",
                    UsuarioConfirmacaoJogador = "silvaa",
                    SenhaHashJogador = "Senha123",
                    SenhaHashConfirmacaoJogador = "Senha123",
                    Role = "Jogador",
                    DataNascimentoJogador = new DateTime(day: 10, month: 3, year: 1999),
                }
            };

            listaJogadoresMock.ForEach(jogador => servicoJogador.Criar(jogador));
        }

        [Fact]
        public void ao_ObterTodos_verifica_se_a_lista_de_nao_esta_vazia()
        {
            Assert.IsType<List<Jogador>>(servicoJogador.ObterTodos(new JogadorFiltro()));
        }

        [Fact]
        public void ao_ObterTodos_deve_retornar_uma_lista_com_tres_jogadores()
        {
            const int quantidadeDeJogadoresEsperados = 3;

            var quantidadeDeJogadores = servicoJogador.ObterTodos(new JogadorFiltro()).Count();

            Assert.Equal(quantidadeDeJogadoresEsperados, quantidadeDeJogadores);
        }

        [Fact]
        public void ao_ObterTodos_com_filtro_conta_ativa_true_deve_retornar_uma_lista_com_zero_jogadores()
        {
            const int quantidadeDeJogadoresEsperados = 0;

            var quantidadeDeJogadores = servicoJogador.ObterTodos(new JogadorFiltro() { ContaAtivaJogador = true }).Count();

            Assert.Equal(quantidadeDeJogadoresEsperados, quantidadeDeJogadores);
        }

        [Fact]
        public void ao_ObterTodos_com_filtro_nome_marcos_deve_retornar_uma_lista_com_um_jogador()
        {
            const int quantidadeDeJogadoresEsperados = 1;
            const string nomeJogador = "Marcos";

            var quantidadeDeJogadores = servicoJogador.ObterTodos(new JogadorFiltro() { NomeJogador = nomeJogador }).Count();

            Assert.Equal(quantidadeDeJogadoresEsperados, quantidadeDeJogadores);
        }

        [Fact]
        public void ao_ObterPorId_um_retornar_jogador_Marcos()
        {
            var jogadorTeste = new Jogador()
            {
                Id = 1,
                NomeJogador = "Marcos",
                SobrenomeJogador = "Silva",
                UsuarioJogador = "marcos",
                UsuarioConfirmacaoJogador = "marcos",
                SenhaHashJogador = "Senha123",
                SenhaHashConfirmacaoJogador = "Senha123",
                Role = "Jogador",
                DataNascimentoJogador = new DateTime(day: 8, month: 3, year: 1999),
            };

            var jogadorMock = servicoJogador.ObterPorId(jogadorTeste.Id);

            Assert.Equivalent(jogadorTeste.NomeJogador, jogadorMock.NomeJogador);
            Assert.Equivalent(jogadorTeste.SobrenomeJogador, jogadorMock.SobrenomeJogador);
            Assert.Equivalent(jogadorTeste.UsuarioJogador, jogadorMock.UsuarioJogador);
            Assert.Equivalent(jogadorTeste.DataNascimentoJogador, jogadorMock.DataNascimentoJogador);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        public void ao_ObterPorId_invalido_ou_inexistente_deve_retornar_Exception(int idJogadorTeste)
        {
            Assert.Throws<Exception>(() => servicoJogador.ObterPorId(idJogadorTeste));
        }

        [Fact]
        public void ao_Criar_com_nome_vazio_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "Preencha seu nome no campo indicado.\n";

            var jogadorTeste = new Jogador()
            {
                Id = 4,
                NomeJogador = "",
                SobrenomeJogador = "Detofol",
                UsuarioJogador = "mpauloo",
                UsuarioConfirmacaoJogador = "mpauloo",
                SenhaHashJogador = "Senha123",
                SenhaHashConfirmacaoJogador = "Senha123",
                Role = "Jogador",
                DataNascimentoJogador = new DateTime(day: 29, month: 11, year: 2005),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = new List<Baralho>()
            };

            var resultado = Assert.Throws<Exception>(() => servicoJogador.Criar(jogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_data_de_nascimento_vazia_deve_retornar_Excepion()
        {
            const string mensagemDeErroEsperada = "Preencha sua data de nascimento no campo indicado.\n";

            var jogadorTeste = new Jogador()
            {
                Id = 4,
                NomeJogador = "Detofol",
                SobrenomeJogador = "Detofol",
                UsuarioJogador = "paulgoo",
                UsuarioConfirmacaoJogador = "paulgoo",
                SenhaHashJogador = "Senha123",
                SenhaHashConfirmacaoJogador = "Senha123",
                Role = "Jogador",
                DataNascimentoJogador = new DateTime(),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = new List<Baralho>()
            };

            var resultado = Assert.Throws<Exception>(() => servicoJogador.Criar(jogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_idade_menor_que_treze_anos_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "MTG Deckbuilder possui conte�do exclusivo para maiores de 13 anos.\n";

            var jogadorTeste = new Jogador()
            {
                Id = 4,
                NomeJogador = "Detofol",
                SobrenomeJogador = "Detofol",
                UsuarioJogador = "paulop",
                UsuarioConfirmacaoJogador = "paulop",
                SenhaHashJogador = "Senha123",
                SenhaHashConfirmacaoJogador = "Senha123",
                Role = "Jogador",
                DataNascimentoJogador = new DateTime(day: 1, month: 06, year: 2023),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = new List<Baralho>()
            };

            var resultado = Assert.Throws<Exception>(() => servicoJogador.Criar(jogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_dados_validos_deve_adicionar_um_novo_jogador()
        {
            var jogadorTeste = new Jogador()
            {
                Id = 4,
                NomeJogador = "Detofol",
                SobrenomeJogador = "Detofol",
                UsuarioJogador = "paulooo",
                UsuarioConfirmacaoJogador = "paulooo",
                SenhaHashJogador = "Senha123",
                SenhaHashConfirmacaoJogador = "Senha123",
                Role = "Jogador",
                DataNascimentoJogador = new DateTime(day: 29, month: 11, year: 2005),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = new List<Baralho>()
            };

            servicoJogador.Criar(jogadorTeste);

            Assert.Equal(jogadorTeste, servicoJogador.ObterPorId(jogadorTeste.Id));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void ao_Atualizar_com_dados_validos_deve_adicionar_um_novo_jogador(int idJogadorTeste)
        {
            var jogadorTeste = servicoJogador.ObterPorId(idJogadorTeste);
            jogadorTeste.SenhaHashJogador = "4e890854906f50e9ea4953ee9ec0468bc3f65ceee72876c850c3e5167c9220a6";
            jogadorTeste.SenhaHashConfirmacaoJogador = "4e890854906f50e9ea4953ee9ec0468bc3f65ceee72876c850c3e5167c9220a6";

            servicoJogador.Atualizar(jogadorTeste);

            Assert.Equivalent(jogadorTeste, servicoJogador.ObterPorId(idJogadorTeste));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(4)]
        public void ao_Atualizar_com_id_invalido_ou_inexistente_deve_retornar_Exception(int idJogadorTeste)
        {
            var mensagemDeErroEsperada = ($"Jogador {idJogadorTeste} Nao Encontrado");

            var jogadorTeste = new Jogador()
            {
                Id = idJogadorTeste
            };

            var resultado = Assert.Throws<Exception>(() => servicoJogador.Atualizar(jogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Atualizar_nao_deve_ser_alterar_nome_e_data_de_nascimento()
        {
            var dataDeHoje = DateTime.Now;

            var jogadorTeste = new Jogador()
            {
                Id = 1,
                NomeJogador = "SIlva Silva",
                DataNascimentoJogador = new DateTime(day: 10, month: 3, year: 1999),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = new List<Baralho>()
                {
                    new Baralho()
                    {
                        Id = 1,
                        IdJogador = 1,
                        NomeBaralho = "Mono Green Stomp",
                        FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                        CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                        {
                            new CopiaDeCartasNoBaralho
                            {
                                Carta = new Carta()
                                {
                                    Id = 7,
                                    NomeCarta = "Ghalta, Fome Primordial",
                                    CustoDeManaConvertidoCarta = 12,
                                    TipoDeCarta = "Creature",
                                    RaridadeCarta = RaridadeEnum.Raro,
                                    PrecoCarta = Convert.ToDecimal(5),
                                    CorCarta = "{G}"
                                },
                                QuantidadeCopiasDaCartaNoBaralho = 1
                            },

                            new CopiaDeCartasNoBaralho
                            {
                                Carta = new Carta()
                                {
                                    Id = 3,
                                    NomeCarta = "Floresta",
                                    CustoDeManaConvertidoCarta = 0,
                                    TipoDeCarta = "Basic Land",
                                    RaridadeCarta = RaridadeEnum.Comum,
                                    PrecoCarta = Convert.ToDecimal(0.5),
                                    CorCarta = ""
                                },
                                QuantidadeCopiasDaCartaNoBaralho = 99
                            }
                        },
                        QuantidadeDeCartasNoBaralho = 100,
                        DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                        PrecoDoBaralho = 54.5m,
                        CustoDeManaConvertidoDoBaralho = 0,
                        CorBaralho = "{G}"
                    }
                },
                SenhaHashJogador = "4e890854906f50e9ea4953ee9ec0468bc3f65ceee72876c850c3e5167c9220a6",
                SenhaHashConfirmacaoJogador = "4e890854906f50e9ea4953ee9ec0468bc3f65ceee72876c850c3e5167c9220a6"
            };

            var jogadorTesteExistente = servicoJogador.ObterPorId(jogadorTeste.Id);

            servicoJogador.Atualizar(jogadorTeste);

            Assert.Equal(jogadorTesteExistente.NomeJogador, servicoJogador.ObterPorId(jogadorTeste.Id).NomeJogador);
            Assert.Equal(jogadorTesteExistente.DataNascimentoJogador, servicoJogador.ObterPorId(jogadorTeste.Id).DataNascimentoJogador);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void ao_Excluir_com_id_valido_deve_remover_o_jogador_correspondente(int idJogadorTeste)
        {
            var mensagemDeErroEsperada = ($"Jogador {idJogadorTeste} Nao Encontrado");

            servicoJogador.Excluir(idJogadorTeste);

            var resultado = Assert.Throws<Exception>(() => servicoJogador.ObterPorId(idJogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(4)]
        public void ao_Excluir_com_um_id_invalido_ou_inexistente_deve_retornar_Exception(int idJogadorTeste)
        {
            var mensagemDeErroEsperada = ($"Jogador {idJogadorTeste} Nao Encontrado");

            var jogadorTeste = new Jogador()
            {
                Id = idJogadorTeste,
            };

            var resultado = Assert.Throws<Exception>(() => servicoJogador.Excluir(jogadorTeste.Id));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }
    }
}