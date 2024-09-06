sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
], function (BaseController) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.CriacaoJogador"

    return BaseController.extend(CONTROLLER, {

        onInit: function () {

        },

        aoPressionarRetornarNavegacao: function(){
            const rota = "listagemJogador";
            return this.navegarPara(rota);
        }
    });
});