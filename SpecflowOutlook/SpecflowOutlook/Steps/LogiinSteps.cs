using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SpecflowOutlook.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowOutlook.Steps
{
    [Binding]
    public sealed class LogiinSteps
    {
        LoginPage loginPage = null;


        [Given(@"User Launch Application")]
        public void GivenUserLaunchApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://outlook.office.com/mail/");
            loginPage = new LoginPage(webDriver);
        }

        [Given(@"User Enters Email as and click next")]
        public void GivenUserEntersEmailAsAndClickNext()
        {
            Thread.Sleep(1000);
            loginPage.NewName();

            loginPage.Txtnxt();
        }

        [When(@"user Enters Password as and click next")]
        public void WhenUserEntersPasswordAsAndClickNext()
        {
            Thread.Sleep(3000);
            loginPage.Password();
        }

        [Then(@"Click on Signiin")]
        public void ThenClickOnSigniin()
        {
            
            loginPage.Signin();
            loginPage.Nobtn();

        }


    }
}
