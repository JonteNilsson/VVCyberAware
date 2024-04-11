import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("I am on the login page", () => {
  cy.visit("/Account/Login");
});

When("I enter {string} in {string}", (a, b) => {
  cy.get(b).type(a);
});

When("I click login button", () => {
  cy.get(".lognin-btn").click();
});

Then("I should be redirected to the homepage", () => {
  cy.url().should("contain", "/Home");
});
