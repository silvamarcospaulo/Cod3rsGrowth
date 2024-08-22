sap.ui.define([
	"sap/ui/test/Opa5"
],
	function (Opa5) {

		"use strict";

		Opa5.createPageObjects({
			naPaginaPrincipal: {
				actions: {

				},
				assertions: {
					naTelaCarregadaCorretamente: function () {
						return this.waitFor({
							viewName: "App",
							success: () => Opa5.assert.ok(true, "A tela foi carregada corretamente"),
							errorMessage: "A tela não foi carregada corretamente"
					})
				}
			}
		}
	})
})