sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/ListagemJogador",
    "mtgdeckbuilder/test/integration/pages/DetalhesJogador"
], (opaTest, ListagemJogador, DetalhesJogador) => {
    "use strict";

    QUnit.module("JornadaPaginaDetalhesJogador");

    const NOME_ESPERADO = "Marcos Paulo";
    const SOBRE_NOME_ESPERADO = "Silva";
    const DATA_DE_NASCIMENTO_ESPERADA = "18/07/1999";
    const NOME_DE_USUARIO_ESPERADO = "marcos";
    const STATUS_ESPERADO = "Conta ativa";
    const DATA_DE_CADASTRO_ESPERADA = "03/09/2024";
    const QUANTIDADE_DE_BARALHOS = "4";
    const PRECO_DAS_CARTAS = "90";
    const QUANTIDADE_DE_BARALHOS_NA_LISTA = 4;
    const COMBO_BOX_COR_AZUL = "Azul";
    const QUANTIDADE_DE_BARALHOS_NA_LISTA_FILTRO_NOME = 1;
    const QUANTIDADE_DE_BARALHOS_NA_LISTA_FILTRO_FORMATO_COMMANDER = 4;
    const QUANTIDADE_DE_BARALHOS_NA_LISTA_FILTRO_FORMATO_STANDARD_PAUPER = 0;
    const QUANTIDADE_DE_BARALHOS_NA_LISTA_FILTRO_COR_AZUL = 1;
    const FORMATO_DE_JOGO_COMMANDER = "Commander";
    const FORMATO_DE_JOGO_STANDARD = "Standard";


    opaTest("Ao carregar a página de detalhes do jogador, deve carregar o nome Marcos Paulo corretamente", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "mtgdeckbuilder"
            },
            hash: "detalhesJogador/10025"
        });

        Then.naPaginaDeDetalhesJogador.confiroOValorDoCampo(NOME_ESPERADO);
        Then.naPaginaDeDetalhesJogador.confiroOValorDoCampo(SOBRE_NOME_ESPERADO);
        Then.naPaginaDeDetalhesJogador.confiroOValorDoCampo(DATA_DE_NASCIMENTO_ESPERADA);
        Then.naPaginaDeDetalhesJogador.confiroOValorDoCampo(NOME_DE_USUARIO_ESPERADO);
        Then.naPaginaDeDetalhesJogador.confiroOValorDoCampo(STATUS_ESPERADO);
        Then.naPaginaDeDetalhesJogador.confiroOValorDoCampo(DATA_DE_CADASTRO_ESPERADA);
        Then.naPaginaDeDetalhesJogador.confiroOValorDoCampo(QUANTIDADE_DE_BARALHOS);
        Then.naPaginaDeDetalhesJogador.confiroOValorDoCampo(PRECO_DAS_CARTAS);
        Then.naPaginaDeDetalhesJogador.aTabelaDeveConterAQuantidadeEsperada(QUANTIDADE_DE_BARALHOS_NA_LISTA);
    });

    opaTest("Ao filtrar baralhos com nome do baralho, retorna uma lista com dois baralhos", (Given, When, Then) => {
        When.naPaginaDeDetalhesJogador.escreveNoCampoDeBuscaPorNomeDoBaralho();
        When.naPaginaDeDetalhesJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeDetalhesJogador.aTabelaDeveConterAQuantidadeEsperada(QUANTIDADE_DE_BARALHOS_NA_LISTA_FILTRO_NOME);
    });

    opaTest("Ao filtrar baralhos com formato de jogo commander, retorna uma lista com quatro baralhos", (Given, When, Then) => {
        When.naPaginaDeDetalhesJogador.selecionoNoCampoComboBoxFormatoDeJogo(FORMATO_DE_JOGO_COMMANDER);
        When.naPaginaDeDetalhesJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeDetalhesJogador.aTabelaDeveConterAQuantidadeEsperada(QUANTIDADE_DE_BARALHOS_NA_LISTA_FILTRO_FORMATO_COMMANDER);
    });

    opaTest("Ao filtrar baralhos com formato de jogo standard, retorna uma lista com quatro baralhos", (Given, When, Then) => {
        When.naPaginaDeDetalhesJogador.selecionoNoCampoComboBoxFormatoDeJogo(FORMATO_DE_JOGO_STANDARD);
        When.naPaginaDeDetalhesJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeDetalhesJogador.aTabelaDeveConterAQuantidadeEsperada(QUANTIDADE_DE_BARALHOS_NA_LISTA_FILTRO_FORMATO_STANDARD_PAUPER);
    });

    opaTest("Ao filtrar baralhos com cor baralho, retorna uma lista com um baralho", (Given, When, Then) => {
        When.naPaginaDeDetalhesJogador.selecionoNoCampoComboBoxCor(COMBO_BOX_COR_AZUL);
        When.naPaginaDeDetalhesJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeDetalhesJogador.aTabelaDeveConterAQuantidadeEsperada(QUANTIDADE_DE_BARALHOS_NA_LISTA_FILTRO_COR_AZUL);

    });

    opaTest("Ao clicar no botão de editar jogador, deve carregar a view de edicao", (Given, When, Then) => {
        When.naPaginaDeDetalhesJogador.pressionarBotaoDeEditarJogador();
        Then.naPaginaDeDetalhesJogador.aPaginaDeEdicaoFoiCarregada();
        When.naPaginaDeDetalhesJogador.selecionoBotaoDeNavegarParaTras();
    });

    opaTest("Ao clicar no botão de editar jogador, deve carregar a view de edicao", (Given, When, Then) => {
        When.naPaginaDeDetalhesJogador.pressionarBotaoDeEditarJogador();
        Then.naPaginaDeDetalhesJogador.aPaginaDeEdicaoFoiCarregada();

        Then.iTeardownMyApp();
    });
});