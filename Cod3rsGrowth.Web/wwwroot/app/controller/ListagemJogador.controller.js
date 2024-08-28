sap.ui.define([
    "mtgdeckbuilder/app/controller/BaseController"
], function (BaseController) {
    "use strict";

        const NAME_SPACE = "mtgdeckbuilder.app.controller.ListagemJogador";

        return BaseController.extend(NAME_SPACE, {
            onInit: function () {

            },
          
            aoPressionarRetornarNavegacao: function(){
                const rota = "app";
                return this.navegarPara(rota);
            },
        });
    }
);