using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WikiAutoTest.Pages.Google
{
    public class GoogleMainPage : Page
    {
        private const string SearchFieldId = "lst-ib";
        private IWebElement _searchField;

        public GoogleMainPage(
            IWebDriver webDriver,
            WebDriverWait webDriverWait) : base(webDriver, webDriverWait)
        {
        }

        protected override string Url
        {
            get { return "https://www.google.com"; }
        }

        protected override void Initialize()
        {
            base.Initialize();

            WebDriverWait.Until(d =>
            {
                _searchField = d.FindElement(By.Id(SearchFieldId));
                return _searchField != null;
            });
        }

        public SearchResultPage GetSearchResult(string query)
        {
            _searchField.SendKeys(query);
            _searchField.SendKeys(Keys.Enter);

            return new SearchResultPage(WebDriver, WebDriverWait);
        }
    }
}