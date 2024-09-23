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
    "sap/m/Text",
    "mtgdeckbuilder/app/model/formatter",
], function (BaseController, JSONModel, Repository, validador,
    ValueState, coreLibrary, Dialog, Button, mobileLibrary, Text, formatter) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.CriacaoJogador";
    const ID_LISTAGEM_JOGADOR = "listagemJogador";
    const ID_CRIACAO_JOGADOR = "criacaoJogador";
    const ID_EDICAO_JOGADOR = "edicaoJogador";
    const ID_DETALHES_JOGADOR = "detalhesJogador";
    const NOME_DO_MODELO_DE_REQUISICAO_JOGADOR = "JogadorRequisicao";
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
    const ID_I18N_TITULO_CAIXA_DE_DIALOGO_SUCESSO = "CriacaoJogador.MessageToast.TituloCaixaDeDialogoSucesso";
    const ID_I18N_TEXTO_CAIXA_DE_DIALOGO_CRIACAO_SUCESSO = "CriacaoJogador.MessageToast.MensagemDeSucessoCriacao";
    const ID_I18N_TEXTO_CAIXA_DE_DIALOGO_EDICAO_SUCESSO = "CriacaoJogador.MessageToast.MensagemDeSucessoEdicao";
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

    return BaseController.extend(CONTROLLER, {

        formatter: formatter,
        ID_JOGADOR: null,
        MENSAGENS_DE_ERRO: null,

        onInit: function () {
            this.getRouter().getRoute(ID_EDICAO_JOGADOR).attachPatternMatched(async (evento) => {
                return this.aoCoincidirRotaEdicao(evento);
            }, this)
            this.getRouter().getRoute(ID_CRIACAO_JOGADOR).attachPatternMatched(async () => {
                return this.aoCoincidirRotaCriacao();
            }, this)
        },

        aoCoincidirRotaEdicao: function (evento) {
            let propriedadesEvento = "arguments";
            this.ID_JOGADOR = evento.getParameter(propriedadesEvento).id;
            this.processarAcao(async () => {
                await Promise.all([
                    Repository.obterPorId(this.getView(), this.ID_JOGADOR, REQUISICAO, NOME_DO_MODELO_DE_REQUISICAO_JOGADOR),
                    this.criaModeloDeStringsI18n(),
                    this.removerPropriedadeEdicaoDoCampo()
                ])
            });
        },

        aoCoincidirRotaCriacao: function () {
            this.processarAcao(async () => {
                await Promise.all([
                    this.criaModeloDeStringsI18n()
                ])
            });
        },

        aoClicarPrecessaAcao: function () {
            if (this.ID_JOGADOR) {
                this.aoClicarAtualizaUsuario();
            } else {
                this.aoClicarCriaNovoUsuario();
            }
        },

        aoClicarAtualizaUsuario: async function () {
            this.ObterDadosDosInputs();
            let dadosJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData();
            let jogadorEdicao = JSON.stringify(dadosJogador);

            if (this.validarJogadorEdicao()) {
                const requisicao = await Repository.editar(jogadorEdicao, ROLE_JOGADOR);

                if (requisicao.ok) {
                    const tituloCaixaDeDialogoDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TITULO_CAIXA_DE_DIALOGO_SUCESSO);
                    const estadoDoDialogoDeSucesso = ValueState.Success;
                    const mensagemDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TEXTO_CAIXA_DE_DIALOGO_EDICAO_SUCESSO);

                    this.abrirDialogo(tituloCaixaDeDialogoDeSucesso, mensagemDeSucesso, estadoDoDialogoDeSucesso);
                } else {
                    let mensagemDeErro = this.criarObjetoDeMensagemDeErroRFC(requisicao);

                    const tituloCaixaDeDialogoDeErro = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TITULO_CAIXA_DE_DIALOGO_ERRO);
                    const estadoDoDialogoDeErro = ValueState.Error;

                    this.abrirDialogo(tituloCaixaDeDialogoDeErro, mensagemDeErro, estadoDoDialogoDeErro);
                };
            };
        },

        aoClicarCriaNovoUsuario: async function () {
            this.ObterDadosDosInputs();
            let dadosJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData();
            let jogadorCriacao = JSON.stringify(dadosJogador);

            if (this.validarJogadorCriacao()) {
                const requisicao = await Repository.criar(jogadorCriacao, ROLE_JOGADOR);

                if (requisicao.ok) {
                    let objetoRequisicao = await requisicao.json();
                    Repository.obterPorId(this.getView(), objetoRequisicao.id, REQUISICAO, NOME_DO_MODELO_DE_REQUISICAO_JOGADOR);
                    const tituloCaixaDeDialogoDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TITULO_CAIXA_DE_DIALOGO_SUCESSO);
                    const estadoDoDialogoDeSucesso = ValueState.Success;
                    const mensagemDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TEXTO_CAIXA_DE_DIALOGO_CRIACAO_SUCESSO);

                    this.abrirDialogo(tituloCaixaDeDialogoDeSucesso, mensagemDeSucesso, estadoDoDialogoDeSucesso);
                } else {
                    let mensagemDeErro = this.criarObjetoDeMensagemDeErroRFC(requisicao);

                    const tituloCaixaDeDialogoDeErro = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TITULO_CAIXA_DE_DIALOGO_ERRO);
                    const estadoDoDialogoDeErro = ValueState.Error;

                    this.abrirDialogo(tituloCaixaDeDialogoDeErro, mensagemDeErro, estadoDoDialogoDeErro);
                };
            };
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
            let nomeJogadorInput = this.byId(ID_NOME_JOGADOR_INPUT).getValue();
            let sobrenomeJogadornomeJogadorInput = this.getView().byId(ID_SOBRENOME_JOGADOR_INPUT).getValue();
            let dataNascimentoJogadorInput = this.byId(ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT).getDateValue();
            let usuarioJogadorInput = this.byId(ID_USUARIO_JOGADOR_INPUT).getValue();
            let usuarioConfirmacaoJogadorInput = this.byId(ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT).getValue();
            let senhaHashJogadorInput = this.byId(ID_SENHA_JOGADOR_INPUT).getValue();
            let senhaHashConfirmacaoJogadorInput = this.byId(ID_SENHA_CONFIRMACAO_JOGADOR_INPUT).getValue();

            let modeloJogador;
            if (this.ID_JOGADOR) {
                modeloJogador = new JSONModel(
                    {
                        role: ROLE_JOGADOR,
                        nomeJogador: nomeJogadorInput,
                        sobrenomeJogador: sobrenomeJogadornomeJogadorInput,
                        dataNascimentoJogador: dataNascimentoJogadorInput,
                        usuarioJogador: usuarioJogadorInput,
                        usuarioConfirmacaoJogador: usuarioConfirmacaoJogadorInput,
                        senhaHashJogador: senhaHashJogadorInput,
                        senhaHashConfirmacaoJogador: senhaHashConfirmacaoJogadorInput,
                        id: this.ID_JOGADOR,
                    }
                );
            } else {
                modeloJogador = new JSONModel(
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
            }

            this.getView().setModel(modeloJogador, NOME_DO_MODELO_DE_REQUISICAO_JOGADOR);
        },

        removerPropriedadeEdicaoDoCampo: function () {
            this.getView().byId(ID_NOME_JOGADOR_INPUT).setEditable(false);
            this.getView().byId(ID_SOBRENOME_JOGADOR_INPUT).setEditable(false);
            this.getView().byId(ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT).setEditable(false);
        },

        validarJogadorEdicao: function () {
            debugger
            this.MENSAGENS_DE_ERRO = "";

            let usuarioJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().usuarioJogador;
            let usuarioConfirmacaoJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().usuarioConfirmacaoJogador;
            let usuarioPossuiAoMenosSeisDigitos = this.aplicarValidacao(validador.validarUsuarioPossuiAoMenosSeisDigitos(usuarioJogador), ID_USUARIO_JOGADOR_INPUT, ID_I18N_USUARIO_INVALIDO);
            let usuarioPossuiSomenteLetrasMinusculas = this.aplicarValidacao(validador.validarCaracteresUsuarioJogador(usuarioJogador), ID_USUARIO_JOGADOR_INPUT, ID_I18N_USUARIO_INVALIDO);
            let usuarioNaoENulo = this.aplicarValidacao(validador.validarSeCampoPossuiValor(usuarioJogador), ID_USUARIO_JOGADOR_INPUT, ID_I18N_USUARIO_OBRIGATORIO);
            let usuarioEConfirmacaoCompativeis = this.aplicarValidacao(validador.validarSeOsValoresDosCamposSaoIguais(usuarioJogador, usuarioConfirmacaoJogador), ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT, ID_I18N_CONFIRMACAO_USUARIO_INCORRETA);

            let senhaJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().senhaHashJogador;
            let senhaHashConfirmacaoJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().senhaHashConfirmacaoJogador;

            let senhaValidada = this.validarSenha(senhaJogador);
            let senhaEConfirmacaoCompativeis = this.aplicarValidacao(validador.validarSeOsValoresDosCamposSaoIguais(senhaJogador, senhaHashConfirmacaoJogador), ID_SENHA_CONFIRMACAO_JOGADOR_INPUT, ID_I18N_CONFIRMACAO_SENHA_INCORRETA);

            if (this.MENSAGENS_DE_ERRO) {
                let tituloCaixaDeDialogoDeErro = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TITULO_CAIXA_DE_DIALOGO_ERRO);
                let estadoDoDialogoDeErro = ValueState.Error;
                this.abrirDialogo(tituloCaixaDeDialogoDeErro, this.MENSAGENS_DE_ERRO, estadoDoDialogoDeErro);
            }

            return senhaValidada && usuarioPossuiAoMenosSeisDigitos && usuarioPossuiSomenteLetrasMinusculas && usuarioNaoENulo && usuarioEConfirmacaoCompativeis && senhaEConfirmacaoCompativeis;
        },

        validarSenha: function (senhaJogador) {
            debugger
            if (validador.validarSeCampoPossuiValor(senhaJogador)) {
                let senhaPossuiAoMenosOitoDigitos = this.aplicarValidacao(validador.validarSenhaPossuiAoMenosOitoDigitos(senhaJogador), ID_SENHA_JOGADOR_INPUT, ID_I18N_SENHA_INVALIDA);
                let senhaAoMenosUmaLetraMaiusculasUmaLetraMinusculaEUmNumero = this.aplicarValidacao(validador.validarSenhaPossuiOsCaracteresNecessarios(senhaJogador), ID_SENHA_JOGADOR_INPUT, ID_I18N_SENHA_INVALIDA);

                return senhaPossuiAoMenosOitoDigitos && senhaAoMenosUmaLetraMaiusculasUmaLetraMinusculaEUmNumero;
            }

            return true;
        },

        validarJogadorCriacao: function () {
            this.MENSAGENS_DE_ERRO = "";

            let nomeJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().nomeJogador;
            let nomePossuiSomenteLetrasMaiusculasEMenusculas = this.aplicarValidacao(validador.validarSeCampoPossuiSomenteLetrasMaiusculasEMinusculas(nomeJogador), ID_NOME_JOGADOR_INPUT, ID_I18N_NOME_COM_CARACTERES_INVALIDOS);
            let nomeNaoENulo = this.aplicarValidacao(validador.validarSeCampoPossuiValor(nomeJogador), ID_NOME_JOGADOR_INPUT, ID_I18N_NOME_OBRIGATORIO);

            let sobrenomeJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().sobrenomeJogador;
            let sobrenomePossuiSomenteLetrasMaiusculasEMenusculas = this.aplicarValidacao(validador.validarSeCampoPossuiSomenteLetrasMaiusculasEMinusculas(sobrenomeJogador), ID_SOBRENOME_JOGADOR_INPUT, ID_I18N_SOBRENOME_COM_CARACTERES_INVALIDOS);
            let sobrenomeNaoENulo = this.aplicarValidacao(validador.validarSeCampoPossuiValor(sobrenomeJogador), ID_SOBRENOME_JOGADOR_INPUT, ID_I18N_SOBRENOME_OBRIGATORIO);

            let dataNascimentoJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().dataNascimentoJogador;
            let dataNascimentoMaiorQueTrezeAnos = this.aplicarValidacao(validador.validarSeJogadorEMaiorQueTrezeAnos(dataNascimentoJogador), ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT, ID_I18N_DATA_NASCIMENTO_MAIOR_QUE_TREZE_ANOS);
            let dataNascimentoNaoENulo = this.aplicarValidacao(validador.validarSeCampoPossuiValor(dataNascimentoJogador), ID_DATA_DE_NASCIMENTO_JOGADOR_INPUT, ID_I18N_DATA_NASCIMENTO_OBRIGATORIO);

            let usuarioJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().usuarioJogador;
            let usuarioPossuiAoMenosSeisDigitos = this.aplicarValidacao(validador.validarUsuarioPossuiAoMenosSeisDigitos(usuarioJogador), ID_USUARIO_JOGADOR_INPUT, ID_I18N_USUARIO_INVALIDO);
            let usuarioPossuiSomenteLetrasMinusculas = this.aplicarValidacao(validador.validarCaracteresUsuarioJogador(usuarioJogador), ID_USUARIO_JOGADOR_INPUT, ID_I18N_USUARIO_INVALIDO);
            let usuarioNaoENulo = this.aplicarValidacao(validador.validarSeCampoPossuiValor(usuarioJogador), ID_USUARIO_JOGADOR_INPUT, ID_I18N_USUARIO_OBRIGATORIO);

            let usuarioConfirmacaoJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().usuarioConfirmacaoJogador;
            let usuarioEConfirmacaoCompativeis = this.aplicarValidacao(validador.validarSeOsValoresDosCamposSaoIguais(usuarioJogador, usuarioConfirmacaoJogador), ID_USUARIO_CONFIRMACAO_JOGADOR_INPUT, ID_I18N_CONFIRMACAO_USUARIO_INCORRETA);

            let senhaJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().senhaHashJogador;
            let senhaPossuiAoMenosOitoDigitos = this.aplicarValidacao(validador.validarSenhaPossuiAoMenosOitoDigitos(senhaJogador), ID_SENHA_JOGADOR_INPUT, ID_I18N_SENHA_INVALIDA);
            let senhaAoMenosUmaLetraMaiusculasUmaLetraMinusculaEUmNumero = this.aplicarValidacao(validador.validarSenhaPossuiOsCaracteresNecessarios(senhaJogador), ID_SENHA_JOGADOR_INPUT, ID_I18N_SENHA_INVALIDA);
            let senhaNaoENulo = this.aplicarValidacao(validador.validarSeCampoPossuiValor(senhaJogador), ID_SENHA_JOGADOR_INPUT, ID_I18N_SENHA_OBRIGATORIO);

            let senhaHashConfirmacaoJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().senhaHashConfirmacaoJogador;
            let senhaEConfirmacaoCompativeis = this.aplicarValidacao(validador.validarSeOsValoresDosCamposSaoIguais(senhaJogador, senhaHashConfirmacaoJogador), ID_SENHA_CONFIRMACAO_JOGADOR_INPUT, ID_I18N_CONFIRMACAO_SENHA_INCORRETA);

            if (this.MENSAGENS_DE_ERRO) {
                let tituloCaixaDeDialogoDeErro = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TITULO_CAIXA_DE_DIALOGO_ERRO);
                let estadoDoDialogoDeErro = ValueState.Error;
                this.abrirDialogo(tituloCaixaDeDialogoDeErro, this.MENSAGENS_DE_ERRO, estadoDoDialogoDeErro);
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
                const valueStateDeErro = "Error";
                this.getView().byId(idInput).setValueState(valueStateDeErro);

                this.MENSAGENS_DE_ERRO += !this.MENSAGENS_DE_ERRO.includes(this.getView().getModel(i18n).getResourceBundle().getText(idI18n)) ? this.getView().getModel(i18n).getResourceBundle().getText(idI18n) + QUEBRA_DE_LINHA : "";
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
            if (this.ID_JOGADOR) {
                return this.navegarParaDetalhes();
            }

            return this.navegarPara(ID_LISTAGEM_JOGADOR);
        },

        navegarParaDetalhes: function () {
            this.removerValoresDosInputs();
            this.removerValueStates();
            let idJogador = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_JOGADOR).getData().id;
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

        criaModeloDeStringsI18n: function () {
            const nomeDoModeloDeStringsI18n = "StringsCampos";
            const idI18nTituloCriacao = "CriacaoJogador.Toolbar.TituloCriacao";
            const idI18nTituloEdicao = "CriacaoJogador.Toolbar.TituloEdicao";
            const idI18nBotaoSalvarCriacao = "ListagemJogador.Toolbar.Buttom.AdicionarJogador";
            const idI18nBotaoSalvarEdicao = "ListagemJogador.Toolbar.Buttom.Confirmar"

            let modeloDeStringsI18n;
            if (this.ID_JOGADOR) {
                modeloDeStringsI18n = new JSONModel(
                    {
                        titulo: idI18nTituloEdicao,
                        textoBotaoSalvar: idI18nBotaoSalvarEdicao
                    }
                )
            } else {
                modeloDeStringsI18n = new JSONModel(
                    {
                        titulo: idI18nTituloCriacao,
                        textoBotaoSalvar: idI18nBotaoSalvarCriacao
                    }
                )
            }

            this.getView().setModel(modeloDeStringsI18n, nomeDoModeloDeStringsI18n);
        },

        abrirDialogo: function (tituloCaixaDeDialogo, mensagem, estadoDoDialogo) {
            let ButtonType = mobileLibrary.ButtonType;
            let DialogType = mobileLibrary.DialogType;
            let idI18nBotaoFecharCaixaDeDialogo = "CriacaoJogador.MessageToast.BotaoFecharCaixaDeDialogo";
            let botaoCaixaDeDialogo = this.getView().getModel(i18n).getResourceBundle().getText(idI18nBotaoFecharCaixaDeDialogo);
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