sap.ui.define([
    "mtgdeckbuilder/app/comum/BaseController",
    "sap/ui/model/json/JSONModel",
    "mtgdeckbuilder/app/comum/Repository",
    "mtgdeckbuilder/app/model/formatter",
    "sap/m/MessageBox",
    "sap/ui/core/ValueState",
    "sap/ui/core/library",
    "sap/m/Dialog",
    "sap/m/Button",
    "sap/m/library",
    "sap/m/Text"
], function (BaseController, JSONModel, Repository, formatter, MessageBox,
    ValueState, coreLibrary, Dialog, Button, mobileLibrary, Text) {
    "use strict";

    const CONTROLLER = "mtgdeckbuilder.app.jogador.DetalhesJogador";
    const ID_I18N_TITULO_CAIXA_DE_DIALOGO_ERRO = "CriacaoJogador.MessageToast.TituloCaixaDeDialogoErro"
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
    const i18n = "i18n";
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
            this.dialogoDeConfirmacao();
        },

        deletarJogador: async function () {
            const quantidadeDeBaralhosParaExclusao = 0;
            let jogador = this.getView().getModel(NOME_DO_MODELO_DE_JOGADOR_SELECIONADO).getData();
            let tituloCaixaDeDialogo;
            let mensagem;
            let estadoDoDialogo;

            if (jogador.baralhosJogador.length > quantidadeDeBaralhosParaExclusao) {
                tituloCaixaDeDialogo = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TITULO_CAIXA_DE_DIALOGO_ERRO);
                let idI18nMensagemErroValidacao = "CriacaoJogador.MessageToast.MensagemJogadorPossuiBaralhos";
                mensagem = this.getView().getModel(i18n).getResourceBundle().getText(idI18nMensagemErroValidacao);
                estadoDoDialogo = ValueState.Error;
            } else {
                let requisicao = await Repository.deletar(REQUISICAO, jogador.id);

                if (requisicao.ok) {
                    let idI18nTituloDialogo = "CriacaoJogador.MessageToast.TituloCaixaDeDialogoSucesso";
                    let idI18nMensagemDialogoSucesso = "DeletarJogador.MessageToast.MensagemSucesso";
                    tituloCaixaDeDialogo = this.getView().getModel(i18n).getResourceBundle().getText(idI18nTituloDialogo);
                    mensagem = this.getView().getModel(i18n).getResourceBundle().getText(idI18nMensagemDialogoSucesso);
                    estadoDoDialogo = ValueState.Success;
                } else {
                    tituloCaixaDeDialogo = this.getView().getModel(i18n).getResourceBundle().getText(ID_I18N_TITULO_CAIXA_DE_DIALOGO_ERRO);
                    mensagem = this.criarObjetoDeMensagemDeErroRFC(requisicao);
                    estadoDoDialogo = ValueState.Error;
                }
            }

            this.abrirDialogo(tituloCaixaDeDialogo, mensagem, estadoDoDialogo)
        },

        dialogoDeConfirmacao: function () {
            let ButtonType = mobileLibrary.ButtonType;
            let DialogType = mobileLibrary.DialogType;
            let idI18nTituloDialogo = "DeletarJogador.MessageToast.TituloDialogo";
            let idI18nMensagemDialogo = "DeletarJogador.MessageToast.MensagemDialogo";
            let idI18nMTextoBotaoConfirmar = "DeletarJogador.MessageToast.BotaoConfirmarDialogo";
            let idI18nMTextoBotaoCancelar = "DeletarJogador.MessageToast.BotaoCancelarDialogo";
            let titulo = this.getView().getModel(i18n).getResourceBundle().getText(idI18nTituloDialogo);
            let mensagem = this.getView().getModel(i18n).getResourceBundle().getText(idI18nMensagemDialogo);
            let textoBotaoConfirmar = this.getView().getModel(i18n).getResourceBundle().getText(idI18nMTextoBotaoConfirmar);
            let textoBotaoCancelar = this.getView().getModel(i18n).getResourceBundle().getText(idI18nMTextoBotaoCancelar);
            let valueStateDeConfirmacao = ValueState.Warning;

            let botaoConfirmar = new Button({
                type: ButtonType.Emphasized,
                text: textoBotaoConfirmar,
                press: function () {
                    this.oConfirmationMessageDialog.close();
                    this.deletarJogador();
                }.bind(this)
            });

            let botaoCancelar = new Button({
                type: ButtonType.Emphasized,
                text: textoBotaoCancelar,
                press: function () {
                    this.oConfirmationMessageDialog.close();
                }.bind(this)
            });

            this.oConfirmationMessageDialog = new Dialog({
                type: DialogType.Message,
                title: titulo,
                state: valueStateDeConfirmacao,
                content: new Text({ text: mensagem }),
                beginButton: botaoConfirmar,
                endButton: botaoCancelar
            });

            this.oConfirmationMessageDialog.open();
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

        aoPressionarRetornarNavegacao: function () {
            const rota = "listagemJogador";
            return this.navegarPara(rota);
        },
    });
});