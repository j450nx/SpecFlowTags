using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class Feature1StepDefinitions
    {
        private IWebDriver driver;

        public Feature1StepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            //driver = new OpenQA.Selenium.Edge.EdgeDriver();
        }

        [When(@"Enter the URL")]
        public void WhenOpenTheURL()
        {
            driver.Url = "https://www.youtube.com";
            //driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Then(@"Search for Testers Talk")]
        public void ThenSearchForTestersTalk()
        {
            //driver.SwitchTo().Window(driver.WindowHandles[0]);
            //new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@name='search_query']")));
            IWebElement searchBox = driver.FindElement(By.XPath("//*[@name='search_query']"));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            searchBox.SendKeys("Testers Talk");
            searchBox.SendKeys(Keys.Enter);
            //driver.Close();
            //driver.Quit();
        }
    }
}