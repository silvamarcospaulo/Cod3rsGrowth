sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "mtgdeckbuilder/app/comum/Repository",
    "mtgdeckbuilder/app/model/formatter",
    "sap/ui/model/json/JSONModel"
], function (BaseController, Repository, formatter, JSONModel) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.ListagemJogador"
    const ID_LISTAGEM = "listagemJogador";
    const NOME_DO_MODELO = "JogadorSelecionado";
    const STRING_VAZIA = "";

    return BaseController.extend(CONTROLLER, {

        formatter: formatter,

        onInit: function () {
            this.getRouter().getRoute(ID_LISTAGEM).attachPatternMatched(async () => {
                return this.aoCoincidirRota();
            }, this)
        },

        aoCoincidirRota: function () {
            this.processarAcao(async () => {
                await Promise.all([
                    Repository.obterPorId(this.getView(), STRING_VAZIA, NOME_DO_MODELO)
                ])
            })
        },

        getContextByIndex: function (evt) {
            const oTable = this.byId("table1");
            const iIndex = oTable.getSelectedIndex();
            let sMsg;
            if (iIndex < 0) {
                sMsg = "no item selected";
            } else {
                sMsg = oTable.getContextByIndex(iIndex);
            }
            MessageToast.show(sMsg);
        },

        clearSelection: function (evt) {
            this.byId("table1").clearSelection();
        },

        aoPressionarRetornarNavegacao: function () {
            const rotaTelaDeListagem = "criacaoJogador";
            return this.navegarPara(rotaTelaDeListagem);
        },
    });
});