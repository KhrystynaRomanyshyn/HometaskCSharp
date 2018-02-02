namespace WebDriver_1
{
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;
    using System.Linq;
    using WebDriver_1.Selenium;

    [TestFixture()]
    public class RozetkaTests
    {
        [Test]
        public void RozetkaSearch()
        {
            var steps = new RozetkaSteps(SeleniumDriver.GetDriver());
            steps.OpenRozetkaPage();
            steps.SearchForText("Hyundai");
            steps.VerifyHyundaiInREsults();
            steps.Verify32GoodsExists();
        }

        [Test]
        public void RozetkaSmartphonesFiltering()
        {
            var steps = new RozetkaSteps(SeleniumDriver.GetDriver());
            steps.OpenForSmartphones();
            steps.SelectFilteringOption("Производитель", "Apple");            
            steps.SelectFilteringOption("Производитель", "Samsung");
            steps.VerifyFiltering();
        }

        [Test]
        public void RozetkaSmartphonesSorting()
        {
            var steps = new RozetkaSteps(SeleniumDriver.GetDriver());
            steps.OpenForSmartphones();
            steps.SelectFilteringOption("Производитель", "Apple");
            steps.SelectFilteringOption("Производитель", "Samsung");
            steps.SortingByPriceDesc();
            steps.VerifySorting();      
        }

        [OneTimeSetUp]
        public static void Setup()
        {
            SeleniumDriver.GetDriver().Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            SeleniumDriver.GetDriver().Quit();
        }
    }
}
