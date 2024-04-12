Feature: Login and search

   Scenario: Login with valid credentials
    Given I am on the login page
    When I type "User" in "#Username"
    And I type "Password1234!" in "#password"
    And I click the submit button
    Then I should see the categories