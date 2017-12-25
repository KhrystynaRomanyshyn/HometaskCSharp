using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozetka
{
    class RozetkaPage
    {
        private IWebDriver _driver;

        public RozetkaPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public const string URL = "https://rozetka.com.ua";

        public void Open()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);
        }

        public void OpenSmartphonesSection()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://rozetka.com.ua/mobile-phones/c80003/preset=smartfon/");
        }

        public void SearchFor(string searchText)
        {
            _driver.FindElement(By.Name("text")).SendKeys(searchText);
            _driver.FindElement(By.Name("text")).Submit();
        }

        public string SearchResult()
        {
           return _driver.FindElement(By.Id("search_result_title_text")).Text;
        }

        public string GetMoreItemsClass()
        {
           return _driver.FindElement(By.XPath("//*[@id=\"block_with_search\"]/div/div[2]/div[33]/a")).GetAttribute("class");
        }

        public IWebElement FindElement(By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return _driver.FindElement(by);
        }
    }
}
