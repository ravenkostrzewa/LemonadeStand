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
        public int actualTemperature;
        public bool precipitation;
        public string forecastPrecipitation;
        public int potentialCustomers = 100;
        public int currentLemonadePrice;
        public int buyLemonade;
        public int buyAnotherGlass;
        public int todaysSales;
        public void Forecast(Weather weather)
        {
            Console.WriteLine("Temperature: " + weather.actualTemperature + " degrees fahrenheit");
            Console.WriteLine("Weather: " + weather.precipitationForecast);
        }
    }
}


