sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "sap/ui/model/json/JSONModel",
    "mtgdeckbuilder/app/comum/Repository",
], function (BaseController, JSONModel, Repository) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.DetalhesJogador";
    const ID_DETALHES = "detalhesJogador";
    const NOME_DO_MODELO = "JogadorSelecionado";
    const STRING_VAZIA = "";

    
    return BaseController.extend(CONTROLLER, {

        formatter: formatter,

        onInit: function () {
            debugger
            this.getRouter().getRoute(ID_DETALHES).attachPatternMatched(async () => {
                return this.aoCoincidirRota();
            }, this)
        },

        aoCoincidirRota: function () {
            this.processarAcao(async () => {
                await Promise.all([
                    Repository.obterPorId(this.getView(), NOME_DO_MODELO)
                ])
            })
        },

        aoPressionarRetornarNavegacao: function () {
            const rotaTelaDeListagem = "criacaoJogador";
            return this.navegarPara(rotaTelaDeListagem);
        },
    });
});