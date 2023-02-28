Feature: DataTable Data Driven Testing

Search for the Testers Talk with table data

@DataTableDataDrivenTesting
Scenario Outline: Examples Data Driven Testing
	Given Open the browser
	When Enter the URL
	Then Enter search keyword in Youtube
	| searchKey				|
	| 1st datatable data set|
	| 2nd datatable data set|
	| 3rd datatable data set|