using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HumanityTest.Page.Objects;
using System.Threading;

namespace HumanityTest.Page.Test
{
    public class HumanityEditStaffTest
    {
        public static Boolean EditStaff(IWebDriver wd)// adding a nickname and photo of employee
        {
            HumanityLogInTest.HumanityLogIn(wd);
            Thread.Sleep(3000);

            try
            {
                string nickn = "Nick";

                HumanityProfile.GetProfile(wd);
                HumanityProfile.ClickProfile(wd);
                Thread.Sleep(3000);
                HumanityProfile.ClickProfile2(wd);

                if (wd.Url.Contains(HumanityProfile.PROFILE_URL))
                {
                    Console.WriteLine("PASS Humanity Profile loaded successfuly.");
                }
                else
                {
                    Console.WriteLine("FAIL Humanity Profile loaded unsuccessfuly.");
                }

                HumanityEditStaff.ClickEditDetails(wd);
                if (wd.Url.Contains(HumanityEditStaff.EDIT_STAFF_URL))
                {
                    Console.WriteLine("PASS Edit Details loaded successfuly.");
                }
                else
                {
                    Console.WriteLine("FAIL Edit Details loaded unuccessfuly.");
                }

                HumanityEditStaff.SendNickName(wd, nickn);
                Thread.Sleep(3000);
                UploadPicture(wd);
                Thread.Sleep(3000);

                HumanityStaff.ClickSaveEmployee(wd);
                Thread.Sleep(3000);

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
        public static void UploadPicture(IWebDriver wd)
        {
            
            wd.FindElement(By.XPath(HumanityEditStaff.UploadPicture_XPath)).SendKeys(HumanityEditStaff.Picture_Path);
            
        }
    }
}
