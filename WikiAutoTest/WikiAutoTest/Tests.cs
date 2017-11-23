using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using WikiAutoTest.Pages.Google;

namespace WikiAutoTest
{
    [TestClass]
    public class Tests
    {
        IWebDriver _driver;
        WebDriverWait _webDriverWait;

        [TestInitialize]
        public void StartUp()
        {
            _driver = new ChromeDriver();
            _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        [TestMethod]
        public void GoogleSearchTest()
        {
            var mainPage = new GoogleMainPage(_driver, _webDriverWait);
            SearchResultPage searchResultPage = mainPage.GetSearchResult("Wikipedia");
            searchResultPage.OpenLink("Вікіпедія");
            TimeSpan.FromSeconds(2);
            Assert.AreEqual("Вікіпедія", _driver.Title);
        }

        [TestMethod]
        public void CheckDate()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://uk.wikipedia.org/wiki/Головна_сторінка");

            IWebElement dayMonth = null;
            IWebElement year = null;
            _webDriverWait.Until(d =>
            {
                dayMonth = d.FindElement(By.CssSelector("#mw-content-text > div > div > div:nth-child(2) > table > tbody > tr > td:nth-child(2) > div > a:nth-child(1)"));
                year = d.FindElement(By.CssSelector("#mw-content-text > div > div > div:nth-child(2) > table > tbody > tr > td:nth-child(2) > div > a:nth-child(2)"));

                return dayMonth != null && year != null;
            });

            Assert.AreEqual("23 листопада", dayMonth.GetAttribute("title"));
            Assert.AreEqual("2017", year.GetAttribute("title"));
        }

        [TestCleanup]
        public void CleanUp()
        {
           // driver.Quit();
        }
    }
}
