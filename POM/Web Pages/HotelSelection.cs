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
    class HotelSelection : CorePage
    {
        #region locators
        public By select = By.Id("radiobutton_1");
        public By proceed = By.Id("continue");


        #endregion

        #region other controls
        public By history = By.LinkText("Booked Itinerary");
        public By cancel = By.Id("cancel");
       

        #endregion


        public void confirm_hotel()
        {
            ClickElement(select);
            log.Debug("Clicking Radio Button ");
            ClickElement(proceed);
            log.Debug("Clicking Continue ");
            Thread.Sleep(5000);
        }
       
        public void Booking_history()
        {
            ClickElement(history);
            log.Info("click on my itinerary");
        }
        public void CancelSelection()
        {
            
            ClickElement(cancel);
            log.Info("Click on cancel button");
        }


    }
}
