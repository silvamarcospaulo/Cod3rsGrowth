sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/EdicaoJogador"
], (opaTest) => {
    "use strict";

    QUnit.module("JornadaCriacaoJogador");

    const NOME_ESPERADO = "Jucleiton";
    const SOBRE_NOME_ESPERADO = "Silva";
    const DATA_DE_NASCIMENTO_ESPERADA = "03/03/2003";
    const USUARIO_JOGADOR = "jucleiton";
    const SENHA_JOGADOR = "Senha123";
    const USUARIO_JOGADOR_INVALIDO = "joaquim";
    const SENHA_JOGADOR_INVALIDO = "-Senha123";
    const CHAVE_I18N_INPUT_NOME_JOGADOR = "CriacaoJogador.Placeholder.NomeJogador";
    const CHAVE_I18N_INPUT_SOBRENOME_JOGADOR = "CriacaoJogador.Placeholder.SobrenomeJogador";
    const CHAVE_I18N_INPUT_DATA_DE_NASCIMENTO_JOGADOR = "CriacaoJogador.Placeholder.DataDeNascimentoJogador";

    opaTest("Ao realizar a edição com todos os campos válidos, edita o jogador e deve abrir uma caixa de diálogo informando sucesso", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "mtgdeckbuilder"
            },
            hash: "edicaoJogador/30027"
        });

        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(NOME_ESPERADO, CHAVE_I18N_INPUT_NOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(SOBRE_NOME_ESPERADO, CHAVE_I18N_INPUT_SOBRENOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(DATA_DE_NASCIMENTO_ESPERADA, CHAVE_I18N_INPUT_DATA_DE_NASCIMENTO_JOGADOR);

        When.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeEditarJogador();

        Then.naPaginaDeEdicaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoSucesso();

        Then.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();

        Then.naPaginaDeDetalhesJogador.aTelaDeDetalhesFoiCarregada();

        Then.iTeardownMyApp();
    });
});