QUnit.config.autostart = true;

sap.ui.require([
    "sap/ui/core/Core",
	"sap/ui/test/Opa5",
    "mtgdeckbuilder/test/integration/arrangements/Startup",
    "mtgdeckbuilder/test/AllJourneys",
    "mtgdeckbuilder/test/integration/JornadaApp",
], async (Core, Opa5, Startup) => {
    "use strict";

	Opa5.extendConfig({
		arrangements: new Startup(),
		viewNamespace: "mtgdeckbuilder.app",
		autoWait: 15
	});

    Core.attachInit(() => QUnit.start());
});