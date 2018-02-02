namespace WebDriver_1.Selenium
{
    using System;
    using System.Linq;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using NUnit.Framework;

    class RozetkaSteps
    {
        //new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        private readonly RozetkaPage Page;
        private readonly IWebDriver Driver;


        public RozetkaSteps(IWebDriver driver)
        {
            Driver = driver;
            Page = new RozetkaPage(Driver);
        }

        public void OpenRozetkaPage()
            => Driver.Navigate().GoToUrl(Page.URI);

        public void SearchForText(string text)
        {
            Page.SearchField.Clear();
            Page.SearchField.SendKeys(text);
            Page.SearchField.Submit();
        }

        public void OpenForSmartphones()
             => Driver.Navigate().GoToUrl(Page.SmartphonesURI);

        public void SelectFilteringOption(string filterSection, string checkboxInSection)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.CssSelector("li.pos-fix"))));
            ((Page.Filters.ItemsForSection(filterSection)).First(i => i.Text.Contains(checkboxInSection))).Click();
            //var filters = Page.Filters.ItemsForSection(filterSection);
            //var option = filters.First(i => i.Text.Contains(checkboxInSection));  
            //option.Click();
            new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy((By.XPath("//div[@tool_tip]/a/img"))));          
        }

        //sorting dropdown
        public void SortingByPriceDesc()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.Name("drop_parent"))));
            Page.SortingDropDown.Click();
            new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible((By.Id("filter_sortexpensive"))));
            Page.PriceDesc.Click();
        }


        public List<int>  SortingResultsPrice() 
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//div[@class='g-price-uah']")));
            var priceList = new List<int>();
             Page.SortingResultsPrice.ToList().ForEach(item => priceList.Add( Int32.Parse ((new Regex(@"\D")).Replace(item.Text, ""))));
            return priceList;
        }

        public void VerifyHyundaiInREsults()
            => Assert.IsTrue(Page.Results.All(item => item.Text.Contains("Hyundai")), " Not all shown items are 'Hyundai'");

        public void Verify32GoodsExists()
            => Assert.IsTrue(Page.Goods32.Displayed, "'Показать еще 32 товара' element hasn't been displayed");

        public void VerifyFiltering()
            => Assert.IsTrue(Page.FilteringResults.All(item => item.Text.Contains("Apple") || item.Text.Contains("Samsung")), "Filtering for Samsung and Aplle brands doesn't work properly");

        public void VerifySorting ()
        {
            var sortingResults = SortingResultsPrice().ToArray();
            for (int i = 0; i < sortingResults.Length - 1; i++)
            {
                Assert.IsTrue(sortingResults[i] >= sortingResults[i + 1], "Wrong sorting by price desc");
            }
        }

    }
}

