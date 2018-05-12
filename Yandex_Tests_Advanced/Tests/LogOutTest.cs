using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yandex_Tests_Advanced.PO;

namespace Yandex_Tests_Advanced.Tests
{
    class LogOutTest : AbstractTest
    {

        

        [Test]
        public void LogOut()
        {
            MailPage mailPage = new MailPage();         
            LoginApp("kirukato203@yandex.ru", "Rjcnz35610");
            SearchPage searchPage = mailPage.LogOutMail();

            String buttonTextActual = searchPage.ButtonTextActual();
            Assert.AreEqual("Войти в почту", buttonTextActual, "Разлогиневание не успешно");
        }
    }
}
