sap.ui.define([
	"sap/ui/test/Opa5",
	"sap/ui/test/matchers/I18NText"
],
	function (Opa5) {

		"use strict";

		const LISTAGEM_JOGADOR_VIEW_NAME = "app.jogador.ListagemJogador";

		Opa5.createPageObjects({
			naPaginaNotFound: {

				actions: {},

				assertions: {
					aTelaNotFoundFoiCarregadaCorretamente: function () {
						return this.waitFor({
							viewName: LISTAGEM_JOGADOR_VIEW_NAME,
							matchers: {
								i18NText: {
									propertyName: "text",
									key: "NotFound.text",
									modelName: "i18n"
								},
								i18NText: {
									propertyName: "description",
									key: "NotFound.description",
									modelName: "i18n"
								}
							},
							success: () => Opa5.assert.ok(true, "A pagina de NotFound foi carregada corretamente"),
							errorMessage: "A pagina de NotFound não foi carregada corretamente"
						});
					},
				}
			}
		});
	}
);