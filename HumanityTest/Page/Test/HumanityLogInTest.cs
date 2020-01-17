using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System.Diagnostics;
using HumanityTest.Page.Objects;
using IronXL;

namespace HumanityTest.Page.Test
{
    public class HumanityLogInTest
    {
        #region Manual Log In Test
        public static Boolean HumanityLogIn(IWebDriver wd)
        {
            string email = "wicej50953@4xmail.org", password = "redpill";
            
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
                    Console.WriteLine("PASS LogIn successful.");
                }
                else
                {
                    Console.WriteLine("PASS LogIn unsuccessful.");
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        #endregion
        public static void SignOut(IWebDriver wd)
        {
            HumanityProfile.ClickProfile(wd);
            Thread.Sleep(3000);
            HumanityProfile.ClickSignOut(wd);
            Thread.Sleep(3000);
            wd.Quit();
        }
       
        public static void InsertData(IWebDriver wd, string email, string password)
        {
            HumanityLogin.SendEmail(wd, email);
            HumanityLogin.SendPassword(wd, password);
        }


        #region Automatic Log In Test

        public static Boolean AutomaticHumanityLogIn(IWebDriver wd)
        {
            ExcelUtility.OpenFile(Constants.EXCEL_LOGIN_PATH);
            ExcelUtility.LoadWorkSheet(0);

            try
            {
                for (int i = 1; i < ExcelUtility.GetRowCount(); i++)//prolazak kroz sve redove koji sadrze podatke
                {   
                    //prikupljanje podataka iz redova
                    string email = ExcelUtility.GetDataAt(i, 0);
                    string password = ExcelUtility.GetDataAt(i, 1);

                    wd.Navigate().GoToUrl(HumanityLogin.LOGIN_URL);
                    if (wd.Url.Contains(HumanityLogin.LOGIN_URL))
                    {
                        Console.WriteLine("PASS LogIn Page loaded successfuly.");
                    }
                    else
                    {
                        Console.WriteLine("FAIL LogIn Page loaded unsuccessfuly");
                    }
                    Thread.Sleep(5000);

                    InsertData(wd, email, password);
                    Thread.Sleep(4000);
                    HumanityLogin.ClickLogIn(wd);
                    Thread.Sleep(4000);

                    //provera da li je submit uspesan, nastavlja da uzima podatke do kraja tabele
                    if (wd.Url.Contains(HumanityMenu.MENU_URL))
                    {
                        Console.WriteLine("PASS LogIn successful.");
                    }
                    else
                    {
                        Console.WriteLine("FAIL LogIn unsuccessful.");
                    }
                }
                HumanityLogInTest.SignOut(wd);
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

    }
}
