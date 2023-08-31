using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowDemoBDD.StepDefinitions
{
    [Binding]
    public sealed class SearchKeyword
    {
        private IWebDriver driver;

        public SearchKeyword(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Given(@"user opens chrome browser")]
        public void GivenUserOpensChromeBrowser()
        {
            driver.Url = "https://www.google.com/";
        }



        [When(@"user type a (.*) in input field")]
        public void WhenUserTypeAKeywordInInputField(String keyword)
        {
            IWebElement search_field = driver.FindElement(By.Id("APjFqb"));
            search_field.SendKeys(keyword);
            Thread.Sleep(5000);
        }



        [When(@"user clicks on Search button")]
        public void WhenUserClicksOnSearchButton()
        {
            IWebElement search_field = driver.FindElement(By.Id("APjFqb"));
            search_field.SendKeys(Keys.Return);
        }



        [Then(@"search results is shown to user")]
        public void ThenSearchResultsIsShownToUser()
        {
            String actual_title = driver.Title.ToString();
            Assert.IsTrue(actual_title.Contains("Selenium"));    
        }

    }

}
