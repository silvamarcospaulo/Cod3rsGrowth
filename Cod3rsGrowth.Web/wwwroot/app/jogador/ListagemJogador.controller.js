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
            const nomeDoModelo = "Jogador";
            this.obterTodos(nomeDoModelo);
        },

        aplicarFiltros: function(oEvent) {

            const nomeUsuario = this.getView().byId("campoBuscaUsuario").getValue();

            const dataDeCadastro = this.getView().byId("campoBuscaUsuario").getValue();

            debugger
            MessageToast.show("https://localhost:7174/api/Jogador" + oEvent.getParameter("value"));
        },
    });
});