sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/ListagemJogador"
], (opaTest) => {
    "use strict";

    QUnit.module("JornadaListagemJogador");

    const QUANTIDADE_DE_CONTAS_RETORNADAS_NOME = 1;
    const QUANTIDADE_DE_CONTAS_RETORNADAS_CONTA_ATIVA = 1;
    const QUANTIDADE_DE_CONTAS_RETORNADAS_CONTA_INATIVA = 1;
    const QUANTIDADE_DE_CONTAS_RETORNADAS_FILTRAGEM_POR_DATA = 1;

    opaTest("Ao realizar filtragens na tela através da filtragem por usuário, retorna uma lista com um jogador", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "mtgdeckbuilder"
            }
        });

        When.naPaginaDeListagemJogador.escreveNoCampoDeBuscaPorUsuario();
        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeListagemJogador.aTabelaDeveConterAQuantidadeEsperada(QUANTIDADE_DE_CONTAS_RETORNADAS_NOME);
    }),

    opaTest("Ao realizar filtragens na tela através do status da conta ativa, retorna uma lista com dois jogadores", (Given, When, Then) => {
        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();

        When.naPaginaDeListagemJogador.selecionoNaComboboxDeStatusDaContaAtiva();
        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeListagemJogador.aTabelaDeveConterAQuantidadeEsperada(QUANTIDADE_DE_CONTAS_RETORNADAS_CONTA_ATIVA);
    }),

    opaTest("Ao realizar filtragens na tela através do status da conta inativa, retorna uma lista com cinco jogador", (Given, When, Then) => {
        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();

        When.naPaginaDeListagemJogador.selecionoNaComboboxDeStatusDaContaInativa();
        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeListagemJogador.aTabelaDeveConterAQuantidadeEsperada(QUANTIDADE_DE_CONTAS_RETORNADAS_CONTA_INATIVA);
    }),

    opaTest("Ao realizar filtragens na tela através do datepicker, retorna uma lista com um jogador", (Given, When, Then) => {
        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();

        When.naPaginaDeListagemJogador.selecionoDatePickerEAdicionoAData();
        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeListagemJogador.aTabelaDeveConterAQuantidadeEsperada(QUANTIDADE_DE_CONTAS_RETORNADAS_FILTRAGEM_POR_DATA);
        Then.iTeardownMyApp();
    });

    opaTest("Ao clicar no botão adicionar jogador, a view de criaçao foi carregada na tela", (Given, When, Then) => {
        When.naPaginaDeListagemJogador.aoClicarNoBotaoAdicionarJogadorRedirecionaParaATelaDeCadastro();

        Then.naPaginaDeListagemJogador.aTelaDeCriacaoFoiCarregada();

        Then.iTeardownMyApp();
    });
});