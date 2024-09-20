sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/EdicaoJogador"
], (opaTest) => {
    "use strict";

    QUnit.module("JornadaEdicaoJogador");

    const CONTROL_TYPE_INPUT = "sap.m.Input";
    const CONTROL_TYPE_DATEPICKER = "sap.m.DatePicker";
    const NOME_ESPERADO = "Jucleiton";
    const SOBRE_NOME_ESPERADO = "Silva";
    const DATA_DE_NASCIMENTO_ESPERADA = "03/03/2003";
    const USUARIO_JOGADOR = "jucleiton";
    const SENHA_JOGADOR = "Senha12345678";
    const USUARIO_JOGADOR_INVALIDO = "marcos";
    const SENHA_JOGADOR_INVALIDO = "-Senha123";
    const CHAVE_I18N_INPUT_NOME_JOGADOR = "CriacaoJogador.Placeholder.NomeJogador";
    const CHAVE_I18N_INPUT_SOBRENOME_JOGADOR = "CriacaoJogador.Placeholder.SobrenomeJogador";
    const CHAVE_I18N_INPUT_DATA_DE_NASCIMENTO_JOGADOR = "CriacaoJogador.Placeholder.DataDeNascimentoJogador";
    const CHAVE_I18N_INPUT_USUARIO_JOGADOR = "CriacaoJogador.Placeholder.UsuarioJogador";
    const CHAVE_I18N_INPUT_USUARIO_CONFIRMACAO_JOGADOR = "CriacaoJogador.Placeholder.UsuarioConfirmacaoJogador";
    const CHAVE_I18N_INPUT_SENHA_JOGADOR = "CriacaoJogador.Placeholder.SenhaHashJogador";
    const CHAVE_I18N_INPUT_SENHA_CONFIRMACAO_JOGADOR = "CriacaoJogador.Placeholder.SenhaHashConfirmacaoJogador";

    opaTest("Ao realizar a edição com todos os campos válidos, edita o jogador e deve abrir uma caixa de diálogo informando sucesso", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "mtgdeckbuilder"
            },
            hash: "edicaoJogador/40025"
        });

        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(NOME_ESPERADO, CONTROL_TYPE_INPUT, CHAVE_I18N_INPUT_NOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(SOBRE_NOME_ESPERADO, CONTROL_TYPE_INPUT, CHAVE_I18N_INPUT_SOBRENOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(DATA_DE_NASCIMENTO_ESPERADA, CONTROL_TYPE_DATEPICKER, CHAVE_I18N_INPUT_DATA_DE_NASCIMENTO_JOGADOR);

        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(USUARIO_JOGADOR, CHAVE_I18N_INPUT_USUARIO_JOGADOR);
        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(USUARIO_JOGADOR, CHAVE_I18N_INPUT_USUARIO_CONFIRMACAO_JOGADOR);
        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(SENHA_JOGADOR, CHAVE_I18N_INPUT_SENHA_JOGADOR);
        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(SENHA_JOGADOR, CHAVE_I18N_INPUT_SENHA_CONFIRMACAO_JOGADOR);

        Then.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeEditarJogador();

        Then.naPaginaDeEdicaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoSucesso();

        Then.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();
    });

    opaTest("Ao realizar a edição de usuario com campos válidos, edita o jogador e deve abrir uma caixa de diálogo informando sucesso", (Given, When, Then) => {
        When.naPaginaDeDetalhesJogador.pressionarBotaoDeEditarJogador();

        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(NOME_ESPERADO, CONTROL_TYPE_INPUT, CHAVE_I18N_INPUT_NOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(SOBRE_NOME_ESPERADO, CONTROL_TYPE_INPUT, CHAVE_I18N_INPUT_SOBRENOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(DATA_DE_NASCIMENTO_ESPERADA, CONTROL_TYPE_DATEPICKER, CHAVE_I18N_INPUT_DATA_DE_NASCIMENTO_JOGADOR);

        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(SENHA_JOGADOR, CHAVE_I18N_INPUT_SENHA_JOGADOR);
        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(SENHA_JOGADOR, CHAVE_I18N_INPUT_SENHA_CONFIRMACAO_JOGADOR);

        Then.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeEditarJogador();

        Then.naPaginaDeEdicaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoSucesso();

        Then.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();
    });

    opaTest("Ao realizar a edição de senha com campos válidos, edita o jogador e deve abrir uma caixa de diálogo informando sucesso", (Given, When, Then) => {
        When.naPaginaDeDetalhesJogador.pressionarBotaoDeEditarJogador();

        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(NOME_ESPERADO, CONTROL_TYPE_INPUT, CHAVE_I18N_INPUT_NOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(SOBRE_NOME_ESPERADO, CONTROL_TYPE_INPUT, CHAVE_I18N_INPUT_SOBRENOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(DATA_DE_NASCIMENTO_ESPERADA, CONTROL_TYPE_DATEPICKER, CHAVE_I18N_INPUT_DATA_DE_NASCIMENTO_JOGADOR);

        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(USUARIO_JOGADOR, CHAVE_I18N_INPUT_USUARIO_JOGADOR);
        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(USUARIO_JOGADOR, CHAVE_I18N_INPUT_USUARIO_CONFIRMACAO_JOGADOR);

        Then.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeEditarJogador();

        Then.naPaginaDeEdicaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoSucesso();

        Then.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();
    });

    opaTest("Ao realizar a edição de usuario com campos inválidos, deve abrir uma caixa de diálogo informando erro", (Given, When, Then) => {
        When.naPaginaDeDetalhesJogador.pressionarBotaoDeEditarJogador();

        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(NOME_ESPERADO, CONTROL_TYPE_INPUT, CHAVE_I18N_INPUT_NOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(SOBRE_NOME_ESPERADO, CONTROL_TYPE_INPUT, CHAVE_I18N_INPUT_SOBRENOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(DATA_DE_NASCIMENTO_ESPERADA, CONTROL_TYPE_DATEPICKER, CHAVE_I18N_INPUT_DATA_DE_NASCIMENTO_JOGADOR);

        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(SENHA_JOGADOR_INVALIDO, CHAVE_I18N_INPUT_SENHA_JOGADOR);
        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(SENHA_JOGADOR_INVALIDO, CHAVE_I18N_INPUT_SENHA_CONFIRMACAO_JOGADOR);

        Then.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeEditarJogador();

        Then.naPaginaDeEdicaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();

        Then.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();
    });

    opaTest("Ao realizar a edição de senha com campos válidos, deve abrir uma caixa de diálogo informando erro", (Given, When, Then) => {
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(NOME_ESPERADO, CONTROL_TYPE_INPUT, CHAVE_I18N_INPUT_NOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(SOBRE_NOME_ESPERADO, CONTROL_TYPE_INPUT, CHAVE_I18N_INPUT_SOBRENOME_JOGADOR);
        Then.naPaginaDeEdicaoDeJogador.confiroOValorDoInput(DATA_DE_NASCIMENTO_ESPERADA, CONTROL_TYPE_DATEPICKER, CHAVE_I18N_INPUT_DATA_DE_NASCIMENTO_JOGADOR);

        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(USUARIO_JOGADOR_INVALIDO, CHAVE_I18N_INPUT_USUARIO_JOGADOR);
        When.naPaginaDeEdicaoDeJogador.entreveUmValorNoInput(USUARIO_JOGADOR_INVALIDO, CHAVE_I18N_INPUT_USUARIO_CONFIRMACAO_JOGADOR);

        Then.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeEditarJogador();

        Then.naPaginaDeEdicaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();

        Then.naPaginaDeEdicaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();

        Then.iTeardownMyApp();
    });
});