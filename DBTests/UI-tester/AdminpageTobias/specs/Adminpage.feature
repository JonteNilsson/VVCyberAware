Feature: Adminpage
    Scenario: Category clicked
        Given I am logged in as an Admin
        And I am on the Adminpage
        When I click on first category
        Then I will see description

    Scenario: Visit page when not Admin
        Given I am logged in as a member
        And I am on the homepage
        When I navigate to Adminpage
        Then I will see access denied

    Scenario: Admin click on "go to segment" button
        Given I am logged in as an Admin
        And I am on the Adminpage
        When I click on first category
        And I click on Gå till segment button
        Then I will go to correct segment page

    Scenario: Admin click add segment
        Given I am logged in as an Admin
        And I am on the Adminpage
        When I click on first category
        And I click on Lägg till segment button
        Then I will go to add segment page

    Scenario: Admin add segment to first category
        Given I am logged in as an Admin
        And I am on the add segment page for the first category
        When I enter "<segmentName>" in the input field
        And I click the Lägg till button
        Then I will go to Adminpage
        And I will see "<segmentName>" in segmentList

        Examples:
            | segmentName      |
            | Test add segment |
            | Test add 2       |

# Scenario: Admin remove segments that was added
#     Given I am logged in as an Admin
#     And I am on the Adminpage
#     When I click on first category
#     And I click on remove segment on "<segmentName>" segment
#     Then I will not see the segment "<segmentName>"

#     Examples:
#         | segmentName      |
#         | Test add segment |
#         | Test add 2       |
