sap.ui.define([
    "sap/ui/test/Opa5",
    "sap/ui/test/matchers/I18NText",
    "sap/ui/test/actions/EnterText",
    "sap/ui/test/actions/Press",
    "sap/ui/test/matchers/PropertyStrictEquals",
    "sap/ui/test/matchers/Properties",
    "sap/m/ObjectAttribute"
],
    function (Opa5, I18NText, EnterText, Press, PropertyStrictEquals, Properties, ObjectAttribute) {
        "use strict";

        const DETALHES_JOGADOR_VIEW_NAME = "app.jogador.DetalhesJogador";
        const NOME_PROPRIEDADE_TEXT = "text";
        const TIPO_PAGE = "sap.m.Page"
        const CHAVE_I18N_BOTAO_EDITAR_JOGADOR = "DetalhesJogador.Toolbar.Buttom.EditarJogador";
        const CHAVE_I18N_BOTAO_APAGAR_JOGADOR = "DetalhesJogador.Toolbar.Buttom.ApagarJogador";
        const TIPO_ATRIBUTO = "sap.m.ObjectAttribute";
        const TIPO_TABELA = "sap.ui.table.Table";
        const TIPO_CAMPO_DE_BUSCA = "sap.m.SearchField";
        const TIPO_COMBO_BOX = "sap.m.ComboBox";
        const NOME_PROPRIEDADE_PLACEHOLDER = "placeholder";
        const TIPO_BOTAO = "sap.m.Button";
        const CHAVE_I18N_BOTAO_APLICAR_FILTROS = "ListagemJogador.Placeholder.ToggleButtom.AplicarFiltros";
        const CHAVE_I18N_CAMPO_DE_BUSCA_NOME_BARALHO = "ListagemBaralho.Placeholder.CampoDeBusca.NomeBaralho";
        const CHAVE_I18N_COMBO_BOX_COR = "ListagemBaralho.Placeholder.Combobox.CorBaralho";
        const CHAVE_I18N_COMBO_BOX_FORMATO_DE_JOGO = "ListagemBaralho.Placeholder.Combobox.FormatoBaralho";
        const nomeDoBaralho = "Ver";

        Opa5.createPageObjects({

            naPaginaDeDetalhesJogador: {

                actions: {
                    pressionarBotaoDeEditarJogador: function () {
                        return this.waitFor({
                            viewName: DETALHES_JOGADOR_VIEW_NAME,
                            controlType: TIPO_BOTAO,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_TEXT,
                                    key: CHAVE_I18N_BOTAO_EDITAR_JOGADOR
                                }
                            },
                            actions: new Press(),
                            success: () => Opa5.assert.ok(true, "O botao de editar jogador foi pressionado"),
                            errorMessage: "O botao de editar jogador não foi pressionado"
                        });
                    },

                    pressionarBotaoDeApagarJogador: function () {
                        return this.waitFor({
                            viewName: DETALHES_JOGADOR_VIEW_NAME,
                            controlType: TIPO_BOTAO,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_TEXT,
                                    key: CHAVE_I18N_BOTAO_APAGAR_JOGADOR
                                }
                            },
                            actions: new Press(),
                            success: () => Opa5.assert.ok(true, "O botao de apagar jogador foi pressionado"),
                            errorMessage: "O botao de apagar jogador não foi pressionado"
                        });
                    },

                    pressionarBotaoDeFecharDialogo: function () {
                        return this.waitFor({
                            controlType: TIPO_BOTAO,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_TEXT,
                                    key: CHAVE_I18N_BOTAO_APAGAR_JOGADOR
                                }
                            },
                            actions: new Press(),
                            success: () => Opa5.assert.ok(true, "O botao de apagar jogador foi pressionado"),
                            errorMessage: "O botao de apagar jogador não foi pressionado"
                        });
                    },

                    escreveNoCampoDeBuscaPorNomeDoBaralho: function () {
                        return this.waitFor({
                            viewName: DETALHES_JOGADOR_VIEW_NAME,
                            controlType: TIPO_CAMPO_DE_BUSCA,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: CHAVE_I18N_CAMPO_DE_BUSCA_NOME_BARALHO
                                }
                            },
                            actions: new EnterText({ text: nomeDoBaralho }),
                            success: () => Opa5.assert.ok(true, "O campo de busca foi preenchido com o nome do baralho"),
                            errorMessage: "O campo de busca não foi preenchido com o nome do baralho"
                        });
                    },

                    selecionoNoCampoComboBoxFormatoDeJogo: function (formatoDeJogo) {
                        return this.waitFor({
                            viewName: DETALHES_JOGADOR_VIEW_NAME,
                            controlType: TIPO_COMBO_BOX,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: CHAVE_I18N_COMBO_BOX_FORMATO_DE_JOGO
                                }
                            },
                            actions: new EnterText({ text: formatoDeJogo }),
                            success: () => Opa5.assert.ok(true, "O formato de jogo foi selecionado"),
                            errorMessage: "O formato de jogo não foi selecionado"
                        });
                    },

                    selecionoNoCampoComboBoxCor: function (cor) {
                        return this.waitFor({
                            viewName: DETALHES_JOGADOR_VIEW_NAME,
                            controlType: TIPO_COMBO_BOX,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
                                    key: CHAVE_I18N_COMBO_BOX_COR
                                }
                            },
                            actions: new EnterText({ text: cor }),
                            success: () => Opa5.assert.ok(true, "A cor do baralho foi selecionada"),
                            errorMessage: "A cor do baralho não foi selecionada"
                        });
                    },

                    selecionoBotaoDeAplicarFiltros: function () {
                        return this.waitFor({
                            viewName: DETALHES_JOGADOR_VIEW_NAME,
                            controlType: TIPO_BOTAO,
                            matchers: {
                                i18NText: {
                                    propertyName: NOME_PROPRIEDADE_TEXT,
                                    key: CHAVE_I18N_BOTAO_APLICAR_FILTROS
                                }
                            },
                            actions: new Press(),
                            success: () => Opa5.assert.ok(true, "O botão de filtrar foi clicado"),
                            errorMessage: "O botão de filtrar não foi clicado"
                        });
                    },

                    selecionoBotaoDeNavegarParaTras: function () {
                        return this.waitFor({
                            controlType: TIPO_PAGE,
                            actions: new Press(),
                            success: () => Opa5.assert.ok(true, "O botão de navback foi clicado"),
                            errorMessage: "O botão de navback não foi clicado"
                        });
                    },

                    pressionarBotaoCancelarAExclusaoDeJogador: function () {
                        let textoBotaoCancelar = "Cancelar";
                        return this.waitFor({
                            controlType: TIPO_BOTAO,
                            matchers: new PropertyStrictEquals({
                                name: NOME_PROPRIEDADE_TEXT,
                                value: textoBotaoCancelar
                            }),
                            actions: new Press(),
                            success: () => Opa5.assert.ok(true, "O botão de cancelar foi pressionado"),
                            errorMessage: "O botão de cancelar não foi pressionado"
                        });
                    },

                    pressionarBotaoConfirmarAExclusaoDeJogador: function () {
                        let textoBotaoConfirmar = "Confirmar";
                        return this.waitFor({
                            controlType: TIPO_BOTAO,
                            matchers: new PropertyStrictEquals({
                                name: NOME_PROPRIEDADE_TEXT,
                                value: textoBotaoConfirmar
                            }),
                            actions: new Press(),
                            success: () => Opa5.assert.ok(true, "O botão de confirmar foi pressionado"),
                            errorMessage: "O botão de confirmar não foi pressionado"
                        });
                    },
                },

                assertions: {
                    confiroOValorDoCampo: function (valorEsperado) {
                        return this.waitFor({
                            viewName: DETALHES_JOGADOR_VIEW_NAME,
                            controlType: TIPO_ATRIBUTO,
                            matchers: new PropertyStrictEquals({
                                name: NOME_PROPRIEDADE_TEXT,
                                value: valorEsperado
                            }),
                            success: () => Opa5.assert.ok(true, "O campo possui o valor esperado"),
                            errorMessage: "O campo não possui o valor esperado"
                        });
                    },

                    aTabelaDeveConterAQuantidadeEsperada: function (quantidadeEsperada) {
                        const modeloBaralho = "Baralho";
                        return this.waitFor({
                            viewName: DETALHES_JOGADOR_VIEW_NAME,
                            controlType: TIPO_TABELA,
                            check: function (tabela) {
                                return tabela[0].getModel(modeloBaralho).getData().length == quantidadeEsperada;
                            },
                            success: () => Opa5.assert.ok(true, "O jogador possui a quantidade de baralhos esperada"),
                            errorMessage: "O jogador não possui a quantidade de baralhos esperada"
                        });
                    },
                }
            }
        });
    }
);