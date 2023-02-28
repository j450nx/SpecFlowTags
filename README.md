1. install SpecFlow extension
2. create new SpecFlow project
3. create new feature
4. define steps
5. under Dependencies, Manage NuGet Packages... install Selenium.WebDriver pacakge
6. under Dependencies, Manage NuGet Packages... install DotNetSeleniumExtras.WaitHelpers package

SpecFlow Living Doc:
1. dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
2. cd workspace\SpecFlowProject1\bin\Debug\net6.0
3. livingdoc test-assembly SpecFlowProject1.dll -t TestExecution.json

Hooks:
BeforeFeature
AfterFeature

BeforeScenario
AfterScenario

BeforeScenario Tag based

BeforeStep
AfterStep

BeforeTestRun
AfterTestRun

under Dependencies, Manage NuGet Packages... install ExtentReports package

Create TestRsults folder

Create Utility folder
Create ExtentReport utility class

How to implement Hooks in SpecFlow

Run the feature file and verify the extent report index.html report

How to capture screenshot on failed test case

Data driven testing
	[Then(@"Search for '([^']*)'")]
	Then Search for 'parameters'

Examples data driven testing: Scenario Outline, Examples, | header |, | values |
	[Then(@"Search with (.*)")]

Data table data driven testing:
	[Then(@"Enter search keyword in Youtube")]
	create table: var searchCriteria = table.CreateSet<SearchKeyTestData>();
	create method to fetch data: public string searchKey { get; set; }
	run a for loop through each data set

Page Object Model(POM) concept
	design pattern to create object repository for web elements
	each web page will be corresponding to the to their page class
	page class contains all the web page elements and methods to perform on those elements
	Pro:
	code will be cleaner and easier to understand
	object repository is independent of test scripts
	test scripts will be optimized because of elements repsective abstraction method in page classes
	Con:
	time & effort
	specific to project

	Steps:
	create feature class
	create step definitions class
	create Pages folder
	create page class, make it public
	