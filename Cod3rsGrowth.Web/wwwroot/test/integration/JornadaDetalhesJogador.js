sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/DetalhesJogador"
], (opaTest) => {
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

    opaTest("Ao clicar no botão de editar jogador, deve carregar a view de edicao", (Given, When, Then) => {

        When.naPaginaDeDetalhesJogador.perssionarBotaoDeEditarJogador();
        Then.naPaginaDeDetalhesJogador.aPaginaDeEdicaoFoiCarregada();

        Then.iTeardownMyApp();
    });
});