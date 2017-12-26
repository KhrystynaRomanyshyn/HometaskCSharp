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
            NUnit.Framework.Assert.IsTrue(page.SearchResult());
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

          var a=  page.SortingResultPrice();
            page.SortPrice(a);
            // NUnit.Framework.Assert
        }

        [TestCleanup]
        public void TearDown()
        {
           driver.Quit();
        }
    }
}
