using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace POM.TestCases
{
    
 
   public  class SearchPage : CorePage
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        #region SearchPage Locators
        public By Location = By.Id("location");
        public By hotelname = By.Id("hotels");
        public By Room_No = By.Id("room_nos");
        public By date = By.Id("datepick_in");
        public By date_out = By.Id("datepick_out");
        public By adult = By.Id("adult_room");
        public By child = By.Id("child_room");
        public By Serach_btn = By.Id("Submit");
        public By reset = By.Id("Reset");
        public By resetPass = By.LinkText("Change Password");

        #endregion
      
        public void reset_data()
        {
            SelectByValue(Location, "Sydney");
            log.Debug("Selecting Location: Sydney");
            ClickElement(reset);
            log.Info("Click on reset button");
        }
        public void reset_password()
        {
            ClickElement(resetPass);
            log.Info("Click on change password hyperlink");
            
        }


    }
}