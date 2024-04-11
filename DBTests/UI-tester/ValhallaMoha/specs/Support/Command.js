Cypress.Commands.add("login", (Username, Password) => {
  cy.visit("/Account/login");
  cy.get("#Username").type(Username);
  cy.get("#password").type(Password);
  cy.get(".lognin-btn").click();
});
