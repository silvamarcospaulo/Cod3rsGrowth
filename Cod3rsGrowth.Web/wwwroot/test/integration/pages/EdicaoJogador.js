sap.ui.define([
    "sap/ui/test/Opa5",
    "sap/ui/test/matchers/I18NText",
    "sap/ui/test/matchers/Matcher",
    "sap/ui/test/matchers/Properties",
    "sap/ui/test/actions/EnterText",
    "sap/ui/test/actions/Press",
    "sap/ui/test/matchers/AggregationLengthEquals",
    "sap/m/Dialog"
],
    function (Opa5, I18NText, Matcher, Properties, EnterText, Press, AggregationLengthEquals, Dialog) {

        "use strict";

        const EDICAO_JOGADOR_VIEW_NAME = "app.jogador.CriacaoJogador";
        const NOME_PROPRIEDADE_PLACEHOLDER = "placeholder";
        const NOME_PROPRIEDADE_TEXT = "text";
        const CONTROL_TYPE_INPUT = "sap.m.Input";
        const CONTROL_TYPE_BOTAO = "sap.m.Button";
        const CONTROL_TYPE_MESSAGEBOX = "sap.m.Dialog";
        const CHAVE_I18N_BOTAO_EDITAR_JOGADOR = "ListagemJogador.Toolbar.Buttom.Confirmar";


        Opa5.createPageObjects({
            naPaginaDeEdicaoDeJogador: {

                actions: {
                    entreveUmValorNoInput: function (texto, idI18n) {
                        return this.waitFor({
                            viewName: EDICAO_JOGADOR_VIEW_NAME,
                            controlType: CONTROL_TYPE_INPUT,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: idI18n
                                }
                            },
                            actions: new EnterText({ text: texto }),
                            success: () => Opa5.assert.ok(true, "O input foi preenchido"),
                            errorMessage: "O input não foi preenchido"
                        });
                    },

                },

                assertions: {
                    confiroOValorDoInput: function (valorEsperado, controlType, idI18n) {
                        return this.waitFor({
                            viewName: EDICAO_JOGADOR_VIEW_NAME,
                            controlType: controlType,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: idI18n
                                }
                            },
                            check: function (input) {
                                return input[0].getValue() === valorEsperado;
                            },
                            success: () => Opa5.assert.ok(true, "O input possui o valor esperado"),
                            errorMessage: "O input não possui o valor esperado"
                        });
                    },

                    verificaSeAbreUmaCaixaDeDialogoIndicandoErro: function () {
                        const mensagemEsperada = "Erro";
                        return this.waitFor({
                            controlType: CONTROL_TYPE_MESSAGEBOX,
                            check: function (MessageBox) {
                                return MessageBox[0].getTitle() == mensagemEsperada;
                            },
                            success: () => Opa5.assert.ok(true, "O erro nos dados inseridos foi indentificado com sucesso"),
                            errorMessage: "O erro nos dados inseridos não foi indentificado"
                        });
                    },

                    verificaSeAbreUmaCaixaDeDialogoIndicandoSucesso: function () {
                        const mensagemEsperada = "Sucesso";
                        return this.waitFor({
                            controlType: CONTROL_TYPE_MESSAGEBOX,
                            check: function (MessageBox) {
                                return MessageBox[0].getTitle() == mensagemEsperada;
                            },
                            success: () => Opa5.assert.ok(true, "O jogador foi editado com sucesso"),
                            errorMessage: "O jogador não foi editado"
                        });
                    },

                    pressionaOBotaoDeEditarJogador: function () {
                        return this.waitFor({
                            controlType: CONTROL_TYPE_BOTAO,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_TEXT,
                                    key: CHAVE_I18N_BOTAO_EDITAR_JOGADOR
                                }
                            },
                            actions: new Press(),
                            success: () => Opa5.assert.ok(true, "O botão de confirmar edição e enviar os dados foi pressionado"),
                            errorMessage: "Erro ao pressionar o botão de confirmar edição e enviar os dados"
                        });
                    },

                    pressionaOBotaoDeFecharCaixaDeDialogo: function () {
                        return this.waitFor({
                            controlType: CONTROL_TYPE_BOTAO,
                            actions: new Press(),
                            success: () => Opa5.assert.ok(true, "O botão de fechar caixa de diálogo foi pressionado"),
                            errorMessage: "O botão de fechar caixa de diálogo não foi pressionado"
                        });
                    },

                    aPaginaDeEdicaoFoiCarregada: function () {
                        const rotaDeEdicao = "edicaoJogador";
                        return this.waitFor({
                            check: function () {
                                return window.location.hash.includes(rotaDeEdicao);
                            },
                            success: () => Opa5.assert.ok(true, "A pagina de edição de jogador foi carregada corretamente"),
                            errorMessage: "A pagina de edição de jogador não foi carregada corretamente"
                        });
                    }
                },
            }
        });
    }
);