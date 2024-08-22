sap.ui.define([
	"sap/ui/test/Opa5",
    "sap/ui/test/opaQunit",
	"mtgdeckbuilder/test/integration/App"
], function (opaQunit, App) {
	"use strict";

	opaQunit.module("TelaPrincipal", () => {
		
		opaTest("Deve exibir a view principal", function (Given, When, Then) {
            
			Given.iStartMyApp()

			Then
				.naPaginaPrincipal
				.naTelaCarregadaCorretamente();
		});
	});
});