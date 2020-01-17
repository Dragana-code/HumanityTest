using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HumanityTest.Page.Objects;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace HumanityTest.Page.Test
{
    public class HumanitySettingsTest
    {
        public static void SettingsTest(IWebDriver wd)
        {
            string countryname = "Nigeria", deflanguage="Serbian (machine)", timef="24 hour";

            HumanityLogInTest.HumanityLogIn(wd);
            Thread.Sleep(3000);

            
            HumanityMenu.ClickSettings(wd);
            if (wd.Url.Contains(HumanitySettings.SETTINGS_URL))
            {
                Console.WriteLine("PASS Humanity Settings loaded successfuly.");
            }
            else
            {
                Console.WriteLine("FAIL Humanity Settings loaded successfuly.");
            }
            Thread.Sleep(3000);

            SelectCountry(wd, countryname);
            Thread.Sleep(3000);

            SelectDefaultLanguage(wd, deflanguage);
            Thread.Sleep(3000);

            SelectTimeFormat(wd, timef);
            Thread.Sleep(3000);

            HumanitySettings.ClickSaveSettings(wd);
            Thread.Sleep(3000);

            HumanityLogInTest.SignOut(wd);
            wd.Quit();
        }
        public static void SelectCountry(IWebDriver wd, string countryname)
        {
            SelectElement country = new SelectElement(HumanitySettings.GetCountry(wd));
            country.SelectByText(countryname);
        }

        public static void SelectDefaultLanguage(IWebDriver wd, string deflanguage)
        {
            SelectElement language = new SelectElement(HumanitySettings.GetDefaultLanguage(wd));
            language.SelectByText(deflanguage);
        }
        public static void SelectTimeFormat(IWebDriver wd, string timef)
        {
            SelectElement time = new SelectElement(HumanitySettings.GetTimeFormat(wd));
            time.SelectByText(timef);
        }
    }
}
