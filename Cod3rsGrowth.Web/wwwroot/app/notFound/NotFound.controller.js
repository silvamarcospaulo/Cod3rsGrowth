sap.ui.define([
    "sap/ui/core/mvc/Controller"
],
    function (Controller) {
        "use strict"

        const NAME_SPACE = "mtgdeckbuilder.app.notFound.NotFound";

        return Controller.extend(NAME_SPACE, {

            IdentificadorDeIdiomas: function (oEvent) {
                var selectedItem = oEvent.getParameter("selectedItem").getKey();
                sap.ui.getCore().getConfiguration().setLanguage(selectedItem);
            },

            getRouter : function () {
                return UIComponent.getRouterFor(this);
            },
    
            onNavBack: function () {
                var oHistory, sPreviousHash;
    
                oHistory = History.getInstance();
                sPreviousHash = oHistory.getPreviousHash();
    
                if (sPreviousHash !== undefined) {
                    window.history.go(-1);
                } else {
                    this.getRouter().navTo("appHome", {}, true /*no history*/);
                }
            },

            onInit: function(){
                
            }
        });
    }
);