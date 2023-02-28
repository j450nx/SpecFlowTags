Feature: PageObjectModel

Search for the Testers Talk on Youtube

@PageObjectModel
Scenario: PageObjectModel
	Given Enter Youtube URL
	When Search for Tester Talk in the search bar
	When Navigate to channel
	Then Verify title of the page