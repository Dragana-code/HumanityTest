using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using HumanityTest.Page.Objects;

namespace HumanityTest.Page.Test
{
    public static class HumanityAddNewEmployeeTest
    {
        #region Add New Emploee Manual Test       
        public static void AddNewEmployee()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            string email = "wicej50953@4xmail.org", password = "redpill";
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();

            wd.Navigate().GoToUrl(HumanityLogin.LOGIN_URL);
            HumanityLogInTest.InsertData(wd, email, password);
            HumanityLogin.ClickLogIn(wd);
            Thread.Sleep(4000);

            string fname = "Johna", lname = "Michaelson", mail = "michajo@micas.com";
            wd.Navigate().GoToUrl(HumanityStaff.STAFF_URL);
            Thread.Sleep(4000);

            try
            {
                wd.FindElement(By.XPath(HumanityStaff.AddEmployeeFirstName_XPath)).SendKeys(fname);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error finding First Name");
            }

            try
            {
                wd.FindElement(By.XPath(HumanityStaff.AddEmployeeLastName_XPath)).SendKeys(lname);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error finding Last Name");
            }

            try
            {
                wd.FindElement(By.XPath(HumanityStaff.AddEmployeeEmail_XPath)).SendKeys(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error finding Last Name");
            }

            try
            {
                wd.FindElement(By.XPath(HumanityStaff.SaveEmployee_XPath)).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error finding Save Employee");
            }

            Thread.Sleep(4000);
            HumanityLogInTest.SignOut();
        }
        #endregion
        public static Boolean AutomaticAddNewEmployee()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            string email = "wicej50953@4xmail.org", password = "redpill";
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();

            ExcelUtility.OpenFile(Constants.EXCEL_ZAPOSLENI_PATH);
            ExcelUtility.LoadWorkSheet(0);

            wd.Navigate().GoToUrl(HumanityLogin.LOGIN_URL);
            HumanityLogInTest.InsertData(wd, email, password);
            HumanityLogin.ClickLogIn(wd);
            Thread.Sleep(3000);





            try
            {
                for (int i = 1; i < ExcelUtility.GetRowCount(); i++)
                {
                    string fname = ExcelUtility.GetDataAt(i, 0);
                    string lname = ExcelUtility.GetDataAt(i, 1);
                    string eemail = ExcelUtility.GetDataAt(i, 2);

                    wd.Navigate().GoToUrl(HumanityStaff.STAFF_URL);
                    Thread.Sleep(3000);

                    if (wd.Url.Contains(HumanityStaff.STAFF_URL))
                    {
                        Console.WriteLine("PASS. Staff page loaded successfuly.");
                    }
                    else
                    {
                        Console.WriteLine("FAIL. Staff page is not loaded");
                    }

                    InsertEmployeeData(wd, fname, lname, eemail);
                    HumanityStaff.ClickSaveEmployee(wd);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }


            //Thread.Sleep(3000);
            //HumanityLogInTest.SignOut();
        }
        public static void InsertEmployeeData(IWebDriver wd, string fname, string lname, string eemail)
        {
            HumanityStaff.SendAddEmployeeFirstName(wd, fname);
            HumanityStaff.SendAddEmployeeLastName(wd, lname);
            HumanityStaff.SendAddEmployeeEmail(wd, eemail);
        }


    }
}
