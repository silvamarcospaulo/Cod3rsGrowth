sap.ui.define([
    "sap/ui/test/opaQunit",
    "mtgdeckbuilder/test/integration/pages/CriacaoJogador"
], (opaTest) => {
    "use strict";

    QUnit.module("JornadaCriacaoJogador");

    const NOME_JOGADOR = "Jucleiton";
    const SOBRENOME_JOGADOR = "Silva";
    const DATA_DE_NASCIMENTO_JOGADOR = "03/03/2003";
    const USUARIO_JOGADOR = "jucleitonnnnsilva";
    const SENHA_JOGADOR = "Senha123";

    const NOME_JOGADOR_INVALIDO = "Jucleiton2";
    const SOBRENOME_JOGADOR_INVALIDO = "Silva2";
    const DATA_DE_NASCIMENTO_JOGADOR_INVALIDO = "03/03/2024";
    const USUARIO_JOGADOR_INVALIDO = "jucleitonsilva1";
    const SENHA_JOGADOR_INVALIDO = "-Senha123";

    opaTest("Ao realizar a criação com todos os campos válidos, cria um jogador e deve abrir uma caixa de diálogo informando sucesso", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "mtgdeckbuilder"
            },
            hash: "criacaoJogador"
        });

        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeNomeDoJogador(NOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSobrenomeDoJogador(SOBRENOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeDataDeNascimentoDoJogador(DATA_DE_NASCIMENTO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeAdicionarJogador();

        Then.naPaginaDeCriacaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoSucesso();

        Then.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();

        When.naPaginaDeListagemJogador.aoClicarNoBotaoAdicionarJogadorRedirecionaParaATelaDeCadastro();

        Then.naPaginaDeCriacaoDeJogador.aTelaDeCriacaoFoiCarregada();
    });

    opaTest("Ao realizar a criação com campo nome inválido, deve abrir uma caixa de diálogo informando erro", (Given, When, Then) => {
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeNomeDoJogador(NOME_JOGADOR_INVALIDO);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSobrenomeDoJogador(SOBRENOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeDataDeNascimentoDoJogador(DATA_DE_NASCIMENTO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeAdicionarJogador();

        Then.naPaginaDeCriacaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();

        Then.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();
    });

    opaTest("Ao realizar a criação com campo sobrenome inválido, deve abrir uma caixa de diálogo informando erro", (Given, When, Then) => {
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeNomeDoJogador(NOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSobrenomeDoJogador(SOBRENOME_JOGADOR_INVALIDO);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeDataDeNascimentoDoJogador(DATA_DE_NASCIMENTO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeAdicionarJogador();

        Then.naPaginaDeCriacaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();

        Then.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();
    });

    opaTest("Ao realizar a criação com campo data de nascimento inválido, deve abrir uma caixa de diálogo informando erro", (Given, When, Then) => {
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeNomeDoJogador(NOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSobrenomeDoJogador(SOBRENOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeDataDeNascimentoDoJogador(DATA_DE_NASCIMENTO_JOGADOR_INVALIDO);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeAdicionarJogador();

        Then.naPaginaDeCriacaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();

        Then.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();
    });

    opaTest("Ao realizar a criação com campo usuário inválido, deve abrir uma caixa de diálogo informando erro", (Given, When, Then) => {
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeNomeDoJogador(NOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSobrenomeDoJogador(SOBRENOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeDataDeNascimentoDoJogador(DATA_DE_NASCIMENTO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeUsuarioDoJogador(USUARIO_JOGADOR_INVALIDO);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeUsuarioDoJogador(USUARIO_JOGADOR_INVALIDO);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeAdicionarJogador();

        Then.naPaginaDeCriacaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();

        Then.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();
    });

    opaTest("Ao realizar a criação com campo de confirmação de usuário que não coincide com o campo de usuário, deve abrir uma caixa de diálogo informando erro", (Given, When, Then) => {
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeNomeDoJogador(NOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSobrenomeDoJogador(SOBRENOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeDataDeNascimentoDoJogador(DATA_DE_NASCIMENTO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeUsuarioDoJogador(USUARIO_JOGADOR_INVALIDO);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeAdicionarJogador();

        Then.naPaginaDeCriacaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();

        Then.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();
    });

    opaTest("Ao realizar a criação com campo senha inválido, deve abrir uma caixa de diálogo informando erro", (Given, When, Then) => {
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeNomeDoJogador(NOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSobrenomeDoJogador(SOBRENOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeDataDeNascimentoDoJogador(DATA_DE_NASCIMENTO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSenhaDoJogador(SENHA_JOGADOR_INVALIDO);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeSenhaDoJogador(SENHA_JOGADOR_INVALIDO);
        When.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeAdicionarJogador();

        Then.naPaginaDeCriacaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();

        Then.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();
    });

    opaTest("Ao realizar a criação com campo de confirmação de senha que não coincide com o campo de senha, deve abrir uma caixa de diálogo informando erro", (Given, When, Then) => {
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeNomeDoJogador(NOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSobrenomeDoJogador(SOBRENOME_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeDataDeNascimentoDoJogador(DATA_DE_NASCIMENTO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeUsuarioDoJogador(USUARIO_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeSenhaDoJogador(SENHA_JOGADOR);
        When.naPaginaDeCriacaoDeJogador.entreveUmValorNoInputDeConfirmacaoDeSenhaDoJogador(SENHA_JOGADOR_INVALIDO);
        When.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeAdicionarJogador();

        Then.naPaginaDeCriacaoDeJogador.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();

        Then.naPaginaDeCriacaoDeJogador.pressionaOBotaoDeFecharCaixaDeDialogo();

        Then.iTeardownMyApp();
    });
});