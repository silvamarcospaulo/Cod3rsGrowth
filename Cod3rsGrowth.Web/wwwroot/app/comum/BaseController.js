sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel",
    "sap/ui/core/UIComponent"
], function (Controller, JSONModel, UIComponent) {
    "use strict";

    const NAME_SPACE = "mtgdeckbuilder.app.comum.BaseController";

    return Controller.extend(NAME_SPACE, {

        getRouter: function () {
            return UIComponent.getRouterFor(this);
        },

        navegarPara: function (rota) {
            return this.getRouter().navTo(rota, {}, true);
        }
    });
});
