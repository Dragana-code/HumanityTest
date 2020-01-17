using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HumanityTest.Page.Objects;
using System.Threading;

namespace HumanityTest.Page.Test
{
    public static class HumanityHomeTest
    {
        public static Boolean HomePageTest(IWebDriver wd)
        {

            try
            {
                wd.Navigate().GoToUrl(HumanityHome.HOME_URL);
                if (wd.Url.Contains(HumanityHome.HOME_URL))
                {
                    Console.WriteLine("PASS Home Page loaded successfuly.");

                    HumanityHome.ClickAboutUs(wd);
                    Thread.Sleep(3000);
                    HumanityHome.ClickLogin(wd);

                    if (wd.Url.Contains(HumanityLogin.LOGIN_URL))
                    {
                        Console.WriteLine("PASS LogIn Page loaded successfuly.");
                    }
                    else
                    {
                        Console.WriteLine("FAIL LogIn page loaded unsuccessfuly.");
                    }
                    
                        string fullname = "Sponge Bob", workemail="*****";
                        wd.Navigate().Back();
                        Thread.Sleep(3000);
                        HumanityHome.ClickStartMyFreeTrial(wd);
                        Thread.Sleep(3000);
                        wd.Navigate().Refresh();

                        HumanityHome.SendFullName(wd, fullname);
                        HumanityHome.SendWorkEmail(wd, workemail);
                        HumanityHome.ClickStartMyFreeTrial2(wd);
                        Thread.Sleep(3000);
                        wd.Close();
                }
                else
                {
                    Console.WriteLine("FAIL Home Page loaded unsuccessfuly.");
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
