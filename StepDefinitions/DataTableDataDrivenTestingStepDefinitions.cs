using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class DataTableDataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;

        public DataTableDataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Enter search keyword in Youtube")]
        public void ThenEnterSearchKeywordInYoutube(Table table)
        {
            IWebElement searchBox = driver.FindElement(By.XPath("//*[@name='search_query']"));
            var searchCriteria = table.CreateSet<SearchKeyTestData>();

            foreach(var keyword in searchCriteria)
            {
                searchBox.Clear();
                searchBox.SendKeys(keyword.searchKey);
                searchBox.SendKeys(Keys.Enter);
            }
        }
        public class SearchKeyTestData
        {
            public string searchKey { get; set; }
        }
    }
}