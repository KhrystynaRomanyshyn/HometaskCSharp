using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WikiAutoTest.Pages.Google
{
    public class SearchResultPage : Page
    {
        private const string SearchResultId = "ires";

        public SearchResultPage(
            IWebDriver webDriver,
            WebDriverWait webDriverWait) : base(webDriver, webDriverWait)
        {
        }

        protected override void Initialize()
        {
            WebDriverWait.Until(d =>
            {
                return d.FindElement(By.Id(SearchResultId)) != null;
            });
        }

        public void OpenLink(string linkText)
        {
            IWebElement hyperLink = WebDriver.FindElement(By.LinkText(linkText));
            hyperLink.Click();
        }
    }
}