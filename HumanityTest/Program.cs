using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HumanityTest.Page.Objects;
using HumanityTest.Page.Test;
using System.Threading;

namespace HumanityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, today we are testing www.humanity.com web page.");
            Console.WriteLine("Please choose:");
            Console.WriteLine("1 for Manual Add New Employee Testing.");
            Console.WriteLine("2 for Automatic Add New Employee Testing.");
            Console.WriteLine("3 for Humanity Edit Staff Testing.");
            Console.WriteLine("4 for Home Page Testing.");
            Console.WriteLine("5 for Manual LogIn and SignOut Testing.");
            Console.WriteLine("6 for Automatic LogIn Testing.");
            Console.WriteLine("7 for Humanity Menu Testing.");
            Console.WriteLine("8 for Humanity Profile Testing.");
            Console.WriteLine("9 for Humanity Settings Testing.");
            Console.WriteLine("10 for Humanity Staff Testing.");
            Console.WriteLine("0 for Exit Testing.");

            int m = int.Parse(Console.ReadLine());
            do
            {
                switch (m)
                {
                    case 1:
                        {
                            Console.WriteLine("Manual Add New Employee Test will start...");

                            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
                            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                            wd.Manage().Window.Maximize();

                            HumanityAddNewEmployeeTest.AddNewEmployee(wd);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Automatic Add New Employee Test will start...");

                            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
                            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                            wd.Manage().Window.Maximize();

                            HumanityAddNewEmployeeTest.AutomaticAddNewEmployee(wd);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Humanity Edit Staff Test will start....");

                            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
                            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                            wd.Manage().Window.Maximize();

                            HumanityEditStaffTest.EditStaff(wd);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Home Page Test will start...");

                            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
                            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                            wd.Manage().Window.Maximize();

                            HumanityHomeTest.HomePageTest(wd);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Manual LogIn and SignOut Testing will start...");

                            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
                            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                            wd.Manage().Window.Maximize();

                            HumanityLogInTest.HumanityLogIn(wd);
                            Thread.Sleep(3000);
                            HumanityLogInTest.SignOut(wd);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Automatic Log In Testing will start...");

                            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
                            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                            wd.Manage().Window.Maximize();

                            HumanityLogInTest.AutomaticHumanityLogIn(wd);
                            Thread.Sleep(3000);

                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Humanity Menu Test will start...");

                            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
                            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                            wd.Manage().Window.Maximize();

                            HumanityMenuTest.MenuTest(wd);
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Humanity Profile Test will start...");

                            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
                            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                            wd.Manage().Window.Maximize();

                            HumanityProfileTest.ProfileTest(wd);
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Humanity Settings Test will start...");

                            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
                            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                            wd.Manage().Window.Maximize();

                            HumanitySettingsTest.SettingsTest(wd);
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Humanity Staff Test will start...");

                            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
                            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                            wd.Manage().Window.Maximize();

                            HumanityStaffTest.Staff(wd);
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("You have choosen EXIT.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please, choose again.");
                            break;
                        }
                }
            }
            while (m != 0);



        }
    }
}
