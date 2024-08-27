sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/core/UIComponent"
], function (Controller, History, UIComponent) {
    "use strict";

    return Controller.extend("mtgdeckbuilder.app.comum.BaseController", {

        getRouter : function () {
            return UIComponent.getRouterFor(this);
        },

        aoPressionarRetornarNavegacao: function () {
            var oHistory, sPreviousHash;

            oHistory = History.getInstance();
            sPreviousHash = oHistory.getPreviousHash();

            if (sPreviousHash !== undefined) {
                window.history.go(-1);
            } else {
                this.getRouter().navTo("app", {}, true);
            }
        }

    });

});