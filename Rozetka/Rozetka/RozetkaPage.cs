using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rozetka
{
    public class RozetkaPage
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

        public bool SearchResult()
        {
            return _driver.FindElement(By.ClassName("g-i-tile-i-title")).Text.Contains("Hyundai");
        }

        public bool GetMoreItemsClass()
        {
            return _driver.FindElement(By.XPath("//*[@id=\"block_with_search\"]/div/div[2]/div[33]/a")).Displayed;
        }

        public IWebElement FindElement(By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(ExpectedConditions.ElementToBeClickable(by));
            }
            return _driver.FindElement(by);
        }

        public IWebElement FindElementWithWait(By by, By byNewItem, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(ExpectedConditions.ElementExists(byNewItem));
                return _driver.FindElement(by);
            }
            return _driver.FindElement(by);
        }

        public List<int> GetPrices()
        {
            Thread.Sleep(5000);
            var priceList = new List<string>();

            var priceElements = _driver.FindElements(By.ClassName("g-price-uah"));

            for (int i = 0; i < priceElements.Count; i++)
            {
                priceList.Add(
                    new string(priceElements[i].Text.Where(c => c >= '0' && c <= '9').ToArray()));
            }

            return priceList.Select(p => int.Parse(p)).ToList();
        }
    }
}
