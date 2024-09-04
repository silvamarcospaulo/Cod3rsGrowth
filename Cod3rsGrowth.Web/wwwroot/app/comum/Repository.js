sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel"
], function (BaseController, Controller, JSONModel) {
    "use strict";

    const NAME_SPACE = "mtgdeckbuilder.app.comum.Repository";

    return Controller.extend(NAME_SPACE, {

        obterTodos: async function (nomeDoModelo) {

            const urlPagina = window.location.origin;

            const url = urlPagina + "/api/" + nomeDoModelo;

            await fetch(url)
                .then(requisicao => {
                    console.log(requisicao.status);
                    return requisicao.json();
                })
                .then(dados => {
                    const oDadosRequisicao = new JSONModel(dados);
                    this.getView().setModel(oDadosRequisicao, nomeDoModelo);
                })
                .catch(erro => {
                    console.error("Erro ao obter dados:", erro);
                });
        },

        obterTodosFiltros: async function (filtros, nomeDoModelo) {

            const urlPagina = window.location.origin;

            const url = urlPagina + "/api/" + nomeDoModelo + "?" + filtros;
            
            console. log(url)

            await fetch(url)
                .then(requisicao => {
                    console.log(requisicao.status);
                    return requisicao.json();
                })
                .then(dados => {
                    console. log(dados)
                    const oDadosRequisicao = new JSONModel(dados);
                    this.getView().setModel(oDadosRequisicao, nomeDoModelo);
                })
                .catch(erro => {
                    console.error("Erro ao obter dados:", erro);
                });
            }
    });
});