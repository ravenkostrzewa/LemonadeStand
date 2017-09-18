using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public int temperature;
        public bool precipitation;
        public int potentialCustomers = 100;
        public int currentLemonadePrice;
        public int buyLemonade;
        public int buyAnotherGlass;
        public int todaysSales;

        public List<Customer> customer = new List<Customer>();

        public void CheckOutCustomerForPurchase()
        {
          todaysSales =  (((currentLemonadePrice) * (buyLemonade)) + ((currentLemonadePrice) * (buyAnotherGlass)) + todaysSales);
        }
        public void CreateCustomers()
        {

        }



        //daily forecast (temperature and precipitation);
        //weekly forecast (temperature and precipitation);

        public void Forecast(Weather weather)
        {


            for (int i = 0; i <= 7; i++) {
                //predict for entire week
                //predict for current day from z value
                //predict precipitation forecast for the entire week
                //prediction holds true for each day
                //show prediction for temperature and precipitation for current day and the remainder of the week
            }
        }
    }
}


