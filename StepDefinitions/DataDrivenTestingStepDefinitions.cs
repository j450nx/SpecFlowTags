using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class DataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;

        public DataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Search for '([^']*)'")]
        public void ThenSearchFor(string searchKey)
        {
            IWebElement searchBox = driver.FindElement(By.XPath("//*[@name='search_query']"));
            Console.WriteLine("Passing in: " + searchKey);
            searchBox.SendKeys(searchKey);
            searchBox.SendKeys(Keys.Enter);
        }

    }
}