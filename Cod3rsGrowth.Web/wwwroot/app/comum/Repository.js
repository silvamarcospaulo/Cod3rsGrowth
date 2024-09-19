sap.ui.define([
    "sap/ui/model/json/JSONModel",
], function (JSONModel) {
    "use strict";

    return {

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

        obterEnums: async function (view, nomeDoModelo) {
            let urlPesquisaApi = "/api/";
            let urlPagina = window.location.origin + urlPesquisaApi + nomeDoModelo;
            let url = new URL(urlPagina);

            let urlRequisicao = new URL(`${url.origin}${url.pathname}`);

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

        obterPorId: async function (view, id, requisicao, nomeDoModelo) {
            const urlPesquisaApi = "/api/";
            const barra = "/";
            let urlPagina = window.location.origin + urlPesquisaApi + requisicao + barra + id;
            let url = new URL(urlPagina);

            let urlRequisicao = new URL(`${url.origin}${url.pathname}`);

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

        editar: async function (objeto, nomeDoModelo) {
            const metodoDeRequisicao = "PATCH";
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

        deletar: async function (requisicao, id) {
            const metodoDeRequisicao = "DELETE";
            const urlPesquisaApi = "/api/";
            const barra = "/";
            let urlPagina = window.location.origin + urlPesquisaApi + requisicao + barra + id;
            let urlRequisicao = new URL(urlPagina);

            let resposta = await fetch(urlRequisicao, {
                method: metodoDeRequisicao,
                headers: {
                    'Content-Type': 'application/json'
                }
            });

            if (!resposta.ok) {
                return resposta.json();
            };

            return resposta;
        },
    };
});