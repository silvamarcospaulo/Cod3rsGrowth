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
    const NOME_DO_MODELO_DE_ENUM_TIPO_DE_BARALHO = "FormatoDeJogo";
    const NOME_DO_MODELO_DE_BARALHOS_DO_JOGADOR = "Baralho";
    const NOME_DO_MODELO_DE_FILTROS = "FiltrosBaralho";
    const MODELO_DE_REQUISICAO = "Jogador";
    const STRING_VAZIA = "";
    const ID_CAMPO_BUSCAR_POR_NOME = "idCampoDeBuscaPorNome";
    const ID_COMBOBOX_FORMATO_DE_JOGO = "idComboBoxFormatoDeJogo";
    const ID_COMBOBOX_COR = "idComboBoxCor";
    let ID_JOGADOR;


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
                    Repository.obterTodos(this.getView(), STRING_VAZIA, NOME_DO_MODELO_DE_ENUM_TIPO_DE_BARALHO),
                    Repository.obterPorId(this.getView(), MODELO_DE_REQUISICAO, NOME_DO_MODELO_DE_JOGADOR_SELECIONADO),
                    Repository.obterTodos(this.getView(), this.filtroObterTodosBaralhosDoJogador(), NOME_DO_MODELO_DE_BARALHOS_DO_JOGADOR),
                ])
            })
        },

        aoPressionarRetornarNavegacao: function () {
            const rotaTelaDeListagem = "listagemJogador";
            return this.navegarPara(rotaTelaDeListagem);
        },

        aoPressionarAbreTelaDeEdicaoDeJogador: function () {
            const rotaTelaDeEdicao = "edicaoJogador";
            let jogadorEdicao = this.getView().getModel(NOME_DO_MODELO_DE_JOGADOR_SELECIONADO).getData().id;
            return this.navegarPara(rotaTelaDeEdicao, jogadorEdicao);
        },

        aoPressionarAplicarFiltros: async function () {
            let nomeBaralho = this.getView().byId(ID_CAMPO_BUSCAR_POR_NOME).getValue();
            let formatoDeJogoBaralho = this.getView().byId(ID_COMBOBOX_FORMATO_DE_JOGO).getSelectedKey();
            let corBaralho = this.getView().byId(ID_COMBOBOX_COR).getValue();

            let filtros = {
                nomeBaralho: nomeBaralho,
                corBaralho: corBaralho,
                idJogador: ID_JOGADOR
            };

            if (formatoDeJogoBaralho) {
                filtros.formatoDeJogoBaralho = formatoDeJogoBaralho;
            }

            let modeloFiltros = new JSONModel(filtros);

            this.getView().setModel(modeloFiltros, NOME_DO_MODELO_DE_FILTROS);

            let filtrosBaralho = this.getView().getModel(NOME_DO_MODELO_DE_FILTROS).getData();

            return Repository.obterTodos(this.getView(), filtrosBaralho, NOME_DO_MODELO_DE_BARALHOS_DO_JOGADOR)
                .then(() => this.removerValoresDosFiltros());
        },

        removerValoresDosFiltros: function () {
            let modeloFiltros = new JSONModel({ nomeBaralho: STRING_VAZIA, formatoDeJogoBaralho: STRING_VAZIA, corBaralho: STRING_VAZIA, idJogador: ID_JOGADOR });
            this.getView().setModel(modeloFiltros, NOME_DO_MODELO_DE_FILTROS);
        },

        filtroObterTodosBaralhosDoJogador: function () {
            const barra = "/";
            const numeroUm = 1;
            ID_JOGADOR = window.location.hash.substring(window.location.hash.lastIndexOf(barra) + numeroUm);

            let modeloFiltros = new JSONModel({ idJogador: ID_JOGADOR });
            this.getView().setModel(modeloFiltros, NOME_DO_MODELO_DE_FILTROS);

            return this.getView().getModel(NOME_DO_MODELO_DE_FILTROS).getData();
        }
    });
});