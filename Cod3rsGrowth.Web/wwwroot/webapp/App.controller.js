sap.ui.define([
    "sap/ui/core/mvc/Controller"
], function (Controller) {
    "use strict";

    return Controller.extend("ui5.mtgdeckbuilder.webapp.App", {

        onChangeLanguage: function (oEvent){
            var selectedItem = oEvent.getParameter("selectedItem").getKey();
            sap.ui.getCore().getConfiguration().setLanguage(selectedItem);
        },

        onInit: function () {
        }
    });
});