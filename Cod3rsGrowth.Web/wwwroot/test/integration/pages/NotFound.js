sap.ui.define([
	"sap/ui/test/Opa5"
],
	function (Opa5) {

		"use strict";

		const NOTFOUND_VIEW_NAME = "app.view.App";

		Opa5.createPageObjects({
			naPaginaNotFound: {

				actions: {},

				assertions: {
					aTelaNotFoundFoiCarregadaCorretamente: function () {
						return this.waitFor({
							viewName: NOTFOUND_VIEW_NAME,
							success: () => Opa5.assert.ok(true, "A pagina de NotFound foi carregada corretamente"),
							errorMessage: "A pagina de NotFound não foi carregada corretamente"
						});
					},
				}
			}
		});
	}
);