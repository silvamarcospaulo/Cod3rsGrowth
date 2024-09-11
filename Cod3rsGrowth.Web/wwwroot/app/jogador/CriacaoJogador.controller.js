sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "sap/ui/model/json/JSONModel",
    "mtgdeckbuilder/app/comum/Repository",
    "mtgdeckbuilder/app/model/validador",
    "sap/ui/core/ValueState",
    "sap/ui/core/library",
    "sap/m/Dialog",
    "sap/m/Button",
    "sap/m/library",
    "sap/m/Text"
], function (BaseController, JSONModel, Repository, validador, ValueState,
    coreLibrary, Dialog, Button, mobileLibrary, Text) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.CriacaoJogador";
    const ID_CRIACAO_JOGADOR = "criacaoJogador";
    const NOME_DO_MODELO_DE_CRIACAO_JOGADOR = "JogadorCriacao";
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
    const i18n = "i18n";
    const valueStateDeErro = "Error";
    const ID_I18N_NOME_OBRIGATORIO = "CriacaoJogador.MessageToast.NomeObrigatorio";
    const ID_I18N_SOBRENOME_OBRIGATORIO = "CriacaoJogador.MessageToast.SobrenomeObrigatorio";
    const ID_I18N_DATA_NASCIMENTO_OBRIGATORIO = "CriacaoJogador.MessageToast.DataDeNascimentoObrigatorio";
    const ID_I18N_DATA_NASCIMENTO_MAIOR_QUE_TREZE_ANOS = "CriacaoJogador.MessageToast.DataNascimentoMaiorQueTrezeAnos";
    const ID_I18N_USUARIO_OBRIGATORIO = "CriacaoJogador.MessageToast.UsuarioObrigatorio";
    const ID_I18N_USUARIO_INVALIDO = "CriacaoJogador.MessageToast.UsuarioInvalido";
    const ID_I18N_CONFIRMACAO_USUARIO_INCORRETA = "CriacaoJogador.MessageToast.ConfirmacaoUsuarioIncorreta";
    const ID_I18N_SENHA_OBRIGATORIO = "CriacaoJogador.MessageToast.SenhaObrigatorio";
    const ID_I18N_SENHA_INVALIDA = "CriacaoJogador.MessageToast.SenhaInvalida";
    const ID_I18N_CONFIRMACAO_SENHA_INCORRETA = "CriacaoJogador.MessageToast.ConfirmacaoSenhaIncorreta";


    let MENSAGENS_DE_ERRO;

    return BaseController.extend(CONTROLLER, {

        onInit: function () {
            this.getRouter().getRoute(ID_CRIACAO_JOGADOR).attachPatternMatched(async () => {
                return this.aoCoincidirRota();
            }, this)
        },

        aoCoincidirRota: function () {
            this.processarAcao(async () => {
                await Promise.all([
                ])
            })
        },

        aoClicarCriaNovoUsuario: async function () {
            let nomeJogadorInput = this.getView().byId(ID_NOME_JOGADOR_INPUT).getValue();
            let sobrenomeJogadornomeJogadorInput = this.getView().byId(ID_SOBRENOME_JOGADOR_INPUT).getValue();
            let dataNascimentoJogadorInput = new Date(this.getView().byId(ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT).getValue());
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

            const tituloCaixaDeDialogoDeErro = this.getView().getModel(i18n).getResourceBundle().getText("CriacaoJogador.MessageToast.TituloCaixaDeDialogoErro");
            const estadoDoDialogoDeErro = ValueState.Error;

            if (this.validarJogador()) {
                let requisicao = await Repository.criar(jogadorCriacao, ROLE_JOGADOR);
                if (requisicao.ok) {
                    const tituloCaixaDeDialogoDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText("CriacaoJogador.MessageToast.TituloCaixaDeDialogoSucesso");
                    const estadoDoDialogoDeSucesso = ValueState.Success;
                    const mensagemDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText("CriacaoJogador.MessageToast.MensagemDeSucesso");
                    this.abrirDialogo(tituloCaixaDeDialogoDeSucesso, mensagemDeSucesso, estadoDoDialogoDeSucesso);
                } else {
                    let mensagemDeErro = {
                        title: requisicao.Title,
                        status: requisicao.Status,
                        type: requisicao.Type,
                        details: requisicao.Detail
                    };

                    let mensagemFormatada =
                        "Título: " + mensagemDeErro.title + "\n" +
                        "Status: " + mensagemDeErro.status + "\n" +
                        "Tipo: " + mensagemDeErro.type + "\n" +
                        "Detalhes: " + mensagemDeErro.details;

                    this.abrirDialogo(tituloCaixaDeDialogoDeErro, mensagemFormatada, estadoDoDialogoDeErro);
                }
            }
        },

        validarJogador: function () {
            MENSAGENS_DE_ERRO = "";

            let nomeValido = this.validarNomeJogador();
            let sobrenomeValido = this.validarSobrenomeJogador();
            let dataNascimentoValido = this.validarDataDeNascimentoJogador();
            let usuarioValido = this.validarUsuarioJogador();
            let confirmacaoUsuarioValido = this.validarConfirmacaoUsuarioJogador();
            let senhaValida = this.validarSenhaJogador();
            let confirmacaoSenhaValida = this.validarConfirmacaoSenhaJogador();

            if (MENSAGENS_DE_ERRO) {
                let tituloCaixaDeDialogoDeErro = this.getView().getModel(i18n).getResourceBundle().getText("CriacaoJogador.MessageToast.TituloCaixaDeDialogoErro");
                let estadoDoDialogoDeErro = ValueState.Error;
                this.abrirDialogo(tituloCaixaDeDialogoDeErro, MENSAGENS_DE_ERRO, estadoDoDialogoDeErro);
            }

            return nomeValido && sobrenomeValido && dataNascimentoValido && usuarioValido &&
                confirmacaoUsuarioValido && senhaValida && confirmacaoSenhaValida;
        },

        abrirDialogo: function (tituloCaixaDeDialogo, mensagem, estadoDoDialogo) {
            var ButtonType = mobileLibrary.ButtonType;
            var DialogType = mobileLibrary.DialogType;

            debugger
            let botaoCaixaDeDialogo = this.getView().getModel(i18n).getResourceBundle().getText("CriacaoJogador.MessageToast.BotaoFecharCaixaDeDialogo");
            let botao;

            if (estadoDoDialogo === ValueState.Error) {
                botao = new Button({
                    type: ButtonType.Emphasized,
                    text: "OK",
                    press: function () {
                        this.oErrorMessageDialog.close();
                    }.bind(this)
                })
            } else {
                botao = new Button({
                    type: ButtonType.Emphasized,
                    text: "OK",
                    press: function () {
                        this.aoPressionarRetornarNavegacao();
                    }.bind(this)
                });
            }

            this.oErrorMessageDialog = new Dialog({
                type: DialogType.Message,
                title: tituloCaixaDeDialogo,
                state: estadoDoDialogo,
                content: new Text({ text: mensagem }),
                beginButton: botao
            });

            this.oErrorMessageDialog.open();
        },

        validarNomeJogador: function () {
            let nomeJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().nomeJogador;
            if (!validador.validarNomeESobrenomeJogador(nomeJogador)) {
                this.getView().byId(ID_NOME_JOGADOR_INPUT).setValueState(valueStateDeErro);
                MENSAGENS_DE_ERRO += this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_NOME_OBRIGATORIO);
                return false;
            } else {
                this.getView().byId(ID_NOME_JOGADOR_INPUT).setValueState();
                return true;
            }
        },

        validarSobrenomeJogador: function () {
            let sobrenomeJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().sobrenomeJogador;
            if (!validador.validarNomeESobrenomeJogador(sobrenomeJogador)) {
                this.getView().byId(ID_SOBRENOME_JOGADOR_INPUT).setValueState(valueStateDeErro);
                MENSAGENS_DE_ERRO += this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_SOBRENOME_OBRIGATORIO);
                return false;
            } else {
                this.getView().byId(ID_SOBRENOME_JOGADOR_INPUT).setValueState();
                return true;
            }
        },

        validarDataDeNascimentoJogador: function () {
            let dataNascimentoJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().dataNascimentoJogador;
            if (!validador.validarDataDeNascimentoJogador(dataNascimentoJogador)) {
                this.getView().byId(ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT).setValueState(valueStateDeErro);
                MENSAGENS_DE_ERRO += this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_DATA_NASCIMENTO_OBRIGATORIO);
                MENSAGENS_DE_ERRO += this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_DATA_NASCIMENTO_MAIOR_QUE_TREZE_ANOS);
                return false;
            } else {
                this.getView().byId(ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT).setValueState();
                return true;
            }
        },

        validarUsuarioJogador: function () {
            let usuarioJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().usuarioJogador;
            if (!validador.validarUsuarioJogador(usuarioJogador)) {
                this.getView().byId(ID_USUARIO_JOGADOR_INPUT).setValueState(valueStateDeErro);
                MENSAGENS_DE_ERRO += this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_USUARIO_OBRIGATORIO);
                MENSAGENS_DE_ERRO += this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_USUARIO_INVALIDO);
                return false;
            } else {
                this.getView().byId(ID_USUARIO_JOGADOR_INPUT).setValueState();
                return true;
            }
        },

        validarConfirmacaoUsuarioJogador: function () {
            let jogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData();
            if (!validador.validarConfirmacaoDeUsuarioJogador(jogador.usuarioJogador, jogador.usuarioConfirmacaoJogador)) {
                this.getView().byId(ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT).setValueState(valueStateDeErro);
                MENSAGENS_DE_ERRO += this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_CONFIRMACAO_USUARIO_INCORRETA);
                return false;
            } else {
                this.getView().byId(ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT).setValueState();
                return true;
            }
        },

        validarSenhaJogador: function () {
            let senhaJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().senhaHashJogador;
            if (!validador.validarSenhaJogador(senhaJogador)) {
                this.getView().byId(ID_SENHA_JOGADOR_INPUT).setValueState(valueStateDeErro);
                MENSAGENS_DE_ERRO += this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_SENHA_OBRIGATORIO);
                MENSAGENS_DE_ERRO += this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_SENHA_INVALIDA);
                return false;
            } else {
                this.getView().byId(ID_SENHA_JOGADOR_INPUT).setValueState();
                return true;
            }
        },

        validarConfirmacaoSenhaJogador: function () {
            let jogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData();
            if (!validador.validarConfirmacaoDeSenhaJogador(jogador.senhaHashJogador, jogador.senhaHashConfirmacaoJogador)) {
                this.getView().byId(ID_SENHA_CONFIRMACAO_JOGADOR_INPUT).setValueState(valueStateDeErro);
                MENSAGENS_DE_ERRO += this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_CONFIRMACAO_SENHA_INCORRETA);
                return false;
            } else {
                this.getView().byId(ID_SENHA_CONFIRMACAO_JOGADOR_INPUT).setValueState();
                return true;
            }
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
            this.removerValoresDosInputs();
            return this.navegarPara(rota);
        },

        removerValoresDosInputs: function () {
            let nomeJogadorInput = this.getView().byId(ID_NOME_JOGADOR_INPUT).setValue();
            let sobrenomeJogadornomeJogadorInput = this.getView().byId(ID_SOBRENOME_JOGADOR_INPUT).setValue();
            let dataNascimentoJogadorInput = this.getView().byId(ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT).setValue();
            let usuarioJogadorInput = this.getView().byId(ID_USUARIO_JOGADOR_INPUT).setValue();
            let usuarioConfirmacaoJogadorInput = this.getView().byId(ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT).setValue();
            let senhaHashJogadorInput = this.getView().byId(ID_SENHA_JOGADOR_INPUT).setValue();
            let senhaHashConfirmacaoJogadorInput = this.getView().byId(ID_SENHA_CONFIRMACAO_JOGADOR_INPUT).setValue();
        }
    });
});