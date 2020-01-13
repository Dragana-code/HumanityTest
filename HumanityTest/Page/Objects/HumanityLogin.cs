using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HumanityTest.Page.Objects
{
    public static class HumanityLogin
    {
        public static readonly string LOGIN_URL = "https://www.humanity.com/app/";
        public static readonly string Email_XPath = "//input[@id='email']";
        public static readonly string Password_XPath = "//input[@id='password']";
        public static readonly string LogIn_XPath = "//button[@name='login'][contains(text(),'Log in')]";


        public static IWebElement GetEmail(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Email_XPath));
        }

        public static void SendEmail(IWebDriver wd, string data)
        {
            GetEmail(wd).SendKeys(data);
        }

        public static IWebElement GetPassword(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Password_XPath));
        }

        public static void SendPassword(IWebDriver wd, string data)
        {
            GetPassword(wd).SendKeys(data);
        }

        public static IWebElement GetLogIn(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(LogIn_XPath));
        }

        public static void ClickLogIn(IWebDriver wd)
        {
            GetLogIn(wd).Click();
        }
    }
}
