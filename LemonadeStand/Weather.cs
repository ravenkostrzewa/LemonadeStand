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
        public int actualTemperature;
        Random rnd = new Random();
        List<Weather> weather = new List<Weather>();
        public int forecastPossibility;

//predict temperature and forecast prior to shopping, show actual temperature (within range of predicted temperature) and forecast (same as predicted) method after buying supplies each morning

        public void GetTemperature()
        {
            temperatureRange = rnd.Next(1, 12);
            if (temperatureRange == 1)
            {
                {
                    temperature = rnd.Next(45, 58);
                    actualTemperature = rnd.Next(49, 56);
                }
                Console.WriteLine("Temperature: The weatherman predicts that it will be " + temperature + " degrees fahrenheit today.");
            }
            else if (temperatureRange >= 2 && temperatureRange <= 10)
            {
                {
                    temperature = rnd.Next(59, 79);
                    actualTemperature = rnd.Next(64, 74);
                }
                Console.WriteLine("Temperature: The weatherman predicts that it will be " + temperature + " degrees fahrenheit today.");
            }
            else
            {
                {
                    temperature = rnd.Next(80, 94);
                    actualTemperature = rnd.Next(84, 89);
                }
                Console.WriteLine("Temperature: the weatherman predicts that it will be " + temperature + " degrees fahrenheit today.");
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
                    Console.WriteLine("Weather: The weatherman predicts that there will be " + precipitationForecast + " today.");
                }
                else if (forecastPossibility >= 2 && forecastPossibility <= 15)
                {
                    precipitationForecast = "light rain";
                    Console.WriteLine("Weather: The weatherman predicts that there wil be " + precipitationForecast + " today.");
                }
                else
                {
                    precipitationForecast = "thunderstorm";
                    Console.WriteLine("Weather: The weatherman predicts that there will be a " + precipitationForecast + " today.");
                }
            }
            else
            {
                precipitation = false;
                forecastPossibility = rnd.Next(1, 6);
                if (forecastPossibility == 1 || forecastPossibility == 2)
                {
                    precipitationForecast = "clear skes";
                    Console.WriteLine("Weather: The weather man predicts that there will be " + precipitationForecast + " today.");
                }
                else if (forecastPossibility == 3 || forecastPossibility == 4)
                {
                    precipitationForecast = "cloudy skies";
                    Console.WriteLine("Weather: The weatherman predicts " + precipitationForecast + " today.");
                }
                else if (forecastPossibility == 5 || forecastPossibility == 6)
                {
                    precipitationForecast = "sunny";
                    Console.WriteLine("Weather: The weatherman predicts that today will be a very " + precipitationForecast + ".");
                }

            }

        }
    }
}