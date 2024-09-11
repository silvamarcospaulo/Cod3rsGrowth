sap.ui.define([
    "sap/ui/model/json/JSONModel",
], function (JSONModel) {
    "use strict";

    return {

        validarNomeESobrenomeJogador: function (nomeJogador) {
            if (!nomeJogador) {
                return false;
            }

            const regex = /[^a-zA-Z\s]/;

            if (regex.test(nomeJogador)) {
                return false;
            }

            return true;
        },

        validarDataDeNascimentoJogador: function (dataNascimentoJogador) {
            const idadeMinimaParaCriarConta = 13;

            if (!dataNascimentoJogador) {
                return false;
            }

            let dataNascimento = new Date(dataNascimentoJogador);

            let dataNascimentoMais13Anos = new Date(dataNascimento);
            dataNascimentoMais13Anos.setFullYear(dataNascimento.getFullYear() + idadeMinimaParaCriarConta);

            let dataAtual = new Date();
            if (dataNascimentoMais13Anos > dataAtual) {
                return false;
            }

            return true;
        },

        validarUsuarioJogador: function (usuarioJogador) {

            debugger
            if (!usuarioJogador || usuarioJogador.length < 6) {
                return false;
            }

            const regex = /^[a-z]+$/;

            if (!regex.test(usuarioJogador)) {
                return false;
            }

            return true;
        },

        validarConfirmacaoDeUsuarioJogador: function (usuarioJogador, usuarioConfirmacaoJogador) {
            if (usuarioJogador != usuarioConfirmacaoJogador || !usuarioConfirmacaoJogador) {
                return false;
            }

            return true;
        },

        validarSenhaJogador: function (senhaJogador) {
            if (!senhaJogador || senhaJogador.length < 8) {
                return false;
            }

            const regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$/;

            if (!regex.test(senhaJogador)) {
                return false;
            }

            return true;
        },

        validarConfirmacaoDeSenhaJogador: function (senhaJogador, senhaConfirmacaoJogador) {
            if (senhaJogador != senhaConfirmacaoJogador || !senhaConfirmacaoJogador) {
                return false;
            }

            return true;
        }
    };
});