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
], function (BaseController, JSONModel, Repository, validador,
    ValueState, coreLibrary, Dialog, Button, mobileLibrary, Text) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.CriacaoJogador";
    const ID_LISTAGEM_JOGADOR = "listagemJogador";
    const ID_CRIACAO_JOGADOR = "criacaoJogador";
    const ID_EDICAO_JOGADOR = "edicaoJogador";
    const ID_DETALHES_JOGADOR = "detalhesJogador";
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
    const ID_I18N_TITULO_CAIXA_DE_DIALOGO_SUCESSO = "CriacaoJogador.MessageToast.TituloCaixaDeDialogoSucesso";
    const ID_I18N_TEXTO_CAIXA_DE_DIALOGO_SUCESSO = "CriacaoJogador.MessageToast.MensagemDeSucesso";
    const ID_I18N_TITULO_CAIXA_DE_DIALOGO_ERRO = "CriacaoJogador.MessageToast.TituloCaixaDeDialogoErro"
    const ID_I18N_NOME_OBRIGATORIO = "CriacaoJogador.MessageToast.NomeObrigatorio";
    const ID_I18N_NOME_COM_CARACTERES_INVALIDOS = "CriacaoJogador.MessageToast.NomeComCaracteresInvalidos";
    const ID_I18N_SOBRENOME_OBRIGATORIO = "CriacaoJogador.MessageToast.SobrenomeObrigatorio";
    const ID_I18N_SOBRENOME_COM_CARACTERES_INVALIDOS = "CriacaoJogador.MessageToast.SobrenomeComCaracteresInvalidos";
    const ID_I18N_DATA_NASCIMENTO_OBRIGATORIO = "CriacaoJogador.MessageToast.DataNascimentoObrigatorio";
    const ID_I18N_DATA_NASCIMENTO_MAIOR_QUE_TREZE_ANOS = "CriacaoJogador.MessageToast.DataNascimentoMaiorQueTrezeAnos";
    const ID_I18N_USUARIO_OBRIGATORIO = "CriacaoJogador.MessageToast.UsuarioObrigatorio";
    const ID_I18N_USUARIO_INVALIDO = "CriacaoJogador.MessageToast.UsuarioInvalido";
    const ID_I18N_CONFIRMACAO_USUARIO_INCORRETA = "CriacaoJogador.MessageToast.ConfirmacaoUsuarioIncorreta";
    const ID_I18N_SENHA_OBRIGATORIO = "CriacaoJogador.MessageToast.SenhaObrigatorio";
    const ID_I18N_SENHA_INVALIDA = "CriacaoJogador.MessageToast.SenhaInvalida";
    const ID_I18N_CONFIRMACAO_SENHA_INCORRETA = "CriacaoJogador.MessageToast.ConfirmacaoSenhaIncorreta";
    const QUEBRA_DE_LINHA = "\n";
    const REQUISICAO = "Jogador";
    const NOME_DO_MODELO_DE_JOGADOR_SELECIONADO = "JogadorSelecionado";
    let MENSAGENS_DE_ERRO;

    return BaseController.extend(CONTROLLER, {

        onInit: function () {
            this.getRouter().getRoute(ID_CRIACAO_JOGADOR).attachPatternMatched(async () => {
                return this.aoCoincidirRota();
            }, this)
            this.getRouter().getRoute(ID_EDICAO_JOGADOR).attachPatternMatched(async (evento) => {
                return this.aoCoincidirRota(evento);
            }, this)
        },

        aoCoincidirRota: function (evento) {
            let propriedadesEvento = "arguments";
            let idJogador = evento.getParameter(propriedadesEvento).id;
            this.processarAcao(async () => {
                await Promise.all([
                    Repository.obterPorId(this.getView(), idJogador, REQUISICAO, NOME_DO_MODELO_DE_JOGADOR_SELECIONADO),
                ])
            })
        },

        aoClicarCriaNovoUsuario: async function () {

            this.ObterDadosDosInputs();
            let dadosJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData();
            let jogadorCriacao = JSON.stringify(dadosJogador);

            if (this.validarJogador()) {
                debugger
                const requisicao = await Repository.criar(jogadorCriacao, ROLE_JOGADOR);

                if (requisicao.ok) {
                    let objetoRequisicao = await requisicao.json();
                    Repository.obterPorId(this.getView(), objetoRequisicao.id, REQUISICAO, NOME_DO_MODELO_DE_JOGADOR_SELECIONADO);
                    const tituloCaixaDeDialogoDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TITULO_CAIXA_DE_DIALOGO_SUCESSO);
                    const estadoDoDialogoDeSucesso = ValueState.Success;
                    const mensagemDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TEXTO_CAIXA_DE_DIALOGO_SUCESSO);

                    this.abrirDialogo(tituloCaixaDeDialogoDeSucesso, mensagemDeSucesso, estadoDoDialogoDeSucesso);
                } else {
                    let mensagemDeErro = this.criarObjetoDeMensagemDeErroRFC(requisicao);

                    const tituloCaixaDeDialogoDeErro = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TITULO_CAIXA_DE_DIALOGO_ERRO);
                    const estadoDoDialogoDeErro = ValueState.Error;

                    this.abrirDialogo(tituloCaixaDeDialogoDeErro, mensagemDeErro, estadoDoDialogoDeErro);
                }
            }
        },

        criarObjetoDeMensagemDeErroRFC: function (requisicao) {
            let mensagemDeErro = {
                title: requisicao.Title,
                status: requisicao.Status,
                type: requisicao.Type,
                details: requisicao.Detail
            };

            let regex = /at .*/s;
            let detalhesLimpos = mensagemDeErro.details.replace(regex, '').trim();

            detalhesLimpos = detalhesLimpos.replace(/(\r?\n\s*){2,}/g, '\n\n').trim();

            let mensagemFormatada =
                "Título: " + mensagemDeErro.title + "\n" +
                "Status: " + mensagemDeErro.status + "\n" +
                "Tipo: " + mensagemDeErro.type + "\n" +
                "Detalhes: " + detalhesLimpos;

            return mensagemFormatada;
        },

        ObterDadosDosInputs: function () {
            let nomeJogadorInput = this.getView().byId(ID_NOME_JOGADOR_INPUT).getValue();
            let sobrenomeJogadornomeJogadorInput = this.getView().byId(ID_SOBRENOME_JOGADOR_INPUT).getValue();
            let dataNascimentoJogadorInput = this.getView().byId(ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT).getDateValue();
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
        },

        validarJogador: function () {
            MENSAGENS_DE_ERRO = "";

            let nomeJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().nomeJogador;
            let nomePossuiSomenteLetrasMaiusculasEMenusculas = this.aplicarValidacao(validador.validarSeCampoPossuiSomenteLetrasMaiusculasEMinusculas(nomeJogador), ID_NOME_JOGADOR_INPUT, ID_I18N_NOME_COM_CARACTERES_INVALIDOS);
            let nomeNaoENulo = this.aplicarValidacao(validador.validarSeCampoPossuiValor(nomeJogador), ID_NOME_JOGADOR_INPUT, ID_I18N_NOME_OBRIGATORIO);

            let sobrenomeJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().sobrenomeJogador;
            let sobrenomePossuiSomenteLetrasMaiusculasEMenusculas = this.aplicarValidacao(validador.validarSeCampoPossuiSomenteLetrasMaiusculasEMinusculas(sobrenomeJogador), ID_SOBRENOME_JOGADOR_INPUT, ID_I18N_SOBRENOME_COM_CARACTERES_INVALIDOS);
            let sobrenomeNaoENulo = this.aplicarValidacao(validador.validarSeCampoPossuiValor(sobrenomeJogador), ID_SOBRENOME_JOGADOR_INPUT, ID_I18N_SOBRENOME_OBRIGATORIO);

            let dataNascimentoJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().dataNascimentoJogador;
            let dataNascimentoMaiorQueTrezeAnos = this.aplicarValidacao(validador.validarSeJogadorEMaiorQueTrezeAnos(dataNascimentoJogador), ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT, ID_I18N_DATA_NASCIMENTO_MAIOR_QUE_TREZE_ANOS);
            let dataNascimentoNaoENulo = this.aplicarValidacao(validador.validarSeCampoPossuiValor(dataNascimentoJogador), ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT, ID_I18N_DATA_NASCIMENTO_OBRIGATORIO);

            let usuarioJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().usuarioJogador;
            let usuarioPossuiAoMenosSeisDigitos = this.aplicarValidacao(validador.validarUsuarioPossuiAoMenosSeisDigitos(usuarioJogador), ID_USUARIO_JOGADOR_INPUT, ID_I18N_USUARIO_INVALIDO);
            let usuarioPossuiSomenteLetrasMinusculas = this.aplicarValidacao(validador.validarCaracteresUsuarioJogador(usuarioJogador), ID_USUARIO_JOGADOR_INPUT, ID_I18N_USUARIO_INVALIDO);
            let usuarioNaoENulo = this.aplicarValidacao(validador.validarSeCampoPossuiValor(usuarioJogador), ID_USUARIO_JOGADOR_INPUT, ID_I18N_USUARIO_OBRIGATORIO);

            let usuarioConfirmacaoJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().usuarioConfirmacaoJogador;
            let usuarioEConfirmacaoCompativeis = this.aplicarValidacao(validador.validarSeOsValoresDosCamposSaoIguais(usuarioJogador, usuarioConfirmacaoJogador), ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT, ID_I18N_CONFIRMACAO_USUARIO_INCORRETA);

            let senhaJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().senhaHashJogador;
            let senhaPossuiAoMenosOitoDigitos = this.aplicarValidacao(validador.validarSenhaPossuiAoMenosOitoDigitos(senhaJogador), ID_SENHA_JOGADOR_INPUT, ID_I18N_SENHA_INVALIDA);
            let senhaAoMenosUmaLetraMaiusculasUmaLetraMinusculaEUmNumero = this.aplicarValidacao(validador.validarSenhaPossuiOsCaracteresNecessarios(senhaJogador), ID_SENHA_JOGADOR_INPUT, ID_I18N_SENHA_INVALIDA);
            let senhaNaoENulo = this.aplicarValidacao(validador.validarSeCampoPossuiValor(senhaJogador), ID_SENHA_JOGADOR_INPUT, ID_I18N_SENHA_OBRIGATORIO);

            let senhaHashConfirmacaoJogador = this.getView().getModel(NOME_DO_MODELO_DE_CRIACAO_JOGADOR).getData().senhaHashConfirmacaoJogador;
            let senhaEConfirmacaoCompativeis = this.aplicarValidacao(validador.validarSeOsValoresDosCamposSaoIguais(senhaJogador, senhaHashConfirmacaoJogador), ID_SENHA_CONFIRMACAO_JOGADOR_INPUT, ID_I18N_CONFIRMACAO_SENHA_INCORRETA);

            if (MENSAGENS_DE_ERRO) {
                let tituloCaixaDeDialogoDeErro = this.getView().getModel(i18n).getResourceBundle().getText("CriacaoJogador.MessageToast.TituloCaixaDeDialogoErro");
                let estadoDoDialogoDeErro = ValueState.Error;
                this.abrirDialogo(tituloCaixaDeDialogoDeErro, MENSAGENS_DE_ERRO, estadoDoDialogoDeErro);
            }

            return nomeNaoENulo && nomePossuiSomenteLetrasMaiusculasEMenusculas
                && sobrenomeNaoENulo && sobrenomePossuiSomenteLetrasMaiusculasEMenusculas
                && dataNascimentoNaoENulo && dataNascimentoMaiorQueTrezeAnos
                && usuarioNaoENulo && usuarioPossuiAoMenosSeisDigitos
                && usuarioPossuiSomenteLetrasMinusculas && usuarioEConfirmacaoCompativeis
                && senhaNaoENulo && senhaPossuiAoMenosOitoDigitos
                && senhaAoMenosUmaLetraMaiusculasUmaLetraMinusculaEUmNumero && senhaEConfirmacaoCompativeis;
        },

        aplicarValidacao: function (validacao, idInput, idI18n) {
            debugger
            if (!validacao) {
                this.getView().byId(idInput).setValueState(valueStateDeErro);
                MENSAGENS_DE_ERRO += this.getView().getModel(i18n).getResourceBundle().getText(idI18n) + QUEBRA_DE_LINHA;
                return false;
            } else {
                this.getView().byId(idInput).setValueState();
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
            let tipoDoInputAtualizado = tipoDoInputAtual === TIPO_DE_INPUT_SENHA ? TIPO_DE_INPUT_TEXTO : TIPO_DE_INPUT_SENHA;
            this.getView().byId(idDoInput).setType(tipoDoInputAtualizado);

            let iconeDoBotaoAtual = this.getView().byId(idDoBotao).getIcon();
            let iconeDoBotaoAtualizado = iconeDoBotaoAtual === ICONE_BOTAO_MOTRAR_SENHA ? ICONE_BOTAO_ESCONDER_SENHA : ICONE_BOTAO_MOTRAR_SENHA;
            this.getView().byId(idDoBotao).setIcon(iconeDoBotaoAtualizado);
        },

        aoPressionarRetornarNavegacao: function () {
            this.removerValoresDosInputs();
            this.removerValueStates();
            if (this.getRouter().oHashChanger.hash.includes(ID_CRIACAO_JOGADOR)) {
                return this.navegarPara(ID_LISTAGEM_JOGADOR);
            }

            this.navegarParaDetalhes();
        },

        navegarParaDetalhes: function () {
            this.removerValoresDosInputs();
            this.removerValueStates();
            let idJogador = this.getView().getModel(NOME_DO_MODELO_DE_JOGADOR_SELECIONADO).getData().id;
            return this.navegarPara(ID_DETALHES_JOGADOR, idJogador);
        },

        removerValoresDosInputs: function () {
            this.getView().byId(ID_NOME_JOGADOR_INPUT).setValue();
            this.getView().byId(ID_SOBRENOME_JOGADOR_INPUT).setValue();
            this.getView().byId(ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT).setValue();
            this.getView().byId(ID_USUARIO_JOGADOR_INPUT).setValue();
            this.getView().byId(ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT).setValue();
            this.getView().byId(ID_SENHA_JOGADOR_INPUT).setValue();
            this.getView().byId(ID_SENHA_CONFIRMACAO_JOGADOR_INPUT).setValue();
        },

        removerValueStates: function () {
            this.getView().byId(ID_NOME_JOGADOR_INPUT).setValueState();
            this.getView().byId(ID_SOBRENOME_JOGADOR_INPUT).setValueState();
            this.getView().byId(ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT).setValueState();
            this.getView().byId(ID_USUARIO_JOGADOR_INPUT).setValueState();
            this.getView().byId(ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT).setValueState();
            this.getView().byId(ID_SENHA_JOGADOR_INPUT).setValueState();
            this.getView().byId(ID_SENHA_CONFIRMACAO_JOGADOR_INPUT).setValueState();
        },

        abrirDialogo: function (tituloCaixaDeDialogo, mensagem, estadoDoDialogo) {
            let ButtonType = mobileLibrary.ButtonType;
            let DialogType = mobileLibrary.DialogType;
            let botaoCaixaDeDialogo = this.getView().getModel(i18n).getResourceBundle().getText("CriacaoJogador.MessageToast.BotaoFecharCaixaDeDialogo");
            let botao;

            if (estadoDoDialogo === ValueState.Error) {
                botao = new Button({
                    type: ButtonType.Emphasized,
                    text: botaoCaixaDeDialogo,
                    press: function () {
                        this.oErrorMessageDialog.close();
                    }.bind(this)
                })
            } else {
                botao = new Button({
                    type: ButtonType.Emphasized,
                    text: botaoCaixaDeDialogo,
                    press: function () {
                        this.navegarParaDetalhes();
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
    });
});