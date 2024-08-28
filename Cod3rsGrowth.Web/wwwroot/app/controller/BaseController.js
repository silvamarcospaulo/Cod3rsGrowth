sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/core/UIComponent"
], function (Controller, History, UIComponent) {
    "use strict";

    const NAME_SPACE = "mtgdeckbuilder.app.controller.BaseController";

    return Controller.extend(NAME_SPACE, {

        getRouter: function () {
            return UIComponent.getRouterFor(this);
        },

        navegarPara: function (rota) {
            return this.getRouter().navTo(rota, {}, true);
        }
    });
});