using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace POM
{
    class BookingConfirmation : CorePage
    {
        
        public By itinerary = By.Id("my_itinerary");
        public By search = By.Id("search_hotel");


            public void myItinerary()
            {
            //driver.FindElement(itinerary).Click();
            ClickElement(itinerary);
            log.Debug("clicking On itinerary");
        }


            public void SearchHotel()
            {

            //driver.FindElement(search).Click();
            ClickElement(search);
            log.Info("click on Search hotel button");
            }
        }
    }

