using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HumanityTest.Page.Objects;
using System.Threading;

namespace HumanityTest.Page.Test
{
    public class HumanityMenuTest
    {
        public static void MenuTest(IWebDriver wd)
        {
            HumanityLogInTest.HumanityLogIn(wd);
            Thread.Sleep(3000);

            HumanityMenu.ClickDashboard(wd);
            if (wd.Url.Contains(HumanityMenu.DASHBOARD_URL))
            {
                Console.WriteLine("PASS Humanity Dashboard loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Humanity Dashboard loaded unsuccessfuly.");
            }
            Thread.Sleep(3000);

            HumanityMenu.ClickShiftPlanning(wd);
            if (wd.Url.Contains(HumanityMenu.SHIFTPLANING_URL))
            {
                Console.WriteLine("PASS Humanity Shift Planing loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Humanity Shift Planing loaded unsuccessfuly.");
            }
            Thread.Sleep(3000);

            HumanityMenu.ClickTimeClock(wd);
            if (wd.Url.Contains(HumanityMenu.TIMECLOCK_URL))
            {
                Console.WriteLine("PASS Humanity Time Clock loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Humanity Time Clock loaded unsuccessfuly.");
            }
            Thread.Sleep(3000);

            HumanityMenu.ClickLeave(wd);
            if (wd.Url.Contains(HumanityMenu.LEAVE_URL))
            {
                Console.WriteLine("PASS Humanity Leave loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Humanity Leave loaded unsuccessfuly.");
            }
            Thread.Sleep(3000);

            HumanityMenu.ClickTraining(wd);
            if (wd.Url.Contains(HumanityMenu.TRAINING_URL))
            {
                Console.WriteLine("PASS Humanity Training loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Humanity Training loaded unsuccessfuly.");
            }
            Thread.Sleep(3000);

            HumanityMenu.ClickStaff(wd);
            if (wd.Url.Contains(HumanityMenu.STAFF_URL))
            {
                Console.WriteLine("PASS Humanity Staff loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Humanity Staff loaded unsuccessfuly.");
            }
            Thread.Sleep(3000);

            HumanityMenu.ClickPayroll(wd);
            if (wd.Url.Contains(HumanityMenu.PAYROLL_URL))
            {
                Console.WriteLine("PASS Humanity Payroll loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Humanity Payroll loaded unsuccessfuly.");
            }
            Thread.Sleep(3000);

            HumanityMenu.ClickReports(wd);
            if (wd.Url.Contains(HumanityMenu.REPORTS_URL))
            {
                Console.WriteLine("PASS Humanity Reports loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Humanity Reports loaded unsuccessfuly.");
            }
            Thread.Sleep(3000);

            HumanityMenu.ClickSettings(wd);
            if (wd.Url.Contains(HumanityMenu.SETTINGS_URL))
            {
                Console.WriteLine("PASS Humanity Settings loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Humanity Settings loaded unsuccessfuly.");
            }
            HumanityLogInTest.SignOut(wd);
            wd.Quit();
        }
    }
}
