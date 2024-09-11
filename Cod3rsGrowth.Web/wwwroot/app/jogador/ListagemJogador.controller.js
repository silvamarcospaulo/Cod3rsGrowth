sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "mtgdeckbuilder/app/comum/Repository",
    "mtgdeckbuilder/app/model/formatter",
    "sap/ui/model/json/JSONModel"
], function (BaseController, Repository, formatter, JSONModel) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.ListagemJogador"
    const ID_LISTAGEM = "listagemJogador";
    const NOME_DO_MODELO = "Jogador";
    const NOME_DO_MODELO_DE_FILTROS = "ListagemJogadorFiltro";
    const ID_CAMPO_BUSCAR_POR_USUARIO = "campoBuscaUsuario";
    const ID_DATEPICKER_DATA_DE_CADASTRO = "datePickerDataDeCadastro";
    const ID_COMBOBOX_STATUS_CONTA = "comboBoxStatusConta";
    const STRING_VAZIA = "";

    return BaseController.extend(CONTROLLER, {

        formatter: formatter,

        onInit: function () {
            this.getRouter().getRoute(ID_LISTAGEM).attachPatternMatched(async () => {
                return this.aoCoincidirRota();
            }, this)
        },

        aoCoincidirRota: function() {
            this.processarAcao(async () => {
                await Promise.all([
                    Repository.obterTodos(this.getView(), STRING_VAZIA, NOME_DO_MODELO)
                ])
            })
        },

        aoPressionarAplicarFiltros: async function () {
            let nomeUsuario = this.getView().byId(ID_CAMPO_BUSCAR_POR_USUARIO).getValue();
            let statusConta = this.getView().byId(ID_COMBOBOX_STATUS_CONTA).getSelectedKey();
            let dataDeCadastro = this.getView().byId(ID_DATEPICKER_DATA_DE_CADASTRO).getValue();

            let modeloFiltros = new JSONModel({ usuarioJogador: nomeUsuario, contaAtivaJogador: statusConta, dataDeCriacaoContaJogador: dataDeCadastro });
            this.getView().setModel(modeloFiltros, NOME_DO_MODELO_DE_FILTROS);

            let filtros = this.getView().getModel(NOME_DO_MODELO_DE_FILTROS).getData();  

            return Repository.obterTodos(this.getView(), filtros, NOME_DO_MODELO)
                .then(() => this.removerValoresDosFiltros());
        },

        removerValoresDosFiltros: function () {
            let modeloFiltros = new JSONModel({ usuarioJogador: STRING_VAZIA, contaAtivaJogador: STRING_VAZIA, dataDeCriacaoContaJogador: STRING_VAZIA});
            this.getView().setModel(modeloFiltros, NOME_DO_MODELO_DE_FILTROS);
        },

        aoPressionarAbreTelaDeCriacaoDeJogador: function (){
            const rotaTelaDeCriacao = "criacaoJogador";
            return this.navegarPara(rotaTelaDeCriacao);
        },

        aoPressionarAbreTelaDeDetalhesDeJogador: function (){
            const rotaTelaDeDetalhes = "detalhesJogador";
            return this.navegarPara(rotaTelaDeDetalhes);
        },
    });
});