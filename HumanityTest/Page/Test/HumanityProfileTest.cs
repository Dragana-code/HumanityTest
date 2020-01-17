using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HumanityTest.Page.Objects;
using System.Threading;

namespace HumanityTest.Page.Test
{
    public static class HumanityProfileTest
    {
        public static void ProfileTest(IWebDriver wd)
        {
            HumanityLogInTest.HumanityLogIn(wd);
            Thread.Sleep(4000);

            HumanityProfile.ClickProfile(wd);
            Thread.Sleep(4000);
            HumanityProfile.ClickProfile2(wd);
            if (wd.Url.Contains(HumanityProfile.PROFILE_URL))
            {
                Console.WriteLine("PASS Employee Profile loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Employee Profile loaded unsuccessfuly.");
            }
            Thread.Sleep(4000);

            HumanityProfile.ClickProfile(wd);
            Thread.Sleep(4000);
            HumanityProfile.ClickProfileSettings(wd);
            if (wd.Url.Contains(HumanityProfile.PROFILESETTINGS_URL))
            {
                Console.WriteLine("PASS Profile Settings loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Profile Settings loaded unsuccessfuly.");
            }
            Thread.Sleep(4000);

            HumanityProfile.ClickProfile(wd);
            Thread.Sleep(4000);
            HumanityProfile.ClickAvailability(wd);
            if (wd.Url.Contains(HumanityProfile.AVAILABILITY_URL))
            {
                Console.WriteLine("PASS Availability loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Availability loaded unsuccessfuly.");
            }
            Thread.Sleep(4000);

            HumanityProfile.ClickProfile(wd);
            Thread.Sleep(4000);
            HumanityProfile.ClickSignOut(wd);
            Thread.Sleep(4000);

            wd.Quit();   
        }
    }
}
