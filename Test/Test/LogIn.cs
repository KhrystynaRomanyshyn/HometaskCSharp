using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public class LogIn
    {
        public IWebDriver driver = new ChromeDriver();

        [Test]
        [Given(@"the main page with credentials is opened")]
        public void GivenTheMainPageWithCredentialsIsOpened()
        {
            driver.Navigate().GoToUrl("http://ecsc00105d83.epam.com:85");
        }

        [When(@"user logs in")]
        public void WhenUserLogsIn(Table table)
        {
            string login = table.Rows[0]["Login"];
            driver.FindElement(By.Id("user_email")).SendKeys(login);
            IWebElement buttonLogin = driver.FindElement(By.XPath("//button[contains(text(), 'Enter')]"));
            buttonLogin.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            string password = table.Rows[0]["Password"];
            driver.FindElement(By.CssSelector("#user_password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[contains(text(), 'Enter')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Then(@"the user's main page opens")]
        public void ThenTheUserSMainPageOpens()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            bool isElementPresent = driver.FindElement(By.XPath("//button[contains(text(), 'Logout')]")).Enabled;
            Assert.AreEqual(true, isElementPresent);
        }
    }
}
