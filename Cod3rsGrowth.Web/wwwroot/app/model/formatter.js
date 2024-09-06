sap.ui.define([
    "sap/ui/model/type/DateTime"
], function (DateTime) {
    "use strict";

    return {
        datas: function (dataBanco) {
            if (!dataBanco) {
                return "";
            }

            var formatadorData = new Date(dataBanco);
            var padraoData = new DateTime({ pattern: "dd/MM/yyyy" });
            
            return padraoData.formatValue(formatadorData, "string");
        },

        statusContaJogador: function (sStatusConta) {
            const oResourceBundle = this.getOwnerComponent().getModel("i18n").getResourceBundle();
            const textoContaAtiva = "Formatter.ContaAtiva";
            const textoContaInativa = "Formatter.ContaInativa";

            switch (sStatusConta) {
                case true: return oResourceBundle.getText(textoContaAtiva);
                case false: return oResourceBundle.getText(textoContaInativa);
            }
        }
    };
});