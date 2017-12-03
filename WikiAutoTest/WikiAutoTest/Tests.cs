using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using WikiAutoTest.Pages.Google;
using WikiAutoTest.Pages.Wiki;

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
             // _driver = new ChromeDriver();
           _driver = new OperaDriver("C:\\Users\\Khrystyna\\source\\repos\\operadriver.exe");
            _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
           // _driver.Manage().Window.Maximize();
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
            var mainPage = new WikiMainPage(_driver, _webDriverWait);

            IWebElement dayMonth = null;
            IWebElement year = null;
            _webDriverWait.Until(d =>
            {
                dayMonth = d.FindElement(By.CssSelector("#mw-content-text > div > div > div:nth-child(2) > table > tbody > tr > td:nth-child(2) > div > a:nth-child(1)"));
                year = d.FindElement(By.CssSelector("#mw-content-text > div > div > div:nth-child(2) > table > tbody > tr > td:nth-child(2) > div > a:nth-child(2)"));

                return dayMonth != null && year != null;
            });

            Assert.AreEqual("27 листопада", dayMonth.GetAttribute("title"));
            Assert.AreEqual("2017", year.GetAttribute("title"));
        }

        [TestMethod]
        public void CheckOpeningCurrentEvents()
        {
            var mainPage = new WikiMainPage(_driver, _webDriverWait);

            _driver.FindElement(By.LinkText("Поточні події")).Click();
            Assert.AreEqual("Вікіпедія:Поточні події — Вікіпедія", _driver.Title);
        }

        [TestMethod]
        public void CheckNews()
        {
            var mainPage = new WikiMainPage(_driver, _webDriverWait);
            _driver.FindElement(By.LinkText("Поточні події")).Click();
            IWebElement element = _driver.FindElement(By.XPath("//*[@id='mw-content-text']/div/table/tbody/tr[1]/td[1]/div[4]/ul/li[14]/ul/li"));
            string s = element.Text;
            Assert
                .AreEqual("Вчені знайшли невідому раніше порожнину в піраміді Хеопса. Це перше велике відкриття у цій піраміді з XIX століття[24][25]", s);
        }

        [TestMethod]
        public void CheckSearhFealdOnWiki()
        {
            var mainPage = new WikiMainPage(_driver, _webDriverWait);
            _driver.FindElement(By.Id("searchInput")).SendKeys("Апаратне забезпечення");
            _driver.FindElement(By.Id("searchButton")).Click();
            Assert.AreEqual("Апаратне забезпечення — Вікіпедія", _driver.Title);
        }

        [TestCleanup]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}
