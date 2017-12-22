using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RozetkaTest
{
    [TestFixture]

    class RozetkaTests
    {
        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver(); 
        }

       [Test]

       public void HuindaySearch()
        {
            RozetkaPage page = new RozetkaPage();
            page.Open();
        }

    }
}
