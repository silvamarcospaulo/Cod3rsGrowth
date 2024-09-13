sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "sap/ui/model/json/JSONModel",
    "mtgdeckbuilder/app/comum/Repository",
    "mtgdeckbuilder/app/model/formatter",
], function (BaseController, JSONModel, Repository, formatter) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.DetalhesJogador";
    const ID_DETALHES = "detalhesJogador";
    const NOME_DO_MODELO_DE_JOGADOR_SELECIONADO = "JogadorSelecionado";
    const MODELO_DE_REQUISICAO = "Jogador";
    const STRING_VAZIA = "";


    return BaseController.extend(CONTROLLER, {

        formatter: formatter,

        onInit: function () {
            this.getRouter().getRoute(ID_DETALHES).attachPatternMatched(async () => {
                return this.aoCoincidirRota();
            }, this)
        },

        aoCoincidirRota: function () {
            this.processarAcao(async () => {
                await Promise.all([
                    Repository.obterPorId(this.getView(), MODELO_DE_REQUISICAO, NOME_DO_MODELO_DE_JOGADOR_SELECIONADO)
                ])
            })
        },

        aoPressionarRetornarNavegacao: function () {
            const rotaTelaDeListagem = "listagemJogador";
            return this.navegarPara(rotaTelaDeListagem);
        },

        aoPressionarAbreTelaDeEdicaoDeJogador: function () {
            debugger
            const rotaTelaDeEdicao = "edicaoJogador";
            let jogadorEdicao = this.getView().getModel(NOME_DO_MODELO_DE_JOGADOR_SELECIONADO).getData().id;
            return this.navegarPara(rotaTelaDeEdicao, jogadorEdicao);
        },
    });
});