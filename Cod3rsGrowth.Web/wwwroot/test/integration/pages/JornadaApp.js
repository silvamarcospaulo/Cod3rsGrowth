sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/App"
], (opaTest) => {
    "use strict";

    QUnit.module("JornadaApp");

    opaTest("Ao carregar a tela, verifica o nome da view", (Given, When, Then) => {

        Given.iStartMyUIComponent({
            componentConfig: {
                name: "mtgdeckbuilder"
            }
        });

        Then.naPaginaPrincipal.aTelaFoiCarregadaCorretamente();

        Then.iTeardownMyAppFrame();
    });
});