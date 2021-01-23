using Microsoft.VisualStudio.TestTools.UnitTesting;
using POM.TestCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Testcases
{
    
  public  class searchTC:CorePage
    {
        SearchPage searchPage = new SearchPage();
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "search", DataAccessMethod.Sequential)]
        [TestCategory("Search")]
        public void Data_Should_Search()
        {
            string loc = TestContext.DataRow["Location"].ToString();
            string name = TestContext.DataRow["hotelname"].ToString();
            string roomN0 = TestContext.DataRow["Room_No"].ToString();
            string dateIn = TestContext.DataRow["date"].ToString();
            string date_out = TestContext.DataRow["date_out"].ToString();
            string adultNo = TestContext.DataRow["adult"].ToString();

            SelectByValue(searchPage.Location, loc);
            log.Debug("Selecting Location: Sydney");

            SelectByValue(searchPage.hotelname, name);
            log.Debug("Selecting Hotels: Hotel Creek");

            SelectByValue(searchPage.Room_No, roomN0);
            log.Debug("Selecting Number of Rooms: 2");

            driver.FindElement(searchPage.date).SendKeys(dateIn);
            log.Debug("Check In Date: 13/01/2020");

            driver.FindElement(searchPage.date_out).SendKeys(date_out);
            log.Debug("Check In Date: 15/01/2020");

            SelectByValue(searchPage.adult, adultNo);
            log.Debug("Selecting Adults Per Room: 2");

            ClickElement(searchPage.Serach_btn);
        }



        [TestMethod, TestCategory("Search")]
        public void Search_Data_Should_Reset()
        {
            searchPage.reset_data();
            searchPage.reset_data();
            Logout();

        }

        [TestMethod, TestCategory("Search")]
        public void Search_Password_Should_Reset()
        {
            searchPage.reset_password();
            Logout();

        }
    }
}
