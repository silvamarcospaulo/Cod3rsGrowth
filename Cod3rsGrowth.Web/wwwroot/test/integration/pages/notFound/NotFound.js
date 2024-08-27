sap.ui.define([
	"sap/ui/test/Opa5"
],
	function (Opa5) {

		"use strict";

		const VIEW_NAME = "app.notFound.NotFound";

		Opa5.createPageObjects({
			naPaginaNotFound: {

				actions: {},
				
				assertions: {
					aPaginaDeNotFound: function () {
						return this.waitFor({
							viewName : VIEW_NAME,
							success: () => Opa5.assert.ok(true, "A tela NotFound foi carregada corretamente"),
							errorMessage: "A tela não foi carregada corretamente"
						});
					},
				}
			}
		});
	}
);