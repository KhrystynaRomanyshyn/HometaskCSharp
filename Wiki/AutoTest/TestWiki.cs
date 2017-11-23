using NUnit.Framework;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;



namespace AutoTest
{
    public class TestWiki
    {


        IWebDriver driver = new ChromeDriver();


        [SetUp] // вызывается перед каждым тестом
        public void SetUp()
        {
        }

        [Test]
        public void TEST_1()
        {
            driver.Url = "https://www.google.com";
            driver.FindElement(By.Id("lst-ib")).SendKeys("Wikipedia");
            driver.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
            driver.FindElement(By.LinkText("Вікіпедія")).Click();
           // Assert.AreEqual("Вікіпедіяgh", driver.Title);
            Assert.AreSame("Вікіпедіяgh", driver.Title);

        }

        [TearDown] // вызывается после каждого теста
        public void TearDown()
        {
        }

       
    }
}
