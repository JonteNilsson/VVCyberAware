import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

When("I click on settings", () => {
  cy.get('[href="/Account/Manage/Email"]').click();
});

Then("I should be on the settingspage", () => {
  cy.url().should("contain", "/Account/Manage/Email");
});
