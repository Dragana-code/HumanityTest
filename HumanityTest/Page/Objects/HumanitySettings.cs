using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace HumanityTest.Page.Objects
{
    public static class HumanitySettings
    {
        public static readonly string SETTINGS_URL = "https://nebuchadnezzar.humanity.com/app/admin/settings/";
        public static readonly string Country_XPath = "//select[@id='country']";
        public static readonly string DefaultLanguage_XPath = "//td[contains(@class,'nowrap')]//select[contains(@name,'language')]";
        public static readonly string TimeFormat_XPath = "//select[contains(@name,'pref_24hr')]";


        public static IWebElement GetCountry(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Country_XPath));
        }

        public static void ClickCountry(IWebDriver wd)
        {
            GetCountry(wd).Click();//verovatno send text
        }

        public static IWebElement GetDefaultLanguage(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(DefaultLanguage_XPath));
        }

        public static void ClickDefaultLanguage(IWebDriver wd)
        {
            GetDefaultLanguage(wd).Click();
        }

        public static IWebElement GetTimeFormat(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(TimeFormat_XPath));
        }

        public static void ClickTimeFormat(IWebDriver wd)
        {
            GetTimeFormat(wd).Click();
        }

    }
}
