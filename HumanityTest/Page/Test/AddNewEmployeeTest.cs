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
        public static Boolean AddNewEmployee(IWebDriver wd)
        {

            HumanityLogInTest.HumanityLogIn(wd);
            Thread.Sleep(3000);

            string fname = "Smith", lname = "Smithson", mail = "smi@micas.com";

            wd.Navigate().GoToUrl(HumanityStaff.STAFF_URL);
            if (wd.Url.Contains(HumanityStaff.STAFF_URL))
            {
                Console.WriteLine("PASS Humanity Staff loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Humanity Staff loaded unsuccessfuly.");
            }
            Thread.Sleep(3000);

            try
            {
                int i = 1;
                wd.FindElement(By.XPath(HumanityStaff.AddFirstNamePart1 + i + HumanityStaff.Part2)).SendKeys(fname);

                wd.FindElement(By.XPath(HumanityStaff.AddLastNamePart1 + i + HumanityStaff.Part2)).SendKeys(lname);

                wd.FindElement(By.XPath(HumanityStaff.AddEmailPart1 + i + HumanityStaff.Part2)).SendKeys(mail);

                wd.FindElement(By.XPath(HumanityStaff.SaveEmployee_XPath)).Click();

                HumanityLogInTest.SignOut(wd);

                return true;
            }
            
             catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }       
            
           

        }
        #endregion

        #region Add Employee Automatic Test
        public static Boolean AutomaticAddNewEmployee(IWebDriver wd)
        {
            
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();

            HumanityLogInTest.HumanityLogIn(wd);
            Thread.Sleep(3000);

            wd.Navigate().GoToUrl(HumanityStaff.STAFF_URL);
            Thread.Sleep(3000);

            if (wd.Url.Contains(HumanityStaff.STAFF_URL))
            {
                Console.WriteLine("PASS. Staff page loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL. Staff page loaded unsuccessfuly.");
            }

            try
            {
                ExcelUtility.OpenFile(Constants.EXCEL_ZAPOSLENI_PATH);
                ExcelUtility.LoadWorkSheet(0);

                for (int i = 1; i < ExcelUtility.GetRowCount(); i++)
                {
                    string fname = ExcelUtility.GetDataAt(i, 0);
                    string lname = ExcelUtility.GetDataAt(i, 1);
                    string eemail = ExcelUtility.GetDataAt(i, 2);

                    

                    wd.FindElement(By.XPath(HumanityStaff.AddFirstNamePart1 + i + HumanityStaff.Part2)).SendKeys(fname);

                    wd.FindElement(By.XPath(HumanityStaff.AddLastNamePart1 + i + HumanityStaff.Part2)).SendKeys(lname);

                    wd.FindElement(By.XPath(HumanityStaff.AddEmailPart1 + i + HumanityStaff.Part2)).SendKeys(eemail);

                }
                HumanityStaff.ClickSaveEmployee(wd);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        #endregion
        public static void InsertEmployeeData(IWebDriver wd, string fname, string lname, string eemail)
        {
            HumanityStaff.SendFirstName(wd, fname);
            HumanityStaff.SendLastName(wd, lname);
            HumanityStaff.SendEmail(wd, eemail);
        }


    }
}
