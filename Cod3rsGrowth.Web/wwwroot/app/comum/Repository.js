sap.ui.define([
    "sap/ui/model/json/JSONModel",
    "sap/ui/core/library",
    "sap/m/Dialog",
    "sap/m/Button",
    "sap/m/library",
    "sap/m/Text"
], function (JSONModel, ValueState, coreLibrary, Dialog, Button, mobileLibrary, Text) {
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

        criar: async function (objeto, nomeDoModelo) {
            const metodoDeRequisicao = "POST";
            let urlPesquisaApi = "/api/";
            let urlPagina = window.location.origin + urlPesquisaApi + nomeDoModelo;
            let urlRequisicao = new URL(urlPagina);

            let resposta = await fetch(urlRequisicao, {
                method: metodoDeRequisicao,
                headers: {
                    'Content-Type': 'application/json'
                },
                body: objeto,
            });

            if (!resposta.ok) {
                return resposta.json();
            };

            return resposta;
        },

        obterPorId: async function (view, requisicao, nomeDoModelo) {
            let urlPesquisaApi = "/api/";
            let barra = "/";
            let hashDaRequisicao = window.location.hash;
            var idDoItem = hashDaRequisicao.substring(hashDaRequisicao.lastIndexOf(barra) + 1);
            let urlPagina = window.location.origin + urlPesquisaApi + requisicao + barra + idDoItem;
            let url = new URL(urlPagina);

            let urlRequisicao = new URL(`${url.origin}${url.pathname}`);

            await fetch(urlRequisicao)
                .then(requisicao => {
                    return requisicao.json();
                })
                .then(dados => {
                    const oDadosRequisicao = new JSONModel(dados);
                    view.setModel(oDadosRequisicao, nomeDoModelo)
                })
                .catch(erro => {
                });
        }
    };
});