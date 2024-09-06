sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "sap/ui/model/json/JSONModel",
    "mtgdeckbuilder/app/comum/Repository",
    "mtgdeckbuilder/app/model/formatter",
], function (BaseController, JSONModel, Repository, formatter) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.CriacaoJogador";
    const NOME_DO_MODELO_DE_CRIACAO_JOGADOR = "JogadorCriacao";
    const STRING_VAZIA = "";
    const ID_NOME_JOGADOR_INPUT = "idNomeJogadorInput";
    const ID_SOBRENOME_JOGADOR_INPUT = "idSobrenomeJogadorInput";
    const ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT = "idDataDeNascimentoJogadorInput";
    const ID_USUARIO_JOGADOR_INPUT = "idUsuarioJogadorInput";
    const ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT = "idUsuarioConfirmacaoJogadorInput";
    const ID_SENHA_JOGADOR_INPUT = "idSenhaHashJogadorInput";
    const ID_SENHA_CONFIRMACAO_JOGADOR_INPUT = "idSenhaHashConfirmacaoJogadorInput";

    return BaseController.extend(CONTROLLER, {

        onInit: function () {
        },

        aoClicarCriaNovoUsuario: function(){
            debugger

            let nomeJogadorInput = this.getView().byId(ID_NOME_JOGADOR_INPUT).getValue();
            let sobreNomeJogadornomeJogadorInput = this.getView().byId(ID_SOBRENOME_JOGADOR_INPUT).getValue();
            let dataDeNascimentoJogadorInput = this.getView().byId(ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT).getValue();
            let usuarioJogadorInput = this.getView().byId(ID_USUARIO_JOGADOR_INPUT).getValue();
            let usuarioConfirmacaoJogadorInput = this.getView().byId(ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT).getValue();
            let senhaHashJogadorInput = this.getView().byId(ID_SENHA_JOGADOR_INPUT).getValue();
            let senhaHashConfirmacaoJogadorInput = this.getView().byId(ID_SENHA_CONFIRMACAO_JOGADOR_INPUT).getValue();

            let modeloFiltros = new JSONModel(
                {
                    nomeJogador: nomeJogadorInput,
                    sobreNomeJogador: sobreNomeJogadornomeJogadorInput,
                    dataDeNascimentoJogador: dataDeNascimentoJogadorInput,
                    usuarioJogador: usuarioJogadorInput,
                    usuarioConfirmacaoJogador: usuarioConfirmacaoJogadorInput,
                    senhaHashJogador: senhaHashJogadorInput,
                    senhaHashConfirmacaoJogador: senhaHashConfirmacaoJogadorInput
                }
            );

            this.getView().setModel(modeloFiltros, NOME_DO_MODELO_DE_CRIACAO_JOGADOR);

            let dadosJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData();

            //Repository.Criar(dadosJogador);
        },

        aoPressionarRetornarNavegacao: function(){
            const rota = "listagemJogador";
            return this.navegarPara(rota);
        }
    });
});