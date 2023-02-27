using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class Feature1StepDefinitions
    {
        private IWebDriver driver;

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver();
        }

        [When(@"Enter the URL")]
        public void WhenOpenTheURL()
        {
            driver.Url = "https://www.youtube.com";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Then(@"Search for Testers Talk")]
        public void ThenSearchForTestersTalk()
        {
            //driver.SwitchTo().Window(driver.WindowHandles[0]);
            //new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"search\"]")));
            IWebElement searchBox = driver.FindElement(By.XPath("//*[@id=\"search\"]"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            searchBox.SendKeys("Testers Talk");
            searchBox.SendKeys(Keys.Enter);
            driver.Close();
            driver.Quit();
        }
    }
}