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