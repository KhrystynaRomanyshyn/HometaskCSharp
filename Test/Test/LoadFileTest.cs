using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;
using System.Windows.Forms;
using NUnit.Framework;
using System;

namespace Test
{
    [Binding]
    public class LoadFileTest
    {
        LogIn logIn = new LogIn();

        [Given(@"login as admin")]
        public void GivenLoginAsAdmin(Table table)
        {
            logIn.GivenTheMainPageWithCredentialsIsOpened();
            logIn.WhenUserLogsIn(table);
        }
        
        [When(@"admin choose file")]
        public void WhenAdminChooseFile()
        {
            logIn.driver.FindElement(By.ClassName("form-file")).Click();
            logIn.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            SendKeys.SendWait(
                @"C:\Users\Khrystyna_Romanyshyn\Downloads\Telegram Desktop\27_10_17_18_00_Kyiv_C#_V1_2016.json");
           
            SendKeys.SendWait(@"{Enter}");
        }
        
        [Then(@"The filename is displayed")]
        public void ThenButtonImportTestGroupIsAvailable()
        {
            string a = logIn.driver.FindElement(By.ClassName("upload-panel__fileName")).Text;
            var b = a.Length;
            Assert.AreEqual("27_10_17_18_00_Kyiv_C#_V1_2016.json", a);
        }
    }
}
