Feature: Tags

@Smoke
Scenario: Verify CBC title
	Given Browser is opened
	Then User navigates to URL
	Then User verifies title
	Then User closes the browser

@Sanity
Scenario: Verify menu button
	Given Browser is opened
	Then User navigates to URL
	Then User verifies the menu button is not null
	Then User closes the browser

@Sanity @Regression
Scenario: Verify headline class
	Given Browser is opened
	Then User navigates to URL
	Then User verifies the headline is not null
	Then User closes the browser
