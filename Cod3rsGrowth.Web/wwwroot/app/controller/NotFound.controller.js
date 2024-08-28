sap.ui.define([
    "mtgdeckbuilder/app/controller/BaseController"
], function (BaseController) {
    "use strict";

        const NAME_SPACE = "mtgdeckbuilder.app.controller.NotFound";
        const PAGINA_ANTERIOR = "app";
        return BaseController.extend(NAME_SPACE, {

            aoPressionarRetornarNavegacao: function(){
                this.retornarNavegacao (PAGINA_ANTERIOR);
            },

            onInit: function () {

            }
        });
    }
);