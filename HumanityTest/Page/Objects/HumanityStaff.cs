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
        public static readonly string EmployeePart1 = "//a[contains(text(),'";
        public static readonly string EmployeePart2 = "')]";
        public static readonly string employee1 = "Andre Thomason";
        public static readonly string employee2 = "Thomas Anderson";
        public static readonly string employee3 = "Thomas Thomason";

        public static readonly string AddFirstNamePart1 = "//input[@id='_asf";
        public static readonly string AddLastNamePart1 = "//input[@id='_asl";
        public static readonly string AddEmailPart1 = "//input[@id='_ase";
        public static readonly string SaveEmployee_XPath = "//button[@id='_as_save_multiple']";
        public static readonly string Part2 = "']";
        

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
            return wd.FindElement(By.XPath(EmployeePart1+employee1+EmployeePart2));
        }

        public static void ClickEmployee1(IWebDriver wd)
        {
            GetEmployee1(wd).Click();
        }

        public static IWebElement GetEmployee2(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(EmployeePart1 + employee2 + EmployeePart2));
        }

        public static void ClickEmployee2(IWebDriver wd)
        {
            GetEmployee2(wd).Click();
        }

        public static IWebElement GetEmployee3(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(EmployeePart1 + employee3 + EmployeePart2));
        }

        public static void ClickEmployee3(IWebDriver wd)
        {
            GetEmployee3(wd).Click();
        }


        public static int i;   

        public static IWebElement GetFirstName(IWebDriver wd)
        {
             return wd.FindElement(By.XPath(AddFirstNamePart1 + i + Part2));
        }

        public static void SendFirstName(IWebDriver wd, string data)
        {
            GetFirstName(wd).SendKeys(data);
        }

        public static IWebElement GetLastName(IWebDriver wd)
        {
             return wd.FindElement(By.XPath(AddLastNamePart1 + i + Part2));
        }

        public static void SendLastName(IWebDriver wd, string data)
        {
            GetLastName(wd).SendKeys(data);
        }

        public static IWebElement GetEmail(IWebDriver wd)
        {
                return wd.FindElement(By.XPath(AddEmailPart1 + i + Part2));
        }

        public static void SendEmail(IWebDriver wd, string data)
        {
            GetEmail(wd).SendKeys(data);
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

