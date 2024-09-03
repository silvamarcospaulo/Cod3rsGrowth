sap.ui.define([
    "sap/ui/model/type/DateTime"
], function (DateTime) {
    "use strict";

    return {
        datas: function (sData) {
            if (!sData) {
                return "";
            }

            var oType = new DateTime({ pattern: "dd/MM/yyyy" });

            var oDate = new Date(sData);

            return oType.formatValue(oDate, "string");
        },

        statusContaJogador: function (sStatusConta) {
            const oResourceBundle = this.getOwnerComponent().getModel("i18n").getResourceBundle();
            switch (sStatusConta) {
                case true: return oResourceBundle.getText("Formatter.ContaAtiva");
                case false: return oResourceBundle.getText("Formatter.ContaInativa");
            }
        }
    };
});
