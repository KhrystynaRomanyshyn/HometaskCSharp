using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTest
{
    [TestFixture]

    public abstract class SeleniumTestBase
    {
        protected IWebDriver Driver;

        public void TestInitialize()
        {
            Driver = new ChromeDriver();
        }

        public void TestCleanup()
        {
            Driver.Quit();
        }



    }
}
