using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yandex_Tests_Advanced.BisnesObject;
using Yandex_Tests_Advanced.PO;

namespace Yandex_Tests_Advanced.Tests
{
    class LoginTest : AbstractTest
    {

        [Test]
        public void Login() {
            User user = new User("kirukato203@yandex.ru", "Rjcnz35610");


            LoginApp(user);
            MailPage mailPage = new MailPage();

            String loginActual = mailPage.LoginActual();
            Assert.AreEqual("kirukato203", loginActual, "Вход не выполнен");
        }


        
    }
}
