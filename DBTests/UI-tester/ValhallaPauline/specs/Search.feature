Feature: Searchbar

    Background: 
        Given I am logged in
    
    Scenario: Search as a user
    When I click in the search bar
    And I type "sä"
    Then I should see the filtered result on the page

   