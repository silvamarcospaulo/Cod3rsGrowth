sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/notFound/JornadaPaginaNotFound"
], (opaTest) => {
    "use strict";

    QUnit.module("JornadaPaginaNotFound");

    opaTest("Ao realizar uma requisição em uma rota não existente, deve responder a tela de NotFound", (Given, When, Then) => {

        Given.iStartMyUIComponent({
            componentConfig: {
                name: "mtgdeckbuilder"
            }
        });

        Then.naPaginaNotFound.aTelaFoiCarregadaCorretamente();

        Then.iTeardownMyAppFrame();
    });
});