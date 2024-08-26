sap.ui.define([
    "sap/ui/core/mvc/Controller"
], function (Controller) {
    "use strict";

    const NAME_SPACE = "mtgdeckbuilder.app.notFound.NotFound";

    return Controller.extend(NAME_SPACE, {

        IdentificadorDeIdiomas: function (oEvent) {
            var selectedItem = oEvent.getParameter("selectedItem").getKey();
            sap.ui.getCore().getConfiguration().setLanguage(selectedItem);
        },

        onInit: function () {
        }
    });
});