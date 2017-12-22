using OpenQA.Selenium;
using NUnit;
using OpenQA.Selenium.Chrome;

namespace RozetkaTest
{
    public class RozetkaPage
    {

        private IWebDriver _driver;

        //public RozetkaPage(IWebDriver driver)
        //{
        //    _driver = driver;
        //}

        public const string URL = "https://rozetka.com.ua";

        public IWebElement SearchField => _driver.FindElement(By.ClassName("rz-header-search-input-text passive"));

        public void Open()
        {
            _driver.Navigate().GoToUrl(URL);
        }

        public void SearchFor(string searchText)
        {
           
        }
    }
}
