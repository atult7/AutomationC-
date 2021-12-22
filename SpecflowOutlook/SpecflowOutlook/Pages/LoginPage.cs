using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowOutlook.Pages
{
    public class LoginPage
    {
        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement txtEmail => WebDriver.FindElement(By.XPath("//*[@name='loginfmt']"));
        public IWebElement txtnxt => WebDriver.FindElement(By.XPath("//*[@id=\'idSIButton9\']"));
        public IWebElement txtPassword => WebDriver.FindElement(By.XPath("//*[@id=\"i0118\"]"));
        public IWebElement txtsignin => WebDriver.FindElement(By.XPath("//*[@id=\'idSIButton9\']"));

        public IWebElement txtnobtn => WebDriver.FindElement(By.XPath("//*[@id='idBtn_Back']"));

       

        public void NewName()
        {
            txtEmail.SendKeys("sender01togo@outlook.com");
        }
        public void Txtnxt()
        {
            txtnxt.Click();
        }
        public void Password()
        {
            txtPassword.SendKeys("Sender@4321");
        }
        public void Signin()
        {
            txtsignin.Click();
        }
        public void Nobtn()
        {
            txtnobtn.Click();
        }

        

    }
}
