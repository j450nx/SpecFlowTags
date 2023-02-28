using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class SearchPage
    {
        private IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By searchBox = By.XPath("//*[@name='search_query']");
        
        //Abstraction method
        public ResultPage searchText(String text)
        {
            driver.FindElement(searchBox).SendKeys(text);
            driver.FindElement(searchBox).SendKeys(Keys.Enter);
            return new ResultPage(driver);
        }
    }
}
