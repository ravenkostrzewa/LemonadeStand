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


        //daily forecast (temperature and precipitation) and actual weather (temperature may change, percipitation remains true to prediction) are the same for all players

        public void Forecast(Weather weather)
        {


        }
    }
}

        //public List<Customer> customer = new List<Customer>();

        //public void CheckOutCustomerForPurchase()
        //{
        //  todaysSales =  (((currentLemonadePrice) * (buyLemonade)) + ((currentLemonadePrice) * (buyAnotherGlass)) + todaysSales);
        //    Console.WriteLine("You have $" + todaysSales + " in sales today.");
        //}
        //public void CreateCustomers()
        //{

        //}



