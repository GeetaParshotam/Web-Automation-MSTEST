using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace POM
{
    class BookHotel : CorePage
    {
        #region Locators
        public By firstName = By.Id("first_name");
        public By lastNAme = By.Id("last_name");
        public By billingAddress = By.Id("address");
        public By cardNumber = By.XPath("//input[@id='cc_num']");
        public By cardType = By.Id("cc_type");
        public By expireDateMonth = By.Id("cc_exp_month");
        public By expireDateYear = By.Id("cc_exp_year");
        public By ccvNumber = By.Id("cc_cvv");
        public By confirmBookibg = By.Id("book_now");
        public By Return = By.LinkText("Back");
        #endregion


        public void previousPage()
        {

            // driver.FindElement(Return).Click();
            ClickElement(Return);
            log.Info("Go to Previous Page");
        }
    }
}
