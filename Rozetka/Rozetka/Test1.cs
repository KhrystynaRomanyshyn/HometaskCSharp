using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium.Support;

namespace Rozetka
{
    [TestClass]
    public class Test1
    {
        IWebDriver driver;
        RozetkaPage page;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            page = new RozetkaPage(driver);
        }

        [TestMethod]
        public void HuindaySearch()
        {
            //IWebDriver driver = new ChromeDriver();
            //RozetkaPage page = new RozetkaPage(driver);
            page.Open();
            page.SearchFor("Hyundai");
            NUnit.Framework.Assert.AreEqual(page.SearchResult(), "Hyundai");
            NUnit.Framework.Assert.AreEqual(page.GetMoreItemsClass(), "novisited g-i-more-link");
        }

        [TestMethod]
        public void Filtering()
        {
            page.OpenSmartphonesSection();
            page.FindElement(By.Id("filter_producer_69"), 10).Click();
            page.FindElement(By.Id("filter_producer_12"), 10).Click();
          //  driver.FindElement(By.Id("filter_producer_12")).Click();
            page.FindElement(By.Name("drop_link"), 15).Click();
            page.FindElement(By.Id("filter_sortcheap"), 15).Click();
        }

        [TearDown]
        public void TearDown()
        {
           driver.Quit();
        }
    }
}
