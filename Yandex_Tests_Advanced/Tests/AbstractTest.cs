using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yandex_Tests_Advanced.BisnesObject;
using Yandex_Tests_Advanced.Driver;
using Yandex_Tests_Advanced.PO;

namespace Yandex_Tests_Advanced.Tests
{
    class AbstractTest
    {

        [OneTimeSetUp] // вызывается перед началом запуска всех тестов
        public void OpenWindow()
        {
            DriverSession.OpenDriver();
            IWebDriver driver = DriverSession.GetDriver();
            driver.Url = "https://yandex.ru";
        }

        [OneTimeTearDown] //вызывается после завершения всех тестов
        public void ExitDriver()
        {
            DriverSession.CloseDriver();
        }


        protected void LoginApp(User user)
        {
            SearchPage searchPage = new SearchPage();
            LoginPage loginPage = searchPage.OpenLoginPage();
            loginPage.Login(user);

        }
    }
}
