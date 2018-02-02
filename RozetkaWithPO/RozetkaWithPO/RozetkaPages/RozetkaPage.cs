using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaWithPO.RozetkaPages
{
    class RozetkaPage
    {
        private IWebDriver _driver;

        public RozetkaPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public const string URL = "https://rozetka.com.ua";

        public const string SmartphoneURL = "http://rozetka.com.ua/mobile-phones/c80003/preset=smartfon/";

        public IWebElement SearchField => _driver.FindElement(By.Name("text"));

      

    }
}
