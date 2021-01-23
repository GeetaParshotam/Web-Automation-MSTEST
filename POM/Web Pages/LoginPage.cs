using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using System.Configuration;
using System.Collections.Specialized;



namespace POM
{
    public class LoginPage : CorePage
    {
        #region locators 
        public By username = By.Id("username");
        public By password = By.Id("password");
        public By loginbtn = By.Id("login");
        public By FP = By.LinkText("Forgot Password?");
        public By NU = By.LinkText("New User Register Here");
        #endregion

        public void login(string url,string expected ,string loc)
             {
          //string url = ConfigurationManager.AppSettings["URL"].ToString();
           driver.Url = url;
            string sAttr1 = ConfigurationManager.AppSettings.Get("Username");
           string sAttr2 = ConfigurationManager.AppSettings.Get("Password");
            string actualMessage = "";
                 driver.FindElement(username).SendKeys(sAttr1);
               //  log.Debug("Entering Username " + name);
                 driver.FindElement(password).SendKeys(sAttr2);
                // log.Debug("Entering Password " + pass);
                 SubmitElement(loginbtn);
                 log.Debug("Clicking Login Button ");
                 if (loc == "class")
                 {
                actualMessage = GetText(By.ClassName("auth_error"));
                 }
                 else if (loc== "LinkText")
                 {
                     actualMessage = GetText(By.LinkText("Logout"));
            }
            AssertAreStringEqual(actualMessage, expected);
                log.Debug("Asserting LogIn With Expected Messege " + expected + "And Actual Messege " + actualMessage);

             }
     
    }
}
