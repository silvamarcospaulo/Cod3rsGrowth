sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/App"
], (opaTest, Lista) => {
    "use strict";

    QUnit.module("JornadaApp");
 
    opaTest("Ao carregar tela principal, o nome deve ser App", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "mtgdeckbuilder"
            }
        });

		Then.naPaginaPrincipal.aTelaFoiCarregadaCorretamente();
    }); 
});