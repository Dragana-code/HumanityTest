using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HumanityTest.Page.Objects;
using HumanityTest.Page.Test;

namespace HumanityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //HumanityAddNewEmployeeTest.AutomaticAddNewEmployee();
            //HumanityLogInTest.TestHumanityLogIn();



                //IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            
                Console.WriteLine("Today we are testing www.humanity.com web page.");
                Console.WriteLine("Please choose:");
                Console.WriteLine("1 for manual Log In Testing,");
                Console.WriteLine("2 for automatic Log In Testing,");
                Console.WriteLine("3 for manual Add New Employee Testing,");
                Console.WriteLine("4 for automatic Add New Employee Testing,");
                Console.WriteLine("5 for Exit.");

                int m;
                m = int.Parse(Console.ReadLine());

                switch (m)
                {
                    case 1:
                        {
                            Console.WriteLine("Manual Log In Testing will start...");
                            HumanityLogInTest.TestHumanityLogIn();
                            //wd.Quit();
                            break;
                        }
                    case 2:
                        {
                            HumanityLogInTest.AutomaticTestHumanityLogIn();
                            break;
                        }
                    case 3:
                        {
                            HumanityAddNewEmployeeTest.AddNewEmployee();
                            break;
                        }
                    case 4:
                        {
                            HumanityAddNewEmployeeTest.AutomaticAddNewEmployee();
                            break;
                        }
                   case 5:
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
            
            

            //HumanityLogInTest.UploadPhoto();

            //
            //

            //

            //HumanityProfile.UploadPicture();

            //test upload image
            





        }
    }
}
