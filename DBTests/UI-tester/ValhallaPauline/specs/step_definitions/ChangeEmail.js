import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

When("I am the settings page", () => {
  cy.visit("/Account/Manage/Email");
});

When("I click on the new email input", () => {
  cy.get(":nth-child(4) > .form-control").click();
});

When("I type in my new email {string}", (a) => {
  cy.get(":nth-child(4) > .form-control").type(a);
});

When("I click on the submit button", () => {
  cy.get(".w-100").click();
});

Then("I Should see a confirmation notification", () => {
  cy.get(".alert").should("be.visible");
});
