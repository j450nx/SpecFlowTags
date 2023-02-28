using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class ExamplesDataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;

        public ExamplesDataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Search with (.*)")]
        public void ThenSearchWithSpecflowByTestersTalk(String searchKey)
        {
            IWebElement searchBox = driver.FindElement(By.XPath("//*[@name='search_query']"));
            searchBox.SendKeys(searchKey);
            searchBox.SendKeys(Keys.Enter);
        }
    }
}