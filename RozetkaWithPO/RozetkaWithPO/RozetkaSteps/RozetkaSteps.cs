using OpenQA.Selenium;
using RozetkaWithPO.RozetkaPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaWithPO.RozetkaSteps
{
    class RozetkaSteps
    {
        private readonly RozetkaPage _page;
        private readonly IWebDriver _driver;


        public RozetkaSteps(IWebDriver driver)
        {
            _driver = driver;
            _page = new RozetkaPage(_driver);
        }

        public void Open(string URL)
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);
        }

        public void SearchForText(string searchText)
        {
            _page.SearchField.SendKeys(searchText);
            _page.SearchField.Submit();
        }


    }
}
