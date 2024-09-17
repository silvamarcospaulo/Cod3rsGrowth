sap.ui.define([
    "sap/ui/model/type/DateTime"
], function (DateTime) {
    "use strict";

    return {
        datas: function (dataBanco) {
            const stringVazia = "";
            const tipoPrimitivoString = "string";
            const padraoDeData = "dd/MM/yyyy";

            if (!dataBanco) {
                return stringVazia;
            }

            let formatadorData = new Date(dataBanco);
            let padraoData = new DateTime({ pattern: padraoDeData });

            return padraoData.formatValue(formatadorData, tipoPrimitivoString);
        },

        statusContaJogador: function (sStatusConta) {
            const i18n = "i18n";
            const oResourceBundle = this.getOwnerComponent().getModel(i18n).getResourceBundle();
            const textoContaAtiva = "Formatter.ContaAtiva";
            const textoContaInativa = "Formatter.ContaInativa";

            switch (sStatusConta) {
                case true: return oResourceBundle.getText(textoContaAtiva);
                case false: return oResourceBundle.getText(textoContaInativa);
            }
        },

        formatadorTipoDeBaralho: function (formatoDeJogo) {
            const nomeModeloFormatoDeJogo = "FormatoDeJogo";

            let formatoDeJogoModelo = this.getView().getModel(nomeModeloFormatoDeJogo).getData();

            return formatoDeJogoModelo[formatoDeJogo];
        }
    };
});