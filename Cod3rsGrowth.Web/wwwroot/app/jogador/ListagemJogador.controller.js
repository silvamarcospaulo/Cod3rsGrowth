sap.ui.define([
    "mtgdeckbuilder/app/comum/Repository",
    "mtgdeckbuilder/app/model/formatter",
    "sap/m/MessageToast",
    'sap/ui/core/mvc/Controller',
    'sap/ui/model/json/JSONModel'
], function (Repository, formatter, MessageToast, Controller, JSONModel) {
    "use strict";

    return Repository.extend("mtgdeckbuilder.app.jogador.ListagemJogador", {

        formatter: formatter,

        onInit: function () {
            this.obterTodosJogadores();
        },

        obterTodosJogadores: function () {
            this.obterTodos("Jogador");
        },

        dataAlterada: function (){
            
        }
    });
});