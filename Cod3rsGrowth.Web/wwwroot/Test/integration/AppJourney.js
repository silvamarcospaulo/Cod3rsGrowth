sap.ui.define([
	"sap/ui/test/opaQunit",
	"./pages/App"
], (opaTest) => {
	"use strict";

	QUnit.module("Navigation");

	opaTest("Deve abrir a página com uma Page com título {i18n>App.title} e um texto {i18n>App.text}", (Given, When, Then) => {
		Given.iStartMyUIComponent({
			componentConfig: {
				name: "ui5.mtgdeckbuilder"
			}
		});

		When.onTheAppPage.iPressTheSayHelloWithDialogButton();

		Then.onTheAppPage.iShouldSeeTheHelloDialog();

		Then.iTeardownMyApp();
	});
});