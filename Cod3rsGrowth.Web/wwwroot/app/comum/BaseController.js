sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/UIComponent",
    "sap/ui/core/BusyIndicator",
    "sap/ui/model/json/JSONModel",
], function (Controller, UIComponent) {

    "use strict";

    const NAME_SPACE = "mtgdeckbuilder.app.comum.BaseController";

    return Controller.extend(NAME_SPACE, {

        getRouter: function () {
            return UIComponent.getRouterFor(this);
        },

        getModel: function (name) {
            return this.getView().getModel(name);
        },

        navegarPara: function (rota, id) {
            return this.getRouter().navTo(rota, {
                id: id
            }, true);
        },

        processarAcao: function (action) {
            try {
                const result = action();
                return result;
            }
            catch (error) {
            }
        },
    });
});