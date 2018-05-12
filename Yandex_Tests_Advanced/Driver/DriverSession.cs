using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yandex_Tests_Advanced.Driver
{
    class DriverSession
    {
        private static IWebDriver driver;

        public static void OpenDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void CloseDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
