using NUnit.Framework;
using NUnit;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using System.Configuration;



namespace AutoTest
{
    [TestFixture]

    public class TestWiki
    {
        private IWebDriver driver;
        private string baseURL;
        string configValue = ConfigurationSettings.AppSettings["browser"];

        [OneTimeSetUp] // вызывается перед началом запуска всех тестов
        public void BeforeTestSuit()
        {
            if ("Chrome".Equals(this.configValue))
            {
                var option = new ChromeOptions();
                option.AddArgument("disable-infobars");
                this.driver = new ChromeDriver(option);
            }
            else
            {
                this.driver = new FirefoxDriver();

            }
           

            this.baseURL = "https://www.google.com";

            this.driver.Navigate().GoToUrl(baseURL);
        }

        [OneTimeTearDown] //вызывается после завершения всех тестов
        public void AfterTestSuit()
        {
        }

        [SetUp] // вызывается перед каждым тестом
        public void SetUp()
        {
        }

        [Test]

        public void FindPage()
        {
            driver.FindElement(By.Id("lst-ib")).SendKeys("Wikipedia");
            driver.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
            driver.FindElement(By.LinkText("Вікіпедія"));
            // Assert.AreEqual("Вікіпедіяgh", driver.Title);
           // Assert.AreSame("Вікіпедіяgh", driver.Title);
        }

        public void GoToFindedPage()
        {
           
           
        }

        [TearDown] // вызывается после каждого теста
        public void TearDown()
        {
            //this.driver.Close();
            //this.driver.Quit();
        }


    }
}
