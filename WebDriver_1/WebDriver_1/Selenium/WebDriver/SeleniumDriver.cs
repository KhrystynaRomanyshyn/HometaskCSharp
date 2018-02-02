﻿namespace WebDriver_1.Selenium
{ 
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium;

    public  class SeleniumDriver
    {
        private static IWebDriver Driver;
        private SeleniumDriver() { }

        public static IWebDriver GetDriver()
            => Driver ?? (Driver = new ChromeDriver());

    }
}
