sap.ui.define([
	"sap/ui/core/XMLView"
], (XMLView) => {
	"use strict";

	XMLView.create({
		viewName: "ui5.mtgdeckbuilder.webapp.jogador.view.App"
	}).then((oView) => oView.placeAt("content"));
});