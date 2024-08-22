sap.ui.define([
	"sap/ui/test/Opa5",
	"./integration/arrangements/Startup",
	"./integration/JornadaApp"
], (Opa5,
	Startup) => {

	"use strict";

	const NAME_SPACE = "mtgdeckbuilder.app";

	Opa5.extendConfig({
		arrangements: new Startup(),
		viewNamespace: NAME_SPACE,
		autoWait: true
	});
});