sap.ui.define([
	"sap/ui/test/Opa5"
],
	function (Opa5) {

		"use strict";

		const VIEW_NAME = "app.App";

		Opa5.createPageObjects({
			naPaginaPrincipal: {
				
				actions: {},

				assertions: {
					aTelaFoiCarregadaCorretamente: function () {
						return this.waitFor({
							viewName : VIEW_NAME,
							success: () => Opa5.assert.ok(true, "A tela foi carregada corretamente"),
							errorMessage: "A tela não foi carregada corretamente"
						});
					},
				},
			}
		});
	}
);