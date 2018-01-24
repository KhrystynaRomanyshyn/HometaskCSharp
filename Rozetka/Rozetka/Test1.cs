using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace Rozetka
{
    [TestClass]
    [Parallelizable(ParallelScope.Fixtures)]
    public class Test1
    {
        IWebDriver _driver;
        RozetkaPage page;

        [TestInitialize]
        public void SetUp()
        {
            _driver = new RemoteWebDriver(new Uri("http://10.17.184.26:4444/wd/hub"), new ChromeOptions());

            //_driver = new ChromeDriver();
            //page = new RozetkaPage(_driver);
            page = new RozetkaPage(_driver);

        }

        [TestMethod]
        public void HuindaySearch()
        {

            page.Open();
            page.SearchFor("Hyundai");
            //  NUnit.Framework.Assert.IsTrue(page.SearchResult());
            NUnit.Framework.Assert.IsTrue(page.isNameProduct());
            NUnit.Framework.Assert.IsTrue(page.GetMoreItemsClass(), "'Показать еще 32 товара' element hasn't been displayed");
        }

        [TestMethod]
        public void Filtering()
        {
            page.OpenSmartphonesSection();
            page.FindElement(By.Id("filter_producer_69"), 10).Click();
            page.FindElementWithWait(By.Id("filter_producer_12"), By.Id("reset_filter69"), 15).Click();
            page.FindElementWithWait(By.CssSelector("#sort_view > a"), By.Id("reset_filter12"), 15).Click();
            page.FindElement(By.Id("filter_sortexpensive"), 15).Click();

            var prices = page.GetPrices();
            int[] notSortedPrices = new int[prices.Count];
            prices.CopyTo(notSortedPrices);

            prices.Sort();
            prices.Reverse();

            for (int i = 0; i < prices.Count; i++)
            {
                NUnit.Framework.Assert.AreEqual(prices[i], notSortedPrices[i]);
            }
        }

        [TestCleanup]
        public void TearDown()
        {
          _driver.Quit();
        }
    }
}
