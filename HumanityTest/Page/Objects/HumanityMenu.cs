using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace HumanityTest.Page.Objects

{
    public static class HumanityMenu
    {
        public static readonly string MENU_URL = "https://nebuchadnezzar.humanity.com/app/dashboard/";

        public static readonly string Dashboard_XPath = "//a[@id='sn_dashboard']//span[@class='primNavQtip__inner']";
        public static readonly string ShiftPlanning_XPath = "//a[@id='sn_schedule']//span[@class='primNavQtip__inner']";
        public static readonly string TimeClock_XPath = "//a[@id='sn_timeclock']//span[@class='primNavQtip__inner']";
        public static readonly string Leave_XPath = "//a[@id='sn_requests']//span[@class='primNavQtip__inner']";
        public static readonly string Training_XPath = "//a[@id='sn_training']//span[@class='primNavQtip__inner']";
        public static readonly string Staff_XPath = "//a[@id='sn_staff']//span[@class='primNavQtip__inner']";
        public static readonly string Payroll_XPath = "//a[@id='sn_payroll']//span[@class='primNavQtip__inner']";
        public static readonly string Reports_XPath = "//a[@id='sn_reports']//span[@class='primNavQtip__inner']";
        public static readonly string Settings_XPath = "//a[@id='sn_admin']";

        public static readonly string DASHBOARD_URL = "https://nebuchadnezzar.humanity.com/app/dashboard/";
        public static readonly string SHIFTPLANING_URL = "https://nebuchadnezzar.humanity.com/app/schedule/employee/week/overview/overview/14%2c0%2c2020/";
        public static readonly string TIMECLOCK_URL = "https://nebuchadnezzar.humanity.com/app/timeclock/";
        public static readonly string LEAVE_URL = "https://nebuchadnezzar.humanity.com/app/requests/vacation/";
        public static readonly string TRAINING_URL = "https://nebuchadnezzar.humanity.com/app/training/";
        public static readonly string PAYROLL_URL = "https://nebuchadnezzar.humanity.com/app/payroll/scheduled-hours/";
        public static readonly string REPORTS_URL = "https://nebuchadnezzar.humanity.com/app/reports/dashboard/";
        public static readonly string SETTINGS_URL = "https://nebuchadnezzar.humanity.com/app/admin/settings/";
        public static readonly string STAFF_URL = "https://nebuchadnezzar.humanity.com/app/staff/add/";

        public static IWebElement GetDashboard(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Dashboard_XPath));
        }

        public static void ClickDashboard(IWebDriver wd)
        {
            GetDashboard(wd).Click();
        }

        public static IWebElement GetShiftPlanning(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(ShiftPlanning_XPath));
        }

        public static void ClickShiftPlanning(IWebDriver wd)
        {
            GetShiftPlanning(wd).Click();
        }

        public static IWebElement GetTimeClock(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(TimeClock_XPath));
        }

        public static void ClickTimeClock(IWebDriver wd)
        {
            GetTimeClock(wd).Click();
        }

        public static IWebElement GetLeave(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Leave_XPath));
        }

        public static void ClickLeave(IWebDriver wd)
        {
            GetLeave(wd).Click();
        }

        public static IWebElement GetTraining(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Training_XPath));
        }

        public static void ClickTraining(IWebDriver wd)
        {
            GetTraining(wd).Click();
        }

        public static IWebElement GetStaff(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Staff_XPath));
        }

        public static void ClickStaff(IWebDriver wd)
        {
            GetStaff(wd).Click();
        }

        public static IWebElement GetPayroll(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Payroll_XPath));
        }

        public static void ClickPayroll(IWebDriver wd)
        {
            GetPayroll(wd).Click();
        }

        public static IWebElement GetReports(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Reports_XPath));
        }

        public static void ClickReports(IWebDriver wd)
        {
            GetReports(wd).Click();
        }

        public static IWebElement GetSettings(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Settings_XPath));
        }
        public static void ClickSettings(IWebDriver wd)
        {
            GetSettings(wd).Click();
        }
    }
}

