

sap.ui.require([
    "sap/ui/core/Core",
    "mtgdeckbuilder/test/AllJourneys"
], async (Core) => {
    "use strict";

    await Core.ready();

    QUnit.config.semaphore = 0;
    QUnit.start();
});