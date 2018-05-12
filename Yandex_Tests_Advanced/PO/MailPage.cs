using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yandex_Tests_Advanced.PO
{
    class MailPage : AbstractPage
    {

        [FindsBy(How = How.ClassName, Using = "mail-User-Name")]
        private IWebElement userName;

        [FindsBy(How = How.LinkText, Using = "Выйти из сервисов Яндекса")]
        private IWebElement buttonOut;
        

        public String LoginActual()
        {
            String logActual = userName.Text;
            return logActual;
        }

        public SearchPage LogOutMail()
        {
            userName.Click();
            buttonOut.Click();
            return new SearchPage();
        }


    }
}
