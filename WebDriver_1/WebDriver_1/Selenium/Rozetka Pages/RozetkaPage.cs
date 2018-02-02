namespace WebDriver_1.Selenium
{
    using OpenQA.Selenium;
    using System.Linq;

    class RozetkaPage
    {
        private  IWebDriver  Driver;

        public RozetkaPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public string URI = "http://rozetka.com.ua/";

        public string SmartphonesURI = "http://rozetka.com.ua/mobile-phones/c80003/preset=smartfon/";

        public IWebElement SearchField => Driver.FindElement(By.Name("text"));
        private IWebElement ResultContainer => Driver.FindElement(By.Name("search_list"));
        public IWebElement[] Results => ResultContainer.FindElements(By.CssSelector(".g-i-tile-i")).ToArray();
        private IWebElement FilteringResultContainer => Driver.FindElement(By.Name("goods_list"));
        public IWebElement[] FilteringResults => FilteringResultContainer.FindElements(By.XPath("//div[@data-split]")).ToArray();
        public IWebElement[] SortingResultsPrice => FilteringResultContainer.FindElements(By.XPath("//div[@class='g-price-uah']")).ToArray();

        public IWebElement Goods32 => Driver.FindElement(By.ClassName("g-i-more-link-text"));
        public IWebElement PriceDesc => Driver.FindElement(By.Id("filter_sortexpensive"));
        public IWebElement SortingDropDown => Driver.FindElement(By.Name("drop_link"));

        public FiltersForm Filters => new FiltersForm(Driver.FindElement(By.Id("parameters-filter-form")));
    }
}
