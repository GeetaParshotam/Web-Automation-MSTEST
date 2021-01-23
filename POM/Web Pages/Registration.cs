using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace POM
{
    
    class Registration: CorePage
    {
        #region locators_registaron
        public By name = By.Id("username");
        public By password = By.Id("password");
        public By re_password = By.Id("re_password");
        public By full_name = By.Id("full_name");
        public By email = By.Id("email_add");
        public By terms = By.Id("tnc_box");
        public By register = By.Id("Submit");
        public By back = By.LinkText("Go back to Login page");
        #endregion
        
        public void user_registration()
        {
           // CorePage.DriverStart();
           // driver.Url = "https://adactinhotelapp.com/HotelAppBuild2/Register.php";
            log.Debug("setting URL ");
            driver.FindElement(name).SendKeys("Parshotam_Das");
            log.Debug(" Entering User Name Parshotam_Das");
            driver.FindElement(password).SendKeys("parshotam54");
            log.Debug(" Entering Password parshotam54");
            driver.FindElement(re_password).SendKeys("parshotam54");
            log.Debug(" Entering Re Password parshotam54  ");
            driver.FindElement(full_name).SendKeys("Parshotam Das");
            log.Debug(" Entering Full Name Parshotam Das");
            driver.FindElement(email).SendKeys("geetamelwani@hotmail.com");
            log.Debug("Entering Email geetamelwani@hotmail.com");
            driver.FindElement(terms).Click();
            log.Debug(" clicking on Terms ");
            driver.FindElement(register).Submit();
            driver.FindElement(back).Click();
            
      }

    }

  


}

