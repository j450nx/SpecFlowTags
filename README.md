1. install SpecFlow extension
2. create new SpecFlow project
3. create new feature
4. define steps
5. uner Dependencies, Manage NuGet Packages... install Selenium.WebDriver pacakge
6. uner Dependencies, Manage NuGet Packages... install DotNetSeleniumExtras.WaitHelpers package

SpecFlow Living Doc:
1. dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
2. cd workspace\SpecFlowProject1\bin\Debug\net6.0
3. livingdoc test-assembly PROJECT_NAME.dll -t TestExecution.json

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