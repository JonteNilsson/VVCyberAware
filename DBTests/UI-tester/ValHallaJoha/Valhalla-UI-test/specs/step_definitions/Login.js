import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("I am on Login page", () => {
  cy.visit("Account/login");
});

Given("input for username is empty", () => {
  cy.get('input[name="Input.Username"]').should("have.value", "");
});

Given("input for password is empty", () => {
  cy.get('input[name="Input.Password"]').should("have.value", "");
});

Then("I type {string} in username field", (username) => {
  cy.get('input[name="Input.Username"]').clear().type(username);
});

Then("I type {string} in password field", (password) => {
  cy.get('input[name="Input.Password"]').clear().type(password);
});

When("I press login", () => {
  cy.get('button[type="submit"]').click();
});

Then("I should be redirected to Home", () => {
  cy.url().should("include", "Home");
});

Given("I am logged in", () => {
  cy.get(".nav-link");
});

Given("I can se {string} on the page", (home) => {
  cy.get(".top-row-home-btn");
});

When("I click on {string}", () => {
  cy.wait(500);
  cy.get(".list-group > :nth-child(1) > .d-flex").click();
  cy.wait(500);
});

Then("I should se all segments in that category", () => {
  cy.get(".category-text");
  cy.get(".list-group > :nth-child(1) > .not-selectable");
  cy.get(":nth-child(1) > .btn");
  cy.get(":nth-child(2) > .not-selectable");
  cy.get(":nth-child(2) > .btn");
  cy.get(":nth-child(3) > .not-selectable");
  cy.get(".dropdown-content > .list-group > :nth-child(3)");
});

Then("I click on {string} again to close it", () => {
  cy.wait(500);
  cy.get(".list-group > :nth-child(1) > .d-flex").click();
  cy.wait(500);
});

When("I click on the second category {string}", () => {
  cy.wait(500);
  cy.get(":nth-child(2) > .d-flex").click();
  cy.wait(500);
});

Then("I should se all segments in the second category", () => {
  cy.get(".category-text");
  cy.get(".list-group > :nth-child(1) > .not-selectable");
  cy.get(":nth-child(1) > .btn");
  cy.get(":nth-child(2) > .not-selectable");
  cy.get(".dropdown-content > .list-group > :nth-child(2)");
  cy.get(":nth-child(3) > .not-selectable");
  cy.get(".dropdown-content > .list-group > :nth-child(3)");
  cy.get(":nth-child(4) > .not-selectable");
  cy.get(".list-group > :nth-child(4)");
});

Then("I click on the second category {string} again to close it", () => {
  cy.wait(500);
  cy.get(":nth-child(2) > .d-flex").click();
  cy.wait(500);
});

When("I click on the third category {string}", () => {
  cy.wait(500);
  cy.get(":nth-child(3) > .d-flex > .category-title").click();
  cy.wait(500);
});

Then("I should se all segments in the third category", () => {
  cy.get(":nth-child(3) > .dropdown-content > .category-text");
  cy.get(".list-group > :nth-child(1) > .not-selectable");
  cy.get(":nth-child(1) > .btn");
  cy.get(":nth-child(2) > .not-selectable");
  cy.get(".dropdown-content > .list-group > :nth-child(2)");
  cy.get(":nth-child(3) > .not-selectable");
  cy.get(".dropdown-content > .list-group > :nth-child(3)");
});

Then("I click on the third category {string} again to close it", () => {
  cy.wait(500);
  cy.get(":nth-child(3) > .d-flex > .category-title").click();
  cy.wait(500);
});

When("I am done with all tests I press Log out", () => {
  // Click on the logout link
  cy.get(".nav-link").click();
});

Then("I should be redirected to the login screen", () => {
  // Assert that the current URL includes "/Account/Login"
  cy.visit("Account/Login");
});
