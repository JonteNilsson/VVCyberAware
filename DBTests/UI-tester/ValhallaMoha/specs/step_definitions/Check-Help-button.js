import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("I am on valhalla page", () => {
  // TODO: implement step
  cy.login("User", "Password1234!");
  cy.url().should("contain", "/Home");
});

When("I click help button", () => {
  cy.get('[href="/HelpSupport"]').click();
});

Then("I should be redirected to support page", () => {
  cy.url().should("contain", "/HelpSupport");
});
