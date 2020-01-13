using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System.Diagnostics;
using HumanityTest.Page.Objects;

namespace HumanityTest.Page.Test
{
    public class HumanityLogInTest
    {
        #region Manual Log In Test
        public static Boolean TestHumanityLogIn()
        {

            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            string email = "wicej50953@4xmail.org", password = "redpill";
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            try
            {
                

                wd.Navigate().GoToUrl(HumanityLogin.LOGIN_URL);

                if (wd.Url.Contains(HumanityLogin.LOGIN_URL))
                {
                    Console.WriteLine("PASS. LogIn page loaded successfuly.");
                }
                else
                {
                    Console.WriteLine("FAIL. LogIn page is not loaded");
                }

                InsertData(wd, email, password);

                HumanityLogin.ClickLogIn(wd);
                Thread.Sleep(3000);

                if (wd.Url.Equals(HumanityMenu.MENU_URL))
                {
                    Console.WriteLine("Successful Log In.");
                }
                else
                {
                    Console.WriteLine("Unsuccessful Log In.");
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        public static void SignOut()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);

            HumanityProfile.ClickProfile(wd);
            HumanityProfile.ClickSignOut(wd);
            wd.Quit();

        }
        #endregion
        public static void InsertData(IWebDriver wd, string email, string password)
        {
            HumanityLogin.SendEmail(wd, email);
            HumanityLogin.SendPassword(wd, password);

        }


        #region Automatic Log In Test

        public static Boolean AutomaticTestHumanityLogIn()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);

            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Drive Initialized!");
            try
            {
                

                ExcelUtility.OpenFile(Constants.EXCEL_LOGIN_PATH);
                ExcelUtility.LoadWorkSheet(0);

            

                for (int i = 1; i < ExcelUtility.GetRowCount(); i++)//prolazak kroz sve redove koji sadrze podatke
                {//treba pokupiti podatke iz redova
                    string email = ExcelUtility.GetDataAt(i, 0);
                    string password = ExcelUtility.GetDataAt(i, 1);


                    wd.Navigate().GoToUrl(HumanityLogin.LOGIN_URL);
                    Thread.Sleep(5000);
                    //HumanityLogIn.GetPassword(wd).Click();
                    //HumanityLogIn.GetPassword(wd).SendKeys(Keys.Control + "a");
                    HumanityLogin.GetPassword(wd).Clear();


                    InsertData(wd, email, password);
                    Thread.Sleep(4000);
                    HumanityLogin.ClickLogIn(wd);
                    Thread.Sleep(4000);

                    //provera da li je submit uspesan, i od pocetka uzima podatke i tako do kraja tabele
                    if (wd.Url.Contains(HumanityMenu.MENU_URL))
                    {
                        Console.WriteLine("PASS");
                    }
                    else
                    {
                        Console.WriteLine("FAIL");
                    }

                }
                wd.Quit();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }



        }


        #endregion

        public static void UploadPhoto()
        {

            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            string email = "wicej50953@4xmail.org", password = "redpill";

            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();


            wd.Navigate().GoToUrl(HumanityLogin.LOGIN_URL);

            if (wd.Url.Contains(HumanityLogin.LOGIN_URL))
            {
                Console.WriteLine("PASS. LogIn page loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL. LogIn page is not loaded");
            }

            InsertData(wd, email, password);

            HumanityLogin.ClickLogIn(wd);
            Thread.Sleep(4000);

            if (wd.Url.Equals(HumanityMenu.MENU_URL))
            {
                Console.WriteLine("Successful Log In.");
            }
            else
            {
                Console.WriteLine("Unsuccessful Log In.");
            }
            wd.Navigate().GoToUrl(HumanityEditStaff.EDIT_STAFF_URL);


            wd.FindElement(By.XPath("//span[@id='in-btn']")).Click();
            IWebElement fileUpload = wd.FindElement(By.XPath("//span[@id='in-btn']"));
            //wd.SwitchTo().ActiveElement().SendKeys("C:/Users/Dell Latitude/Desktop/neophoto.jpg");
            wd.SwitchTo().Alert().SendKeys("C:\\Users\\Dell Latitude\\Desktop\neophoto.jpg");



            //fileUpload.SendKeys("C:\\Users\\Dell Latitude\\Desktop\neophoto.jpg");
            //fileUpload.SendKeys("{ENTER}");



            //HumanityProfile.ClickProfile(wd);

            //HumanityProfile.ClickSignOut(wd);


            //wd.Quit();
        }



    }
}
