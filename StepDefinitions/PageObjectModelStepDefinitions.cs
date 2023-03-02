using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowTags.Pages;

namespace SpecFlowTags.StepDefinitions
{
    [Binding]
    public sealed class PageObjectModelStepDefinitions
    {
        private IWebDriver driver;
        SearchPage searchPage;
        ResultPage resultPage;
        ChannelPage channelPage;

        public PageObjectModelStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Enter Youtube URL")]
        public void GivenEnterYoutubeURL()
        {
            driver.Url = "https://www.youtube.com";
        }

        [When(@"Search for Tester Talk in the search bar")]
        public void WhenSearchForTesterTalkInTheSearchBar()
        {
            searchPage = new SearchPage(driver);

            resultPage = searchPage.searchText("Testers Talk");
        }

        [When(@"Navigate to channel")]
        public void WhenNavigateToChannel()
        {
            channelPage = resultPage.clickOnChannel();
        }

        [Then(@"Verify title of the page")]
        public void ThenVerifyTitleOfThePage()
        {
            Assert.AreEqual(channelPage.getTitle(), "YouTube");
        }
    }
}