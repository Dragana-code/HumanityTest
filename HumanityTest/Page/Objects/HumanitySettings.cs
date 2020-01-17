using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HumanityTest.Page.Objects
{
    public static class HumanitySettings
    {
        public static readonly string SETTINGS_URL = "https://nebuchadnezzar.humanity.com/app/admin/settings/";
        public static readonly string Country_XPath = "//select[@id='country']";
        public static readonly string DefaultLanguage_XPath = "//td[contains(@class,'nowrap')]//select[contains(@name,'language')]";
        public static readonly string TimeFormat_XPath = "//select[contains(@name,'pref_24hr')]";
        public static readonly string SaveSettings_XPath = "//button[@id='act_primary']";

        public static IWebElement GetCountry(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Country_XPath));
        }

        

        public static IWebElement GetDefaultLanguage(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(DefaultLanguage_XPath));
        }

        

        public static IWebElement GetTimeFormat(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(TimeFormat_XPath));
        }

        public static IWebElement GetSaveSettings(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SaveSettings_XPath));
        }
        public static void ClickSaveSettings(IWebDriver wd)
        {
            GetSaveSettings(wd).Click();
        }


    }
}
