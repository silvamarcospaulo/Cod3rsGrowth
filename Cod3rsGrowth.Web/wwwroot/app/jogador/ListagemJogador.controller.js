sap.ui.define([
    "mtgdeckbuilder/app/comum/Repository",
    "sap/ui/model/json/JSONModel",
    "mtgdeckbuilder/app/model/formatter"
], function (Repository, JSONModel, formatter) {
    "use strict";

    return Repository.extend("mtgdeckbuilder.app.jogador.ListagemJogador", {

        formatter: formatter,

        onInit: function () {
            this.obterTodosJogadores();
        },

        obterTodosJogadores: function () {
            this.obterTodos("Jogador");
        }

    });
});