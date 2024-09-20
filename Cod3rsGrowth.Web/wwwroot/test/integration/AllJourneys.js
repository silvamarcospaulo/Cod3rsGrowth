sap.ui.define([
	"sap/ui/test/Opa5",
	"mtgdeckbuilder/test/integration/arrangements/Startup",
	"mtgdeckbuilder/test/integration/JornadaNotFound",
	"mtgdeckbuilder/test/integration/JornadaApp",
	"mtgdeckbuilder/test/integration/JornadaListagemJogador",
	"mtgdeckbuilder/test/integration/JornadaDetalhesJogador",
	"mtgdeckbuilder/test/integration/JornadaCriacaoJogador",
	"mtgdeckbuilder/test/integration/JornadaEdicaoJogador",
], function (Opa5, Startup) {
	"use strict";

	const NAME_SPACE = "mtgdeckbuilder";

	Opa5.extendConfig({
		arrangements: new Startup(),
		viewNamespace: NAME_SPACE,
		autoWait: true
	});
});