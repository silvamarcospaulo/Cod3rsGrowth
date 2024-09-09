sap.ui.define([
    "sap/ui/model/json/JSONModel"
], function (JSONModel) {
    "use strict";

    return {
        validadorCriacaoJogador: function (view, nomeDoModelo) {
            debugger

            let jogador = view.getModel(nomeDoModelo).getData();

            this.validarNome(jogador);
            this.validarSobrenome(jogador);
            this.validarDataNascimento(jogador);
            this.validarUsuario(jogador);
            this.validarSenha(jogador);
        },

        validarNomeJogador: function(nomeJogador){
            debugger
            if((nomeJogador == null) || (nomeJogador == ""))
                return false;
        }
    };
});

