sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel"
], function (BaseController, Controller, JSONModel) {
    "use strict";

    const NAME_SPACE = "mtgdeckbuilder.app.comum.Repository";

    return Controller.extend(NAME_SPACE, {

        obterTodos: async function (filtros, nomeDoModelo) {

            let urlPagina = window.location.origin + "/api/" + nomeDoModelo;
            let url = new URL(urlPagina);

            let parametros = new URLSearchParams([
                ...Array.from(url.searchParams.entries()),
                ...Object.entries(filtros),
            ]).toString();

            let urlRequisicao = new URL(`${url.origin}${url.pathname}?${parametros}`);

            await fetch(urlRequisicao)
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

    });
});