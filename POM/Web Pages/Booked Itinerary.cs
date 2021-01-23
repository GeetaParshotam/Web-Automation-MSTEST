using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace POM
{
    class Booked_Itinerary : CorePage
    {
        public By cancel = By.Name("cancelall");
        public By search = By.Id("search_hotel");
        public By Serach_Order = By.Id("order_id_text");
        public By submit = By.Id("search_hotel_id");
   
      public void cancelHotel()
        {
            // driver.FindElement(cancel).Click();
            ClickElement(cancel);
            log.Debug("clicking On cancel button");
            driver.SwitchTo().Alert().Accept();
            log.Info("click ok on alert box");
        }
        public void Search_OrderID()
        {
            driver.FindElement(Serach_Order).SendKeys("1233");
            // driver.FindElement(submit).Click();
            ClickElement(submit);
            log.Info("Search order-id");
        }

    }
}
