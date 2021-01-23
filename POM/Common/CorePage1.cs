using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using System.Collections.Specialized;

namespace POM
{

    #region Common Methods
    public class CorePage
    {
       // public static System.Collections.Specialized.NameValueCollection AppSettings { get; }
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static IWebDriver driver

        {
            get;
            set;
        }

        public static Screenshot image;
        public static By logout = By.LinkText("Logout");

        public static IWebDriver DriverStart()
        {

            driver = new ChromeDriver("C:/Users/HP/Desktop");
            driver.Manage().Window.Maximize();
            return driver;
        }
            
             public static void screenShot()
        {
            image = ((ITakesScreenshot)driver).GetScreenshot();
            image.SaveAsFile("C:/Users/HP/source/repos/POM (V2)/POM/screenshot.png", ScreenshotImageFormat.Png);
            log.Debug("Take Screenshot of Expected Result");


        }

        public static void Logout()
        {
 
        driver.FindElement(logout).Click();
        log.Debug("Clicking On LogOut Button");
        }
        #endregion

        #region Actions
        public static void ClickElement(By by)
        {
            driver.FindElement(by).Click();
        }
        public static void SubmitElement(By by)
        {
            driver.FindElement(by).Submit();
        }
        public static void AssertAreStringEqual(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
        public static string GetText(By by)
        {
            return driver.FindElement(by).Text;
        }
        public static void SelectByValue(By by, string selectedValue)
        {
            var webElement = driver.FindElement(by);
            var WebSelectElement = new SelectElement(webElement);
            WebSelectElement.SelectByValue(selectedValue);
        }
        public static void SelectByIndex(By by, int selectedIndex)
        {
            var webElement = driver.FindElement(by);
            var WebSelectElement = new SelectElement(webElement);
            WebSelectElement.SelectByIndex(selectedIndex);
        }

        #endregion





    }
}
