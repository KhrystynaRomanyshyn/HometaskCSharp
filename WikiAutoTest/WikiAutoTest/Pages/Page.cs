using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WikiAutoTest.Pages
{
    public abstract class Page
    {
        protected virtual string Url { get; }

        protected IWebDriver WebDriver { get; }

        protected WebDriverWait WebDriverWait { get; }

        public Page(IWebDriver webDriver, WebDriverWait webDriverWait)
        {
            WebDriver = webDriver;
            WebDriverWait = webDriverWait;

            Initialize();
        }

        protected virtual void Initialize()
        {
            WebDriver.Navigate().GoToUrl(Url);
        }
    }
}