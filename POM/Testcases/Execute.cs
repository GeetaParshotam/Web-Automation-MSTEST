using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using System;
using POM.TestCases;
using System.Threading;
using System.Configuration;
using System.Collections.Specialized;
using POM.Testcases;

namespace POM
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    /// 
    [TestClass]
    public class Execute : CorePage
    {

        LoginPage loginPage = new LoginPage();
        // SearchPage searchPage = new SearchPage();
        searchTC TC = new searchTC();
        HotelSelection hotelSelection = new HotelSelection();
        BookHotel bookHotel = new BookHotel();
        BookingConfirmation bookingDetails = new BookingConfirmation();
        Booked_Itinerary booked_Itinerary = new Booked_Itinerary();


        #region Initializations and Cleanups

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

        [TestInitialize, TestCategory("Login")]
        public void initialize()
        {
            CorePage.DriverStart();
          // string sAttr = ConfigurationManager.AppSettings.Get("URL");
            
            loginPage.login("https://adactinhotelapp.com/HotelAppBuild2/","TesterGeeta","TesterGeeta","Logout", "LinkText");
        }
        [TestCleanup]
        public void cleanup()
        {
            screenShot();
            CorePage.driver.Quit();

        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            //  CorePage.DriverStart();
            //  Registration reg = new Registration();
            //  reg.user_registration("https://adactinhotelapp.com/HotelAppBuild2/");
            // CorePage.screenShot();
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
        }
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {

        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {

        }
        #endregion

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        #region TestMethods
       /** [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "search", DataAccessMethod.Sequential)]
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

           SelectByValue(searchPage.hotelname,name);
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

        }*/

        [TestMethod, TestCategory("Select_Hotel")]
        public void Select_Hotel()
        {
            // searchPage.SerachHotel();
            TC.Data_Should_Search();
            hotelSelection.confirm_hotel();
           
        }

        [TestMethod, TestCategory("Select_Hotel")]
        public void Cancel_Hotel_Should_Performed()
        {
            // searchPage.SerachHotel();
           // Data_Should_Search();
            hotelSelection.CancelSelection();
          
        }

        [TestMethod, TestCategory("Select_Hotel")]
        public void Booked_Hotel_Details__Should_Search()
        {

            // searchPage.SerachHotel();
           // Data_Should_Search();
            hotelSelection.Booking_history();
           
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml","hotelBooking", DataAccessMethod.Sequential)]
        [TestMethod, TestCategory("Booking")]
       
        public void Booking()
        {
           TC. Data_Should_Search();
            string f_name = TestContext.DataRow["firstName"].ToString();
            string l_name = TestContext.DataRow["lastName"].ToString();
            string billingAddress = TestContext.DataRow["billingaddress"].ToString();
            string cardNo = TestContext.DataRow["cardNumber"].ToString();
            string cardType = TestContext.DataRow["cardType"].ToString();
            int expiredateMonth = Convert.ToInt32(TestContext.DataRow["expireDateMonth"]);
           // int expiredateYear = (int)TestContext.DataRow["expireDateYear"];
            string ccvNumber = TestContext.DataRow["ccvNumber"].ToString();
            driver.FindElement(bookHotel.firstName).SendKeys(f_name);
            log.Debug("Entering First Name");
            driver.FindElement(bookHotel.lastNAme).SendKeys(l_name);
            log.Debug("Entering Last Name: parshotam");
            driver.FindElement(bookHotel.billingAddress).SendKeys(billingAddress);
            log.Debug("Entering Billing Address: Gulshan Karachi");
            driver.FindElement(bookHotel.cardNumber).SendKeys(cardNo);
            log.Debug("Entering Credit Card Number: 1234567891234567");

            SelectByValue(bookHotel.cardType, cardType);
            log.Debug("Selecting Credit Card Type: American Express");

            SelectByIndex(bookHotel.expireDateMonth, 1);
            log.Debug("Selecting Expired Month");

            SelectByIndex(bookHotel.expireDateYear, 10);
            log.Debug("Selecting Expired Year");
            driver.FindElement(bookHotel.ccvNumber).SendKeys(ccvNumber);
            log.Debug("Entering CVV Number: 0347");

            ClickElement(bookHotel.confirmBookibg);
            log.Debug("Clicking Book Now Button");
            Thread.Sleep(5000);
        }

        [TestMethod, TestCategory("Booking")]
        public void Back_To_Previous_Page()
        {
            // searchPage.SerachHotel();
           // Data_Should_Search();
            hotelSelection.confirm_hotel();
            bookHotel.previousPage();
           
          }

        [TestMethod, TestCategory("Booking Confirmation")]
        public void Confirmation()
        {
            // searchPage.SerachHotel();
           // Data_Should_Search();
            hotelSelection.confirm_hotel();
            Booking();
            Thread.Sleep(5000);
            bookingDetails.myItinerary();
          

        }

        [TestMethod, TestCategory("Booking Confirmation")]
        public void Confirmation_Back_To_Search_Hotel()
        {
            // searchPage.SerachHotel();
          //  Data_Should_Search();
            hotelSelection.confirm_hotel();
            Booking();
            Thread.Sleep(5000);
            bookingDetails.SearchHotel();
          
        }
        [TestMethod, TestCategory("My Itinerary")]
        public void Booked_Itinerary()
        {
            //  searchPage.SerachHotel();
           // Data_Should_Search();
            hotelSelection.confirm_hotel();
            Booking();
            Thread.Sleep(5000);
            bookingDetails.myItinerary();
            Thread.Sleep(5000);
            booked_Itinerary.cancelHotel();
            
         }

        [TestMethod, TestCategory("My Itinerary")]
        public void Search_OrderId()
        {
           
         //   Data_Should_Search();
            hotelSelection.confirm_hotel();
            Booking();
            Thread.Sleep(5000);
            bookingDetails.myItinerary();
            Thread.Sleep(5000);
            booked_Itinerary.Search_OrderID();
        }
    }
}
#endregion
