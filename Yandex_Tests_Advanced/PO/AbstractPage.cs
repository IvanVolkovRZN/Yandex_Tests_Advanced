using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yandex_Tests_Advanced.Driver;

namespace Yandex_Tests_Advanced.PO
{
   abstract class AbstractPage
    {
        private IWebDriver driver;

        public AbstractPage()
        {
           
            this.driver = DriverSession.GetDriver();

            PageFactory.InitElements(driver, this);


        }
    }
}
