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
        const EDICAO_JOGADOR_VIEW_NAME = "app.jogador.EdicaoJogador";
        const NOME_PROPRIEDADE_TEXT = "text";

        const CHAVE_I18N_BOTAO_ADICIONAR_JOGADOR = "DetalhesJogador.Toolbar.Buttom.EditarJogador";

        const TIPO_ATRIBUTO = "sap.m.ObjectAttribute";
        const TIPO_TABELA = "sap.ui.table.Table";
        const TIPO_BOTAO = "sap.m.Botao";
        const NOME_PROPRIEDADE_PLACEHOLDER = "placeholder";

        Opa5.createPageObjects({

            naPaginaDeDetalhesJogador: {

                actions: {
                    perssionarBotaoDeEditarJogador: function () {
                        return this.waitFor({
                            viewName: DETALHES_JOGADOR_VIEW_NAME,
                            controlType: CONTROL_TYPE_BOTAO,
                            matchers: {
								i18NText: {
									propertyName: NOME_PROPRIEDADE_PLACEHOLDER,
									key: CHAVE_I18N_BOTAO_ADICIONAR_JOGADOR
								}
							},
                            actions: new Press(),
                            success: () => Opa5.assert.ok(true, "O botao de editar jogador foi pressionado"),
                            errorMessage: "O botao de editar jogador não foi pressionado"
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
                        const modeloJogador = "JogadorSelecionado";
						return this.waitFor({
							viewName: DETALHES_JOGADOR_VIEW_NAME,
							controlType: TIPO_TABELA,
							check: function (tabela) {
                                console.log(tabela[0].getModel(modeloJogador).getData().baralhosJogador);
								return tabela[0].getModel().getData().baralhosJogador.length == quantidadeEsperada;
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