sap.ui.define([
    "sap/ui/model/json/JSONModel",
], function (JSONModel) {
    "use strict";

    return {

        validarSeCampoPossuiValor: function (valorDoCampo){
            if (!valorDoCampo) {
                return false;
            }

            return true;
        },

        validarSeCampoPossuiSomenteLetrasMaiusculasEMinusculas: function (valorDoCampo) {
            const regex = /[^a-zA-Z\s]/;

            if (regex.test(valorDoCampo)) {
                return false;
            }

            return true;
        },

        validarSeJogadorEMaiorQueTrezeAnos: function (dataNascimentoJogador) {
            const idadeMinimaParaCriarConta = 13;

            let dataNascimento = new Date(dataNascimentoJogador);

            let dataNascimentoMais13Anos = new Date(dataNascimento);
            dataNascimentoMais13Anos.setFullYear(dataNascimento.getFullYear() + idadeMinimaParaCriarConta);

            let dataAtual = new Date();
            if (dataNascimentoMais13Anos > dataAtual) {
                return false;
            }

            return true;
        },

        validarCaracteresUsuarioJogador: function (usuarioJogador) {
            const regex = /^[a-z]+$/;

            if (!regex.test(usuarioJogador)) {
                return false;
            }

            return true;
        },

        validarUsuarioPossuiAoMenosSeisDigitos: function (usuarioJogador) {
            const tamanhoMinimoUsuario = 6;

            if (usuarioJogador.length < tamanhoMinimoUsuario) {
                return false;
            }

            return true;
        },

        validarSenhaPossuiOsCaracteresNecessarios: function (senhaJogador) {
            const regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$/;

            if (!regex.test(senhaJogador)) {
                return false;
            }

            return true;
        },

        validarSenhaPossuiAoMenosOitoDigitos: function (senhaJogador) {
            const tamanhoMinimoSenha = 8;

            if (senhaJogador.length < tamanhoMinimoSenha) {
                return false;
            }

            return true;
        },

        validarSeOsValoresDosCamposSaoIguais: function (valorDoCampo, valorDoCampoDeConfirmacao){
            if (valorDoCampo !== valorDoCampoDeConfirmacao) {
                return false;
            }

            return true;
        },
    };
});