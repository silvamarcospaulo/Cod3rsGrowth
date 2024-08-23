sap.ui.define([
    "sap/ui/core/mvc/Controller"
], function (Controller) {
    "use strict";

    const NOME = "mtgdeckbuilder.app.App";
    
    return Controller.extend(NOME, {

        IdentificaIdioma: function (oEvent){
            var selectedItem = oEvent.getParameter("selectedItem").getKey();
            sap.ui.getCore().getConfiguration().setLanguage(selectedItem);
        },

        onInit: function () {
        }
    });
});