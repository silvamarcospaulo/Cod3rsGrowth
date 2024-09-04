sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/ListagemJogador"
], (opaTest) => {
    "use strict";

    QUnit.module("JornadaListagemJogador");

    opaTest("Ao relalizar filtragens na tela através dos filtros, retorna uma lista de jogadores correspondentes", (Given, When, Then) => {

        const QUANTIDADE_DE_CONTAS_RETORNADAS = 1;
        const QUANTIDADE_DE_CONTAS_RETORNADAS_CONTA_ATIVA = 2;
        const QUANTIDADE_DE_CONTAS_RETORNADAS_CONTA_INATIVA = 1;
        const QUANTIDADE_DE_CONTAS_RETORNADAS_FILTRAGEM_POR_DATA = 1;

        Given.iStartMyUIComponent({
            componentConfig: {
                name: "mtgdeckbuilder"
            }
        });

        Then.naPaginaDeListagemJogador.aTelaDeListagemDeJogadoresFoiCarregadaCorretamente();

        When.naPaginaDeListagemJogador.escreveNoCampoDeBuscaPorUsuario();
        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeListagemJogador.aoAplicarFiltrosDeveRetornarAListaFiltrada(QUANTIDADE_DE_CONTAS_RETORNADAS);

        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();

        When.naPaginaDeListagemJogador.selecionoNaComboboxDeStatusDaContaContaAtiva();
        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeListagemJogador.aoAplicarFiltrosDeveRetornarAListaFiltrada(QUANTIDADE_DE_CONTAS_RETORNADAS_CONTA_ATIVA);

        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();

        When.naPaginaDeListagemJogador.selecionoNaComboboxDeStatusDaContaInativa();
        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeListagemJogador.aoAplicarFiltrosDeveRetornarAListaFiltrada(QUANTIDADE_DE_CONTAS_RETORNADAS_CONTA_INATIVA);

        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();

        When.naPaginaDeListagemJogador.selecionoDatePickerEAdicionoAData();
        When.naPaginaDeListagemJogador.selecionoBotaoDeAplicarFiltros();
        Then.naPaginaDeListagemJogador.aoAplicarFiltrosDeveRetornarAListaFiltrada(QUANTIDADE_DE_CONTAS_RETORNADAS_FILTRAGEM_POR_DATA);

        Then.iTeardownMyApp();
    });
});