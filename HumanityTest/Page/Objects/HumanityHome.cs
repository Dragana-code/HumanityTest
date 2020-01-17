using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace HumanityTest.Page.Objects
{
    public static class HumanityHome
    {
        public static readonly string HOME_URL = "https://www.humanity.com/";

        public static readonly string AboutUs_XPath = "//a[@class='nav-link no-before'][contains(text(),'About us')]";
        public static readonly string Login_XPath = "//p[contains(text(),'LOGIN')]";
        public static readonly string StartMyFreeTrial_XPath = "//div[@class='nav-trial']";
        public static readonly string FullName_XPath = "//div[@class='input-wrapper']//input[@placeholder='Full Name']";
        public static readonly string WorkEmail_XPath = "//div[@class='input-wrapper']//input[@placeholder='Work Email']";
        public static readonly string StartMyFreeTrial2_XPath = "//input[@id='free-trial-link-01']";


        public static IWebElement GetAboutUs(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(AboutUs_XPath));
        }

        public static void ClickAboutUs(IWebDriver wd)
        {
            GetAboutUs(wd).Click();
        }

        public static IWebElement GetLogin(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Login_XPath));
        }

        public static void ClickLogin(IWebDriver wd)
        {
            GetLogin(wd).Click();
        }

        public static IWebElement GetStartMyFreeTrial(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(StartMyFreeTrial_XPath));
        }

        public static void ClickStartMyFreeTrial(IWebDriver wd)
        {
            GetStartMyFreeTrial(wd).Click();
        }

        public static IWebElement GetFullName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(FullName_XPath));
        }

        public static void SendFullName(IWebDriver wd, string data)
        {
            GetFullName(wd).SendKeys(data);
        }

        public static IWebElement GetWorkEmail(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(WorkEmail_XPath));
        }

        public static void SendWorkEmail(IWebDriver wd, string data)
        {
            GetWorkEmail(wd).SendKeys(data);
        }

        public static IWebElement GetStartMyFreeTrial2(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(StartMyFreeTrial2_XPath));
        }

        public static void ClickStartMyFreeTrial2(IWebDriver wd)
        {
            GetStartMyFreeTrial2(wd).Click();
        }
    }
}
