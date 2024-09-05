sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "mtgdeckbuilder/app/comum/Repository",
    "mtgdeckbuilder/app/model/formatter",
    "sap/ui/model/json/JSONModel"
], function (BaseController, Repository, formatter, JSONModel) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.ListagemJogador"
    const ID_LISTAGREM = "listagemJogador";
    const NOME_DO_MODELO = "Jogador";
    const NOME_DO_MODELO_DE_FILTROS = "ListagemJogadorFiltro";
    const ID_CAMPO_BUSCAR_POR_USUARIO = "campoBuscaUsuario";
    const ID_DATEPICKER_DATA_DE_CADASTRO = "datePickerDataDeCadastro";
    const ID_COMBOBOX_STATUS_CONTA = "comboBoxStatusConta";
    const STRING_VAZIA = "";

    return BaseController.extend(CONTROLLER, {

        formatter: formatter,

        onInit: function () {
            this.aoCoincidirRota();
        },

        aoCoincidirRota() {
            let ESSA_VIEW = this.getView();
            this.processarAcao(() => {
                this.getRouter().getRoute(ID_LISTAGREM).attachPatternMatched(() => {
                    Repository.obterTodos(ESSA_VIEW, STRING_VAZIA, NOME_DO_MODELO)
                }, this);
            });
        },

        aoPressionarAplicarFiltros: async function () {
            let ESSA_VIEW = this.getView();

            let nomeUsuario = this.getView().byId(ID_CAMPO_BUSCAR_POR_USUARIO).getValue();
            let statusConta = this.getView().byId(ID_COMBOBOX_STATUS_CONTA).getSelectedKey();
            let dataDeCadastro = this.getView().byId(ID_DATEPICKER_DATA_DE_CADASTRO).getValue();

            let modeloFiltros = new JSONModel({ usuarioJogador: nomeUsuario, contaAtivaJogador: statusConta, dataDeCriacaoContaJogador: dataDeCadastro });
            ESSA_VIEW.setModel(modeloFiltros, NOME_DO_MODELO_DE_FILTROS);

            let filtros = this.getView().getModel(NOME_DO_MODELO_DE_FILTROS).getData();

            return Repository.obterTodos(ESSA_VIEW, filtros, NOME_DO_MODELO)
                .then(() => this.removerValoresDosFiltros());
        },

        removerValoresDosFiltros: function () {
            let ESSA_VIEW = this.getView();
            let modeloFiltros = new JSONModel({ usuarioJogador: "", contaAtivaJogador: "", dataDeCriacaoContaJogador: "" });
            ESSA_VIEW.setModel(modeloFiltros, NOME_DO_MODELO_DE_FILTROS);
        }
    });
});