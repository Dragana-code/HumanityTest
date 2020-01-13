using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HumanityTest.Page.Objects
{
    public static class HumanityProfile
    {
        public static readonly string PROFILE_URL = "https://nebuchadnezzar.humanity.com/app/staff/detail/5297838/";

        public static readonly string Profile_XPath = "//div[@id='wrap_us_menu']";
        public static readonly string Settings_XPath = "//div[contains(@class,'userm userm-mainPage')]//a[contains(text(),'Settings')]";
        public static readonly string Availability_XPath = "//div[contains(@class,'userm userm-mainPage')]//a[contains(text(),'Availability')]";
        public static readonly string SignOut_XPath = "//a[contains(text(),'Sign Out')]";
        public static readonly string HumanityAppVersion_XPath = "//b[contains(text(),'9.13.4')]";
        //div[@id='humanityAppVersion']


        
        public static IWebElement GetProfile(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Profile_XPath));
        }

        public static void ClickProfile(IWebDriver wd)
        {
            GetProfile(wd).Click();
        }
    
    

        public static IWebElement GetSettings(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Settings_XPath));
        }

        public static void ClickSettings(IWebDriver wd)
        {
            GetSettings(wd).Click();
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

        public static IWebElement GetHumanityAppVersion(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(HumanityAppVersion_XPath));
        }

        public static void ClickHumanityAppVersion(IWebDriver wd)
        {
            GetHumanityAppVersion(wd).Click();
        }

        //upload picture

        public static void UploadPicture()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            wd.Navigate().GoToUrl("https://nebuchadnezzar.humanity.com/app/staff/edit/5297838/");
            //wd.FindElement(By.XPath("//span[@id='in-btn']")).Click();
            //IWebElement fileUpload = wd.FindElement(By.XPath("//span[@id='in-btn']"));
            //fileUpload.SendKeys(@"C:\Users\Dell Latitude\Desktop\neophoto.jpg");

            //Profile_XPath="//div[@id='wrap_us_menu']"
            //ili  //i[@class='icon icon-arrowFullDn j-arrowIconToAvatar navBottom__userArrow']
            //SignOut_XPath="//a[contains(text(),'Sign Out')]";
        }
    }
}
