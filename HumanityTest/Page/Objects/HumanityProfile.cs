using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HumanityTest.Page.Objects
{
    public static class HumanityProfile
    {
        public static readonly string PROFILE_URL = "https://nebuchadnezzar.humanity.com/app/staff/detail/5297838/";
        public static readonly string PROFILESETTINGS_URL = "https://nebuchadnezzar.humanity.com/app/staff/edit/5297838/";
        public static readonly string AVAILABILITY_URL = "https://nebuchadnezzar.humanity.com/app/staff/availability/5297838/";


        public static readonly string Profile_XPath = "//i[@class='icon icon-arrowFullDn j-arrowIconToAvatar navBottom__userArrow']";
        public static readonly string Profile2_XPath = "//a[contains(text(),'Profile')]";
        public static readonly string ProfileSettings_XPath = "//div[contains(@class,'userm userm-mainPage')]//a[contains(text(),'Settings')]";
        public static readonly string Availability_XPath = "//div[contains(@class,'userm userm-mainPage')]//a[contains(text(),'Availability')]";
        public static readonly string SignOut_XPath = "//a[contains(text(),'Sign Out')]";
        public static readonly string AppVersion_XPath = "//b[contains(text(),'9.13.4')]";
        


        
        public static IWebElement GetProfile(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Profile_XPath));
        }

        public static void ClickProfile(IWebDriver wd)
        {
            GetProfile(wd).Click();
        }
        public static IWebElement GetProfile2(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Profile2_XPath));
        }

        public static void ClickProfile2(IWebDriver wd)
        {
            GetProfile2(wd).Click();
        }



        public static IWebElement GetProfileSettings(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(ProfileSettings_XPath));
        }

        public static void ClickProfileSettings(IWebDriver wd)
        {
            GetProfileSettings(wd).Click();
        }

        public static IWebElement GetAvailability(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Availability_XPath));
        }

        public static void ClickAvailability(IWebDriver wd)
        {
            GetAvailability(wd).Click();
        }

        public static IWebElement GetSignOut(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SignOut_XPath));
        }

        public static void ClickSignOut(IWebDriver wd)
        {
            GetSignOut(wd).Click();
        }

        public static IWebElement GetAppVersion(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(AppVersion_XPath));
        }
    }
}
