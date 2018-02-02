namespace WebDriver_1
{
    using System;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    class Program
    {
        static void Main(string[] args)
        {
            //-------Driver Methods and properties
            //new chrome driver
            var driver = new ChromeDriver();

            //maximize window
            driver.Manage().Window.Maximize();

            //navigate to url
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");

            //get title
            var title = driver.Title;

            //------WebElement Methods and properties

            //find element by name

            IWebElement search =  driver.FindElement(By.Name("text"));
            //clear form
            search.Clear();

            //sned keyes
            search.SendKeys("Hyundai");

            //submit form
            search.Submit();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until((d) => { return driver.Title.Contains("ROZETKA — Результаты поиска:"); });

            driver.Quit();

        }
    }
}
