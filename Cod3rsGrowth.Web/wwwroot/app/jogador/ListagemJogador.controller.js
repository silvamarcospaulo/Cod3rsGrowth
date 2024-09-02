sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController"
], function (BaseController) {
    "use strict";

    return BaseController.extend("mtgdeckbuilder.app.jogador.ListagemJogador", {

        onInit: function () {

            this.obterTodosJogadores();
        },

        obterTodosJogadores: function(){

            let url = this.getRouter().getURL() + "/api/" + "Jogador";


            debugger

            this.obterTodos(url, "Jogador")
        }
    });

});