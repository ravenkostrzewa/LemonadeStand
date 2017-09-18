using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public int temperature;
        public bool precipitation;
        public string precipitationForecast;
        public int temperatureRange;
        Random rnd = new Random();
        List<Weather> weather = new List<Weather>();
        public int forecastPossibility;



        public void GetTemperature()
        {
            temperatureRange = rnd.Next(1, 12);
            if (temperatureRange == 1)
            {
                {
                    temperature = rnd.Next(45, 58);
                }
                Console.WriteLine("The weatherman predicts that it will be " + temperature + " degrees fahrenheit");
            }
            else if (temperatureRange >= 2 && temperatureRange <= 10)
            {
                {
                    temperature = rnd.Next(59, 79);
                }
                Console.WriteLine("The weatherman predicts that it will be " + temperature + " degrees fahrenheit");
            }
            else
            {
                {
                    temperature = rnd.Next(80, 94);
                }
                Console.WriteLine("The weatherman predicts that it will be " + temperature + " degrees fahrenheit");
            }
        }

        public void forecast()
        {
            forecastPossibility = rnd.Next(1, 4);
            if (forecastPossibility == 1)
            {
                precipitation = true;
                rnd.Next(1, 20);
                if (forecastPossibility == 1)
                {
                    precipitationForecast = "hail";
                    Console.WriteLine("The weatherman predicts " + precipitationForecast);
                }
                else if (forecastPossibility >= 2 && forecastPossibility <= 15)
                {
                    precipitationForecast = "light rain";
                    Console.WriteLine("The weatherman predicts " + precipitationForecast);
                }
                else
                {
                    precipitationForecast = "thunderstorms";
                    Console.WriteLine("The weatherman predicts " + precipitationForecast);
                }
            }
            else
            {
                precipitation = false;
                forecastPossibility = rnd.Next(1, 6);
                if (forecastPossibility == 1 || forecastPossibility == 2)
                {
                    precipitationForecast = "clear skies";
                    Console.WriteLine("The weather man predicts " + precipitationForecast);
                }
                else if (forecastPossibility == 3 || forecastPossibility == 4)
                {
                    precipitationForecast = "a cloudy day";
                    Console.WriteLine("The weatherman predicts " + precipitationForecast);
                }
                else if (forecastPossibility == 5 || forecastPossibility == 6)
                {
                    precipitationForecast = "a sunny day";
                    Console.WriteLine("The weatherman predicts " + precipitationForecast);
                }

            }

        }
    }
}