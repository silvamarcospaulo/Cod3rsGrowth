sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/ListagemJogador"
], (opaTest) => {
    "use strict";

    QUnit.module("JornadaListagemJogador");

    opaTest("Ao iniciar a aplicação a tela de listagem é iniciada", (Given, When, Then) => {

        Given.iStartMyUIComponent({
            componentConfig: {
                name: "mtgdeckbuilder"
            }
        });

        Then.naPaginaNotFound.aTelaNotFoundFoiCarregadaCorretamente();

        Then.iTeardownMyApp();
    });
});