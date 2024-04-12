import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("I am logged in as an Admin", () => {
  cy.visit("/Account/Login");
  cy.get("#Username").type("Admin");
  cy.get("#password").type("Password1234!");
  cy.get(".lognin-btn").click();
});

Given("I am on the Adminpage", () => {
  cy.visit("/Admin");
});

When("I click on first category", () => {
  cy.wait(500);
  cy.get(".list-group > :nth-child(1) ").should("exist").click();
  cy.wait(500);
});

Then("I will see description", () => {
  cy.get(".content > .list-group > .list-group-item > .dropdown-content")
    .scrollIntoView()
    .should("be.visible");
});

Given("I am logged in as a member", () => {
  cy.visit("/Account/Login");
  cy.get("#Username").type("user");
  cy.get("#password").type("Password1234!");
  cy.get(".lognin-btn").click();
});

Given("I am on the homepage", () => {
  cy.visit("/home");
});

When("I navigate to Adminpage", () => {
  cy.visit("/Admin");
});

Then("I will see access denied", () => {
  cy.get(".content > h4").invoke("text").should("include", "not authorized");
});

/* No duplicate steps, this one already above
Given('I am logged in as an Admin', () => {});*/

/* No duplicate steps, this one already above
Given('I am on the Adminpage', () => {});*/

/* When('I click on first category', () => {
  // TODO: implement step
});*/

When("I click on Gå till segment button", () => {
  cy.wait(500);
  cy.get(":nth-child(1) > .btn-warning").click({ force: true });
  cy.wait(500);
});

Then("I will go to correct segment page", () => {
  cy.url().should("include", "admin/segment/1");
});

/* No duplicate steps, this one already above
Given('I am logged in as an Admin', () => {});*/

/* No duplicate steps, this one already above
Given('I am on the Adminpage', () => {});*/

/* No duplicate steps, this one already above
When('I click on first category', () => {});*/

When("I click on Lägg till segment button", () => {
  cy.get(
    ":nth-child(1) > .dropdown-content > .list-group > .btn-primary"
  ).click({ force: true });
  cy.wait(500);
});

Then("I will go to add segment page", () => {
  cy.url().should("include", "admin/edit/segment");
});

/* No duplicate steps, this one already above
Given('I am logged in as an Admin', () => {});*/

Given("I am on the add segment page for the first category", () => {
  cy.visit("/admin");
  cy.wait(500);
  cy.get(".list-group > :nth-child(1) ").should("exist").click();
  cy.wait(500);
  cy.get(".btn-primary").click();
  cy.wait(500);
});

When("I enter {string} in the input field", (segmentName) => {
  cy.wait(500);
  cy.get(".w-100").type(segmentName);
  cy.wait(500);
});

When("I click the Lägg till button", () => {
  cy.wait(500);
  cy.get(".btn-warning").click();
  cy.wait(500);
});

Then("I will go to Adminpage", () => {
  cy.url().should("not.include", "segment");
});

Then("I will see {string} in segmentList", (segmentName) => {
  cy.wait(500);
  cy.get(".list-group > :nth-child(1) ").should("exist").click();
  cy.wait(500);
  cy.get(".content > .list-group > .list-group-item > .dropdown-content")
    .children()
    .each(($child) => {
      if ($child.find(".col-6").length > 0) {
        cy.wrap($child)
          .find(".col-6")
          .invoke("text")
          .should("include", segmentName);
      }
    });
});

/* No duplicate steps, this one already above
Given('I am logged in as an Admin', () => {});*/

/* No duplicate steps, this one already above
Given('I am on the Adminpage', () => {});*/

/* No duplicate steps, this one already above
When('I click on first category', () => {});*/

When("I click on remove segment on {string} segment", (segmentName) => {
  cy.get(".content > .list-group > .list-group-item > .dropdown-content")
    .children(".list-group") // Select children with class .list-group
    .each(($child) => {
      cy.wrap($child)
        .children() // Iterate over the children
        .each(($listChild) => {
          if ($listChild.find(".col-6")) {
            cy.wrap($listChild)
              .find(".col-6")
              .invoke("text")
              .then((text) => {
                while (text.includes(segmentName)) {
                  cy.wrap($listChild) // Click the .btn-danger button in current .list-group
                    .find(".btn-danger")
                    .click({ force: true });

                  cy.wait(1000);
                  cy.get("dialog > :nth-child(2)").click({ force: true });
                  cy.wait(1000);
                }
              });
          }
        });
    });
});

Then("I will not see the segment {string}", (segmentName) => {
  // TODO: implement step
});
