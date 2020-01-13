using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace HumanityTest.Page.Objects
{
    public static class HumanityStaff
    {
        public static readonly string STAFF_URL = "https://nebuchadnezzar.humanity.com/app/staff/add/";

        public static readonly string AddEmployees_XPath = "//button[@id='act_primary']";
        public static readonly string Employee1_XPath = "//a[contains(text(),'Ander Thomason')]";
        public static readonly string Employee2_XPath = "//a[contains(text(),'Thom Thomson')]";
        public static readonly string Employee3_XPath = "//a[contains(text(),'Thomas Anderson')]";

        public static readonly string AddEmployeeFirstName_XPath = "//input[@id='_asf1']";
        public static readonly string AddEmployeeLastName_XPath = "//input[@id='_asl1']";
        public static readonly string AddEmployeeEmail_XPath = "//input[@id='_ase1']";
        public static readonly string SaveEmployee_XPath = "//button[@id='_as_save_multiple']";
        // //input[@id='_asf2']

        public static IWebElement GetAddEmployees(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(AddEmployees_XPath));
        }

        public static void ClickAddEmployees(IWebDriver wd)
        {
            GetAddEmployees(wd).Click();
        }

        public static IWebElement GetEmployee1(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Employee1_XPath));
        }

        public static void ClickEmployee1(IWebDriver wd)
        {
            GetEmployee1(wd).Click();
        }

        public static IWebElement GetEmployee2(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Employee2_XPath));
        }

        public static void ClickEmployee2(IWebDriver wd)
        {
            GetEmployee2(wd).Click();
        }

        public static IWebElement GetEmployee3(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Employee3_XPath));
        }

        public static void ClickEmployee3(IWebDriver wd)
        {
            GetEmployee3(wd).Click();
        }

        public static IWebElement GetAddEmployeeFirstName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(AddEmployeeFirstName_XPath));
        }

        public static void SendAddEmployeeFirstName(IWebDriver wd, string data)
        {
            GetAddEmployeeFirstName(wd).SendKeys(data);
        }

        public static IWebElement GetAddEmployeeLastName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(AddEmployeeLastName_XPath));
        }

        public static void SendAddEmployeeLastName(IWebDriver wd, string data)
        {
            GetAddEmployeeLastName(wd).SendKeys(data);
        }

        public static IWebElement GetAddEmployeeEmail(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(AddEmployeeEmail_XPath));
        }

        public static void SendAddEmployeeEmail(IWebDriver wd, string data)
        {
            GetAddEmployeeEmail(wd).SendKeys(data);
        }

        public static IWebElement GetSaveEmployee(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SaveEmployee_XPath));
        }

        public static void ClickSaveEmployee(IWebDriver wd)
        {
            GetSaveEmployee(wd).Click();
        }
    }
}

