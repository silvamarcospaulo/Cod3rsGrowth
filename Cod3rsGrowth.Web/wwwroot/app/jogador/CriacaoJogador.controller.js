sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "sap/ui/model/json/JSONModel",
    "mtgdeckbuilder/app/comum/Repository",
    "mtgdeckbuilder/app/model/validador"
], function (BaseController, JSONModel, Repository, validador) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.CriacaoJogador";
    const ID_CRIACAO_JOGADOR = "criacaoJogador";
    const NOME_DO_MODELO_DE_CRIACAO_JOGADOR = "JogadorCriacao";
    const STRING_VAZIA = "";
    const ROLE_JOGADOR = "Jogador";
    const ID_NOME_JOGADOR_INPUT = "idNomeJogadorInput";
    const ID_SOBRENOME_JOGADOR_INPUT = "idSobrenomeJogadorInput";
    const ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT = "idDataDeNascimentoJogadorInput";
    const ID_USUARIO_JOGADOR_INPUT = "idUsuarioJogadorInput";
    const ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT = "idUsuarioConfirmacaoJogadorInput";
    const ID_SENHA_JOGADOR_INPUT = "idSenhaHashJogadorInput";
    const ID_SENHA_CONFIRMACAO_JOGADOR_INPUT = "idSenhaHashConfirmacaoJogadorInput";
    const ID_BOTAO_MOSTRAR_SENHA = "idBotaoMostrarSenha";
    const ID_BOTAO_MOSTRAR_CONFIRMACAO_DE_SENHA = "idBotaoMostrarConfirmacaoDeSenha";
    const ICONE_BOTAO_MOTRAR_SENHA = "sap-icon://show";
    const ICONE_BOTAO_ESCONDER_SENHA = "sap-icon://hide";
    const TIPO_DE_INPUT_SENHA = "Password";
    const TIPO_DE_INPUT_TEXTO = "Text";

    return BaseController.extend(CONTROLLER, {

        onInit: function () {
            this.getRouter().getRoute(ID_CRIACAO_JOGADOR).attachPatternMatched(async () => {
                return this.aoCoincidirRota();
            }, this)
        },

        aoCoincidirRota: function() {
            this.processarAcao(async () => {
                await Promise.all([
                ])
            })
        },

        aoClicarCriaNovoUsuario: function () {
            let nomeJogadorInput = this.getView().byId(ID_NOME_JOGADOR_INPUT).getValue();
            let sobrenomeJogadornomeJogadorInput = this.getView().byId(ID_SOBRENOME_JOGADOR_INPUT).getValue();
            let dataNascimentoJogadorInput = this.getView().byId(ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT).getValue();
            let usuarioJogadorInput = this.getView().byId(ID_USUARIO_JOGADOR_INPUT).getValue();
            let usuarioConfirmacaoJogadorInput = this.getView().byId(ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT).getValue();
            let senhaHashJogadorInput = this.getView().byId(ID_SENHA_JOGADOR_INPUT).getValue();
            let senhaHashConfirmacaoJogadorInput = this.getView().byId(ID_SENHA_CONFIRMACAO_JOGADOR_INPUT).getValue();


            let modeloJogadorCriacao = new JSONModel(
                {
                    role: ROLE_JOGADOR,
                    nomeJogador: nomeJogadorInput,
                    sobrenomeJogador: sobrenomeJogadornomeJogadorInput,
                    dataNascimentoJogador: dataNascimentoJogadorInput,
                    usuarioJogador: usuarioJogadorInput,
                    usuarioConfirmacaoJogador: usuarioConfirmacaoJogadorInput,
                    senhaHashJogador: senhaHashJogadorInput,
                    senhaHashConfirmacaoJogador: senhaHashConfirmacaoJogadorInput
               }
           );
               
           this.getView().setModel(modeloJogadorCriacao, NOME_DO_MODELO_DE_CRIACAO_JOGADOR);

           let dadosJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData();

            let jogadorCriacao = JSON.stringify(dadosJogador);
            
            if (this.validarJogador()){
                Repository.criar(jogadorCriacao, ROLE_JOGADOR);
            }else{
                
            }
        },

        validarJogador: function(){
            let jogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData();
            let jogadorValidado = true;

            debugger
            if () validador.validarNomeJogador(jogador.nomeJogador) ? true : this.getView().byId(ID_NOME_JOGADOR_INPUT).setValueStateText("Campo obrigatório!");
        },

        aoPressionarMudaAVisualizacaoDeSenha: function () {
            this.mudaVisualizacaoDoInput(ID_SENHA_JOGADOR_INPUT, ID_BOTAO_MOSTRAR_SENHA);
        },

        aoPressionarMudaAVisualizacaoDeConfirmacaoDeSenha: function () {
            this.mudaVisualizacaoDoInput(ID_SENHA_CONFIRMACAO_JOGADOR_INPUT, ID_BOTAO_MOSTRAR_CONFIRMACAO_DE_SENHA);
        },

        mudaVisualizacaoDoInput: function (idDoInput, idDoBotao) {
            let tipoDoInputAtual = this.getView().byId(idDoInput).getType();
            var tipoDoInputAtualizado = tipoDoInputAtual === TIPO_DE_INPUT_SENHA ? TIPO_DE_INPUT_TEXTO : TIPO_DE_INPUT_SENHA;
            this.getView().byId(idDoInput).setType(tipoDoInputAtualizado);

            let iconeDoBotaoAtual = this.getView().byId(idDoBotao).getIcon();
            var iconeDoBotaoAtualizado = iconeDoBotaoAtual === ICONE_BOTAO_MOTRAR_SENHA ? ICONE_BOTAO_ESCONDER_SENHA : ICONE_BOTAO_MOTRAR_SENHA;
            this.getView().byId(idDoBotao).setIcon(iconeDoBotaoAtualizado);
        },

        aoPressionarRetornarNavegacao: function () {
            const rota = "listagemJogador";
            return this.navegarPara(rota);
        }
    });
});