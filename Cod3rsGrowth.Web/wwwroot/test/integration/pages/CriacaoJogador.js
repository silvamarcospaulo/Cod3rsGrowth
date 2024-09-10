sap.ui.define([
    "sap/ui/test/Opa5",
    "sap/ui/test/matchers/I18NText",
    "sap/ui/test/actions/EnterText",
    "sap/ui/test/actions/Press",
    "sap/ui/test/matchers/AggregationLengthEquals",
],
    function (Opa5, I18NText, EnterText, Press, AggregationLengthEquals) {

        "use strict";

        const CRIACAO_JOGADOR_VIEW_NAME = "app.jogador.CriacaoJogador";

        const NOME_PROPRIEDADE_PLACEHOLDER = "placeholder";
        const NOME_PROPRIEDADE_TOOLTIP = "tooltip";
        const NOME_PROPRIEDADE_TEXT = "text";
        const CONTROL_TYPE_INPUT = "sap.m.Input";
        const CONTROL_TYPE_BOTAO = "sap.m.Button";
        const CONTROL_TYPE_DATEPICKER = "sap.m.DatePicker";

        const NOME_JOGADOR = "Jucleiton";
        const SOBRENOME_JOGADOR = "Silva";
        const DATA_DE_NASCIMENTO_JOGADOR = "03/03/2003";
        const USUARIO_JOGADOR = "jucleitonsilva";
        const SENHA_JOGADOR = "Senha123";

        const DATA_DE_NASCIMENTO_JOGADOR_INVALIDO = "03032024";
        const USUARIO_JOGADOR_INVALIDO = "jucleitonsilva1";
        const SENHA_JOGADOR_INVALIDO = "-Senha123";

        const CHAVE_I18N_INPUT_NOME_JOGADOR = "CriacaoJogador.Placeholder.NomeJogador";
        const CHAVE_I18N_INPUT_SOBRENOME_JOGADOR = "CriacaoJogador.Placeholder.SobrenomeJogador";
        const CHAVE_I18N_INPUT_DATA_DE_NASCIMENTO_JOGADOR = "CriacaoJogador.Placeholder.DataDeNascimentoJogador";
        const CHAVE_I18N_INPUT_USUARIO_JOGADOR = "CriacaoJogador.Placeholder.UsuarioJogador";
        const CHAVE_I18N_INPUT_USUARIO_CONFIRMACAO_JOGADOR = "CriacaoJogador.Placeholder.UsuarioConfirmacaoJogador";
        const CHAVE_I18N_INPUT_SENHA_JOGADOR = "CriacaoJogador.Placeholder.SenhaHashJogador";
        const CHAVE_I18N_INPUT_SENHA_CONFIRMACAO_JOGADOR = "CriacaoJogador.Placeholder.SenhaHashConfirmacaoJogador";
        const CHAVE_I18N_BOTAO_ADICIONAR_JOGADOR = "ListagemJogador.Toolbar.Buttom.AdicionarJogador";

        Opa5.createPageObjects({
            naPaginaDeCriacaoDeJogador: {

                actions: {
                    entreveUmValorValidoNoInputDeNomeDoJogador: function () {
                        return this.waitFor({
                            viewName: CRIACAO_JOGADOR_VIEW_NAME,
                            controlType: CONTROL_TYPE_INPUT,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: CHAVE_I18N_INPUT_NOME_JOGADOR
                                }
                            },
                            actions: new EnterText({ text: NOME_JOGADOR }),
                            success: () => Opa5.assert.ok(true, "O input de nome do jogador foi preenchido"),
                            errorMessage: "O input de nome do jogador não foi preenchido"
                        });
                    },

                    entreveUmValorValidoNoInputDeSobrenomeDoJogador: function () {
                        return this.waitFor({
                            viewName: CRIACAO_JOGADOR_VIEW_NAME,
                            controlType: CONTROL_TYPE_INPUT,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: CHAVE_I18N_INPUT_SOBRENOME_JOGADOR
                                }
                            },
                            actions: new EnterText({ text: SOBRENOME_JOGADOR }),
                            success: () => Opa5.assert.ok(true, "O input de sobrenome do jogador foi preenchido"),
                            errorMessage: "O input de sobrenome do jogador não foi preenchido"
                        });
                    },

                    entreveUmValorValidoNoInputDeDataDeNascimentoDoJogador: function () {
                        return this.waitFor({
                            viewName: CRIACAO_JOGADOR_VIEW_NAME,
                            controlType: CONTROL_TYPE_DATEPICKER,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: CHAVE_I18N_INPUT_DATA_DE_NASCIMENTO_JOGADOR
                                }
                            },
                            actions: new EnterText({ text: DATA_DE_NASCIMENTO_JOGADOR }),
                            success: () => Opa5.assert.ok(true, "O input de data de nascimento do jogador foi preenchido"),
                            errorMessage: "O input de data de nascimento do jogador não foi preenchido"
                        });
                    },

                    entreveUmValorValidoNoInputDeUsuarioDoJogador: function () {
                        return this.waitFor({
                            viewName: CRIACAO_JOGADOR_VIEW_NAME,
                            controlType: CONTROL_TYPE_INPUT,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: CHAVE_I18N_INPUT_USUARIO_JOGADOR
                                }
                            },
                            actions: new EnterText({ text: USUARIO_JOGADOR }),
                            success: () => Opa5.assert.ok(true, "O input de usuario do jogador foi preenchido"),
                            errorMessage: "O input de usuario do jogador não foi preenchido"
                        });
                    },

                    entreveUmValorValidoNoInputDeConfirmacaoDeUsuarioDoJogador: function () {
                        return this.waitFor({
                            viewName: CRIACAO_JOGADOR_VIEW_NAME,
                            controlType: CONTROL_TYPE_INPUT,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: CHAVE_I18N_INPUT_USUARIO_CONFIRMACAO_JOGADOR
                                }
                            },
                            actions: new EnterText({ text: USUARIO_JOGADOR }),
                            success: () => Opa5.assert.ok(true, "O input de confirmacao de usuario do jogador foi preenchido"),
                            errorMessage: "O input de confirmacao de usuario do jogador não foi preenchido"
                        });
                    },

                    entreveUmValorValidoNoInputDeSenhaDoJogador: function () {
                        return this.waitFor({
                            viewName: CRIACAO_JOGADOR_VIEW_NAME,
                            controlType: CONTROL_TYPE_INPUT,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: CHAVE_I18N_INPUT_SENHA_JOGADOR
                                }
                            },
                            actions: new EnterText({ text: SENHA_JOGADOR_INVALIDO }),
                            success: () => Opa5.assert.ok(true, "O input de senha do jogador foi preenchido"),
                            errorMessage: "O input de senha do jogador não foi preenchido"
                        });
                    },

                    entreveUmValorValidoNoInputDeConfirmacaoDeSenhaDoJogador: function () {
                        return this.waitFor({
                            viewName: CRIACAO_JOGADOR_VIEW_NAME,
                            controlType: CONTROL_TYPE_INPUT,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: CHAVE_I18N_INPUT_SENHA_CONFIRMACAO_JOGADOR
                                }
                            },
                            actions: new EnterText({ text: SENHA_JOGADOR }),
                            success: () => Opa5.assert.ok(true, "O input de confimação de senha do jogador foi preenchido"),
                            errorMessage: "O input de confimação de senha do jogador não foi preenchido"
                        });
                    },

                    pressionoOBotaoDeAdicionarJogador: function () {
                        return this.waitFor({
                            viewName: CRIACAO_JOGADOR_VIEW_NAME,
                            controlType: CONTROL_TYPE_BOTAO,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_TEXT,
                                    key: CHAVE_I18N_BOTAO_ADICIONAR_JOGADOR
                                }
                            },
                            actions: new Press(),
                            success: () => Opa5.assert.ok(true, "O botão de adicionar jogador foi pressionado"),
                            errorMessage: "O botão de adicionar jogador não foi pressionado"
                        });
                    },
                },

                assertions: {
                },
            }
        });
    }
);