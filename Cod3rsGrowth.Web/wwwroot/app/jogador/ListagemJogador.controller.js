sap.ui.define([
    "mtgdeckbuilder/app/comum/Repository",
    "mtgdeckbuilder/app/model/formatter"
], function (Repository, formatter) {
    "use strict";

    const NOME_DO_MODELO = "Jogador";
    const ID_CAMPO_BUSCAR_POR_USUARIO = "campoBuscaUsuario";
    const ID_DATEPICKER_DATA_DE_CADASTRO = "datePickerDataDeCadastro";
    const ID_COMBOBOX_STATUS_CONTA = "comboBoxStatusConta";

    return Repository.extend("mtgdeckbuilder.app.jogador.ListagemJogador", {

        formatter: formatter,

        onInit: function () {
            this.obterTodosJogadores();
        },

        obterTodosJogadores: async function () {
            await this.obterTodos(NOME_DO_MODELO);
        },

        aoPressionarBotaoFiltros: function (oEvent) {

            if (this.getView().byId("toggleFiltros").getPressed()) {
                this.aplicarFiltros();
            } else {
                this.limparFiltros();
            }
        },

        aplicarFiltros: async function () {

            let nomeUsuario = this.getView().byId(ID_CAMPO_BUSCAR_POR_USUARIO).getValue();

            let dataDeCadastroFormatada = this.getView().byId(ID_DATEPICKER_DATA_DE_CADASTRO).getValue();

            let statusConta = this.getView().byId(ID_COMBOBOX_STATUS_CONTA).getValue() == 0 ? "" : (this.getView().byId(ID_COMBOBOX_STATUS_CONTA).getValue() == "Conta ativa" ? "true" : "false");

            var filtros = "";

            filtros = nomeUsuario.length == 0 ? filtros + "" : "usuarioJogador=" + nomeUsuario;

            filtros = dataDeCadastroFormatada.length == 0 ? filtros + "" : (filtros.length == 0 ? filtros + "dataDeCriacaoContaJogador=" + dataDeCadastroFormatada : filtros + "&dataDeCriacaoContaJogador=" + dataDeCadastroFormatada);

            filtros = statusConta.length == 0 ? filtros + "" : (filtros.length == 0 ? filtros + "contaAtivaJogador=" + statusConta : filtros + "&contaAtivaJogador=" + statusConta);

            await this.obterTodosFiltros(filtros, NOME_DO_MODELO);

            this.removerValoresDosFiltros();
        },

        limparFiltros: async function () {

            await this.obterTodosJogadores();

        },

        removerValoresDosFiltros: function (){

            let nomeUsuario = this.getView().byId(ID_CAMPO_BUSCAR_POR_USUARIO).setValue();
            let dataDeCadastro = this.getView().byId(ID_DATEPICKER_DATA_DE_CADASTRO).setValue();
            let statusConta = this.getView().byId(ID_COMBOBOX_STATUS_CONTA).setValue();
        }
    });
});