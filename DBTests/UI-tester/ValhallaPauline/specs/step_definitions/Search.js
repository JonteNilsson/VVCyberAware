import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

When("I click in the search bar", () => {
  cy.get(".row > input");
});

When("I type {string}", (a) => {
  cy.get(".row > input").type(a);
  cy.wait(500);
});

Then("I should see the filtered result on the page", () => {
  cy.get(":nth-child(1) > .d-flex").should("contain", "Cybersäkerhet");
});
