using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace HumanityTest.Page.Objects
{
    public static class HumanityEditStaff
    {
        public static readonly string EDIT_STAFF_URL = "https://nebuchadnezzar.humanity.com/app/staff/edit/5297838/";
        public static readonly string EditDetails_XPath = "//a[contains(text(),'Edit Details')]";
        public static readonly string NickName_XPath = "//input[@id='nick_name']";
        public static readonly string Picture_Path = @"C:\Users\Dell Latitude\Desktop\neophoto.jpg";
        public static readonly string UploadPicture_XPath = "//input[@id='fileupload']";


        public static IWebElement GetEditDetails(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(EditDetails_XPath));
        }

        public static void ClickEditDetails(IWebDriver wd)
        {
            GetEditDetails(wd).Click();
        }

        public static IWebElement GetUploadPicture(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(UploadPicture_XPath));
        }

        public static void UploadPicture(IWebDriver wd)
        {
            wd.FindElement(By.XPath(UploadPicture_XPath)).SendKeys(Picture_Path);
        }

        public static IWebElement GetNickName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(NickName_XPath));
        }

        public static void SendNickName(IWebDriver wd, string data)
        {
            GetNickName(wd).SendKeys(data);
        }



    }
}
