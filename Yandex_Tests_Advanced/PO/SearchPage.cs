using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yandex_Tests_Advanced.PO
{
    class SearchPage : AbstractPage
    {
        [FindsBy(How = How.LinkText, Using = "Войти в почту")]
        private IWebElement loginButton;

        public LoginPage OpenLoginPage()
        {
            loginButton.Click();

            return new LoginPage();
        }

        public String ButtonTextActual()
        {
            String buttonActual = loginButton.Text;
            return buttonActual;
        }
    }
}
