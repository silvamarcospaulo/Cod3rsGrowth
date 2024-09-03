sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "sap/ui/model/json/JSONModel"
], function (BaseController, JSONModel) {
    "use strict";

    const NAME_SPACE = "mtgdeckbuilder.app.comum.Repository";

    return BaseController.extend(NAME_SPACE, {

        obterTodos: function (nomeDoModelo) {

            const urlPagina = window.location.origin;

            const url = urlPagina + "/api/" + nomeDoModelo;

            fetch(url)
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
        }


    });
});