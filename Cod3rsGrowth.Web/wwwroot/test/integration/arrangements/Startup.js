sap.ui.define([
    "sap/ui/test/Opa5"
], function (Opa5) {
    "use strict";
 
    return Opa5.extend("mtgdeckbuilder.test.integration.arrangements.Startup", {
        iStartMyApp: function () {
            return this.iStartMyAppInAFrame("../index.html");
        }
    });
});
