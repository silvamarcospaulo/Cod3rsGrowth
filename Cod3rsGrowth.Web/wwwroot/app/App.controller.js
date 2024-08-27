sap.ui.define([
    "sap/ui/core/mvc/Controller"
], function (Controller) {
    "use strict";

    const NAMESPACE = "mtgdeckbuilder.app.App";
    
    return Controller.extend(NAMESPACE, {

        IdentificadorDeIdiomas: function (oEvent){
            var selectedItem = oEvent.getParameter("selectedItem").getKey();
            sap.ui.getCore().getConfiguration().setLanguage(selectedItem);
        },

        onInit: function () {
        }
    });
});