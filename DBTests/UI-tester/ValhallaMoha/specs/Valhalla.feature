Feature: Login functionality

Scenario: Successful login
  Given I am on the login page
  When I enter "User" in "#Username" 
  And I enter "Password1234!" in "#password"
  And I click login button
  Then I should be redirected to the homepage



