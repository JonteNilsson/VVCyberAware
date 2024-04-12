import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("I am on the login page", () => {
  cy.visit("/Account/Login");
});

When("I type {string} in {string}", (a, b) => {
  cy.get(b).type(a);
});

When("I click the submit button", () => {
  cy.get(".lognin-btn").click();
});

Then("I should see the categories", () => {
  // TODO: implement step
});
