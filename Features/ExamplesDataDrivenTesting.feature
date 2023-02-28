Feature: Examples Data Driven Testing

Search for the Testers Talk with parameters

@ExampleDataDrivenTesting
Scenario Outline: Examples Data Driven Testing
	Given Open the browser
	When Enter the URL
	Then Search with <searchKey>
	Examples:
	| searchKey                |
	| specflow by testers talk |
	| selenium by testers talk |