Feature: Change Email

Background:
    Given I am logged in

    Scenario: Change Email as user
    When I am the settings page
    And I click on the new email input
    And I type in my new email "user@user.com"
    And I click on the submit button
    Then I Should see a confirmation notification