sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/CriacaoJogador"
], (opaTest) => {
    "use strict";

    QUnit.module("JornadaCriacaoJogador");

    opaTest("Ao realizar a criação de com campo de senha inválida, não deve criar um jogador e deve abrir uma caixa de diálogo informando o erro", (Given, When, Then) => {

        Given.iStartMyUIComponent({
            componentConfig: {
                name: "mtgdeckbuilder"
            },
            hash: "criacaoJogador"
        });

        When.naPaginaDeCriacaoDeJogador.entreveUmValorValidoNoInputDeNomeDoJogador();
        When.naPaginaDeCriacaoDeJogador.entreveUmValorValidoNoInputDeSobrenomeDoJogador();
        When.naPaginaDeCriacaoDeJogador.entreveUmValorValidoNoInputDeDataDeNascimentoDoJogador();
        When.naPaginaDeCriacaoDeJogador.entreveUmValorValidoNoInputDeUsuarioDoJogador();
        When.naPaginaDeCriacaoDeJogador.entreveUmValorValidoNoInputDeConfirmacaoDeUsuarioDoJogador();
        When.naPaginaDeCriacaoDeJogador.entreveUmValorValidoNoInputDeSenhaDoJogador();
        When.naPaginaDeCriacaoDeJogador.entreveUmValorValidoNoInputDeConfirmacaoDeSenhaDoJogador();
        When.naPaginaDeCriacaoDeJogador.pressionoOBotaoDeAdicionarJogador();

        //Then.iTeardownMyApp();
    });
});