import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("I am on valhalla App", () => {
  // TODO: implement step
  cy.login("User", "Password1234!");
  cy.url().should("contain", "/Home");
});

When("I click on logut button", () => {
  cy.get(".nav-link").click();
});

Then("I should be redirected to login page", () => {
  cy.url().should("contain", "/Account/Login");
});
