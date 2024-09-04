sap.ui.define([
    "mtgdeckbuilder/app/comum/Repository",
    "mtgdeckbuilder/app/model/formatter"
], function (Repository, formatter) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.ListagemJogador"
    const NOME_DO_MODELO = "Jogador";
    const ID_CAMPO_BUSCAR_POR_USUARIO = "campoBuscaUsuario";
    const ID_DATEPICKER_DATA_DE_CADASTRO = "datePickerDataDeCadastro";
    const ID_COMBOBOX_STATUS_CONTA = "comboBoxStatusConta";
    const VALOR_NULO = 0;
    const STRING_VAZIA = "";

    return Repository.extend(CONTROLLER, {

        formatter: formatter,

        onInit: function () {
            this.obterTodosJogadores();
        },

        obterTodosJogadores: async function () {

            await this.obterTodos(STRING_VAZIA, NOME_DO_MODELO);
        },

        aoPressionarAplicarFiltros: async function () {

            const nomeUsuario = this.getView().byId(ID_CAMPO_BUSCAR_POR_USUARIO).getValue();

            const dataDeCadastro = this.getView().byId(ID_DATEPICKER_DATA_DE_CADASTRO).getValue();

            const statusConta = this.getView().byId(ID_COMBOBOX_STATUS_CONTA).getSelectedKey();

            const filtros = {};

            if (nomeUsuario) filtros.usuarioJogador = nomeUsuario;
            if (dataDeCadastro) filtros.dataDeCriacaoContaJogador = dataDeCadastro;
            if (statusConta) filtros.contaAtivaJogador = statusConta;

            await this.obterTodos(filtros, NOME_DO_MODELO);

            this.removerValoresDosFiltros();
        },

        removerValoresDosFiltros: function () {

            let nomeUsuario = this.getView().byId(ID_CAMPO_BUSCAR_POR_USUARIO).setValue();
            let dataDeCadastro = this.getView().byId(ID_DATEPICKER_DATA_DE_CADASTRO).setValue();
            let statusConta = this.getView().byId(ID_COMBOBOX_STATUS_CONTA).setSelectedKey();

        }
    });
});