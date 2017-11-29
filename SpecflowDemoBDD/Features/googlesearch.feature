Feature: GoogleSearch
 Feature to test google page search functionality
 Here we will test auto-search as well as navigating to search result

@SmokeTest
@Browser:Chrome
Scenario: Google search for excute automation
 Given I have navigated to Google page
 And I see the google page fully loaded
 When I type search keyword as
 | keyword           |
 | excute automation |
 Then I should see the result for keyword
 | keyword           |
 | Excute Automation |