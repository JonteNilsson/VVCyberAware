Cypress.Commands.add("login", (username, password) => {
  cy.visit("/Account/Login");
  cy.get("#Username").type(username);
  cy.get("#password").type(password);
  cy.get('[type="submit"]').click();
});
