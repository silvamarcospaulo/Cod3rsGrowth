sap.ui.define([
	"sap/ui/test/opaQunit",
	"./App"
], function (opaQunit, App) {
	"use strict";

	opaQunit.module("TelaPrincipal", () => {
		opaTest("Deve exibir a view principal", function (Given, When, Then) {
            
			Given.iStartMyUIComponent({
				comonentConfig: {
					name: "mtgdeckbuilder"
				}
			});

			Then
				.naPaginaPrincipal
				.naTelaCarregadaCorretamente();

			Then.iTeardownMyApp();
		});
	});
});