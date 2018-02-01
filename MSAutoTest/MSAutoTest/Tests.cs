using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace MSAutoTest
{

    [Binding]

    public class Tests
    {
        public IWebDriver driver = new ChromeDriver();
       
        [Given(@"I am on the Home page")]

        public void GivenIAmOnTheHomePage_(Table table)
        {
            driver.Navigate().GoToUrl("http://ecsc00106bdc.epam.com:4200/");
            driver.FindElement(By.XPath("// app-user-state/a")).Click();

            string login = table.Rows[0]["Login"];
            driver.FindElement(By.CssSelector(" div:nth-child(1) > input")).SendKeys(login);

            string password = table.Rows[0]["Password"];
            driver.FindElement(By.CssSelector(" div:nth-child(2) > input")).SendKeys(password);

            driver.FindElement(By.CssSelector(".login-form__submit-container")).Submit();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [When(@"About Us menu item is clicked")]

        public void WhenAboutUsMenuItemIsClicked()
        {
            //Actions builder = new Actions(driver);
            //builder.MoveToElement(driver.FindElement(By.CssSelector("li:nth-child(1) > a"))).Build().Perform();

            driver.FindElement(By.CssSelector("li:nth-child(1) > a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //var element = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector("li:nth-child(4) > a:hidden")));

            driver.FindElement(By.CssSelector("li:nth-child(4) > a")).Click();
        }

        [When(@"Contacts submenu item is clicked")]

        public void WhenContactsSubmenuItemIsClicked_()
        {
            
        }

        [Then(@"Contacts page opens")]

        public void ThenContactsPageOpens_()
        {
            
        }

    }
}
