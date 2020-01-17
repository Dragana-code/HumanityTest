using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using HumanityTest.Page.Objects;
using System.Threading;

namespace HumanityTest.Page.Test
{
    public class HumanityStaffTest
    {
        public static Boolean Staff(IWebDriver wd)
        {
            HumanityLogInTest.HumanityLogIn(wd);
            Thread.Sleep(3000);

            HumanityMenu.ClickStaff(wd);
            if (wd.Url.Contains(HumanityMenu.STAFF_URL))
            {
                Console.WriteLine("PASS Staff Page loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Staff Page loaded unsuccessfuly.");
            }

            try
            {
                HumanityStaff.GetEmployee1(wd).Click();
                Thread.Sleep(3000);
                wd.Navigate().Back();

                HumanityStaff.GetEmployee2(wd).Click();
                Thread.Sleep(3000);
                wd.Navigate().Back();

                HumanityStaff.GetEmployee3(wd).Click();
                Thread.Sleep(3000);
                wd.Navigate().Back();

                HumanityLogInTest.SignOut(wd);
                wd.Quit();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

    }
}
