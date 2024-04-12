Feature: Login

    Scenario: Login with username and password
        Given I am on Login page
        And input for username is empty
        And input for password is empty
        Then I type "user" in username field
        And I type "Password1234!" in password field
        When I press login
        And I should be redirected to Home

    Scenario: Toggle first category while logged in
        Given I am logged in
        And I can se "Home" on the page
        When I click on "Att skydda sig mot bedrägerier"
        Then I should se all segments in that category
        Then I click on "Att skydda sig mot bedrägerier" again to close it

    Scenario: Toggle second category while logged in
        When I click on the second category "Cybersäkerhet för företag"
        Then I should se all segments in the second category
        Then I click on the second category "Cybersäkerhet för företag" again to close it

    Scenario: Toggle third category while logged in
        When I click on the third category "Cyberspionage"
        Then I should se all segments in the third category
        Then I click on the third category "Cyberspionage" again to close it

    Scenario: Log out
        When I am done with all tests I press Log out
        Then I should be redirected to the login screen
        

