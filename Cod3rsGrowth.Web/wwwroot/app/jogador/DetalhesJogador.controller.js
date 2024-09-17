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
    const REQUISICAO = "Jogador";
    const STRING_VAZIA = "";
    const ID_CAMPO_BUSCAR_POR_NOME = "idCampoDeBuscaPorNome";
    const ID_COMBOBOX_FORMATO_DE_JOGO = "idComboBoxFormatoDeJogo";
    const ID_COMBOBOX_COR = "idComboBoxCor";
    let idJogador;

    return BaseController.extend(CONTROLLER, {

        formatter: formatter,

        onInit: function () {
            this.getRouter().getRoute(ID_DETALHES).attachPatternMatched(async (evento) => {
                return this.aoCoincidirRota(evento);
            }, this)
        },

        aoCoincidirRota: function (evento) {
            let propriedadesEvento = "arguments";
            idJogador = evento.getParameter(propriedadesEvento).id;
            this.processarAcao(async () => {
                await Promise.all([
                    Repository.obterEnums(this.getView(), NOME_DO_MODELO_DE_ENUM_TIPO_DE_BARALHO),
                    Repository.obterPorId(this.getView(), idJogador, REQUISICAO, NOME_DO_MODELO_DE_JOGADOR_SELECIONADO),
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
            let idJogador = this.getView().getModel(NOME_DO_MODELO_DE_JOGADOR_SELECIONADO).getData().id;
            let nomeBaralho = this.getView().byId(ID_CAMPO_BUSCAR_POR_NOME).getValue();
            let formatoDeJogoBaralho = this.getView().byId(ID_COMBOBOX_FORMATO_DE_JOGO).getSelectedKey();
            let corBaralho = this.getView().byId(ID_COMBOBOX_COR).getValue();

            let filtros = {
                nomeBaralho: nomeBaralho,
                corBaralho: corBaralho,
                idJogador: idJogador
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
            let idJogador = this.getView().getModel(NOME_DO_MODELO_DE_JOGADOR_SELECIONADO).getData().id;
            let modeloFiltros = new JSONModel({ nomeBaralho: STRING_VAZIA, formatoDeJogoBaralho: STRING_VAZIA, corBaralho: STRING_VAZIA, idJogador: idJogador });
            this.getView().setModel(modeloFiltros, NOME_DO_MODELO_DE_FILTROS);
        },

        filtroObterTodosBaralhosDoJogador: function () {
            let modeloFiltros = new JSONModel({ idJogador: idJogador });
            this.getView().setModel(modeloFiltros, NOME_DO_MODELO_DE_FILTROS);

            return this.getView().getModel(NOME_DO_MODELO_DE_FILTROS).getData();
        },

        aoPressionarApagaJogador: function () {
            debugger
            let idJogadorSelecionado = this.getView().getModel(NOME_DO_MODELO_DE_JOGADOR_SELECIONADO).getData().id;
            Repository.deletar(REQUISICAO, idJogadorSelecionado);
        }
    });
});