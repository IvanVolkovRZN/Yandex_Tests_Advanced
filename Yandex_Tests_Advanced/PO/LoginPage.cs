using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yandex_Tests_Advanced.BisnesObject;

namespace Yandex_Tests_Advanced.PO
{
    class LoginPage : AbstractPage
    {
        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement loginInput;

        [FindsBy(How = How.Name, Using = "passwd")]
        private IWebElement passwdInput;

        [FindsBy(How = How.ClassName, Using = "passport-Button-Text")]
        private IWebElement loginMailButton;

        

    
        public MailPage Login(User user)
        {
            loginInput.SendKeys(user.login);
            passwdInput.SendKeys(user.password) ;
            loginMailButton.Click();
            return new MailPage();


        }



    }
}
