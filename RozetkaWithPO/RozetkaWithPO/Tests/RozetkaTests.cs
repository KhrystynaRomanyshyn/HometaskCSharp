using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RozetkaWithPO.RozetkaPages;
using RozetkaWithPO.RozetkaSteps;

namespace RozetkaWithPO.Tests
{
    [TestFixture]
    class RozetkaTests
    {
        IWebDriver _driver;
        RozetkaPage _page;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _page = new RozetkaPage(_driver);
        }

        [Test]
        public void HuindaySearch()
        {
            var steps = new RozetkaSteps.RozetkaSteps(_driver);
            steps.Open(_page.);

            _page.Open();
            page.SearchFor("Hyundai");
            //  NUnit.Framework.Assert.IsTrue(page.SearchResult());
            NUnit.Framework.Assert.IsTrue(page.isNameProduct());
            NUnit.Framework.Assert.IsTrue(page.GetMoreItemsClass(), "'Показать еще 32 товара' element hasn't been displayed");
        }

    }
}
