using OpenQA.Selenium;
using System;
using System.Configuration;

namespace AutoTest.webdriver
{
    public class Browser
    {
        private static Browser _currentBrowser;
        private static IWebDriver _driver;
        public static BrowserFactory.BrowserType CurrentBrowser;
        public static int ImplWait;
        public static double TimeoutForElement;
        private static string _browser;

        private Browser()
        {

        }

        private static void InitParams()
        {
            ImplWait = Convert.ToInt32(System.Drawing.Configuration.typeof)
        }

    }
}
