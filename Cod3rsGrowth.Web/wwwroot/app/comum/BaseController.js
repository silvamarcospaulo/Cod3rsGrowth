sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel",
    "sap/ui/core/UIComponent"
], function (Controller, JSONModel, UIComponent) {
    "use strict";

    const NAME_SPACE = "mtgdeckbuilder.app.comum.BaseController";

    return Controller.extend(NAME_SPACE, {

        getRouter: function () {
            return UIComponent.getRouterFor(this);
        },

        navegarPara: function (rota) {
            return this.getRouter().navTo(rota, {}, true);
        },

        obterTodos: function (url, nomeDoModelo) {
            
            //let uri = this.getRouter().getURL() + "/api/" + nomeDoModelo;
            
            debugger
            
            fetch(url)
                .then(requisicao => {
                    console.log(requisicao.status)
                    return requisicao.json();
                })
                .then(dados => {
                    const oDadosRequisicao = new JSONModel(dados);
                    this.getView().setModel(oDadosRequisicao, nomeDoModelo)
                })
        }          
    });
});