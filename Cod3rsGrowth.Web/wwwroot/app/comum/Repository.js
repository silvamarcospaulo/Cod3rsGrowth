sap.ui.define([
    "sap/ui/model/json/JSONModel"
], function (JSONModel) {
    "use strict";
    
    return {

        obterTodos: async function (view, filtros, nomeDoModelo) {
            let urlPesquisaApi = "/api/";
            let urlPagina = window.location.origin + urlPesquisaApi + nomeDoModelo;
            let url = new URL(urlPagina);

            let parametros = new URLSearchParams([
                ...Array.from(url.searchParams.entries()),
                ...Object.entries(filtros),
            ]).toString();

            let urlRequisicao = new URL(`${url.origin}${url.pathname}?${parametros}`);

            await fetch(urlRequisicao)
                .then(requisicao => {
                    return requisicao.json();
                })
                .then(dados => {
                    const oDadosRequisicao = new JSONModel(dados);
                    view.setModel(oDadosRequisicao, nomeDoModelo);
                })
                .catch(erro => {
                });
        },

        criar: async function (view, objeto) {
            
        }

    };
});