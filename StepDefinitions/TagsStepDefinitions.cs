using NUnit.Framework;
using OpenQA.Selenium;

namespace SpecFlowTags.StepDefinitions
{
    [Binding]
    public sealed class TagsStepDefinitions
    {
        private IWebDriver driver;

        public TagsStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Browser is opened")]
        public void GivenBrowserIsOpened()
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver();
        }

        [Then(@"User navigates to URL")]
        public void ThenUserNavigatesToURL()
        {
            driver.Url = "https://www.cbc.ca";
            driver.Manage().Window.Maximize();
        }

        [Then(@"User verifies title")]
        public void ThenUserVerifiesTitle()
        {
            Assert.AreEqual(driver.Title, "CBC.ca - watch, listen, and discover with Canada's Public Broadcaster");
        }

        [Then(@"User verifies the menu button is not null")]
        public void ThenUserVerifiesTheMenuButtonIsNotNull()
        {
            IWebElement menuButton = driver.FindElement(By.XPath("//*[@id=\"menuButton\"]"));
            Assert.IsNotNull(menuButton);
        }

        [Then(@"User verifies the headline is not null")]
        public void ThenUserVerifiesTheHeadlineIsNotNull()
        {
            IWebElement headline = driver.FindElement(By.ClassName("headline"));
            Assert.IsNotNull(headline);
        }

        [Then(@"User closes the browser")]
        public void ThenUserClosesTheBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}