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
       List<Weather> weather = new List<Weather>();
    }
}

public void temperature()
{
    z = rnd.Next(1, 12);
    if (z = 1)
    {
        (temperature >= 45 && temperature <= 58);
        rnd.Next(40, 55);
    }
    else if (z >= 2 && z <= 10)
    {
        (temperature >= 59 && temperature <= 79);
        (rnd.Next(59, 79);
    }
    else
    {
        (temperature >= 80);
        (rnd.Next(80, 94);
    }

    // CALCULATE TO PREDICT WEEKLY FORECAST FOR TEMPERATURE
    // RECALCULATE FROM SAME Z VALUE FOR DAILY FORECAST FOR TEMPERATURE
    // CALCULATE TO PREDICT WEEKLY PRECIPITATION FORECAST
    // PREDICTION HOLDS TRUE FOR DAILY PRECIPITATION FORECAST




    public void forecast()
{
    y = rnd.Next(1, 4)
    if (y = 1)
    {
        precipitation = true;
        rnd.Next(1, 20);
            if (y = 1)
            {
                precipitationForecast = "hail";
            }
            else if (2, 15)
            {
                precipitationForecast = "light rain";
            }
            else
            {
                precipitationForecast = "thunderstorms";
            }
    }
    else
    {
         precipitation == false;
         rnd.Next(1, 6)
            if (y = 1 || y = 2)
        {
               precipitationForecast = "clear skies";
        }
            else if (y = 3 || y = 4)
        {
               precipitationForecast = "cloudy";
        }
            else if (y = 5 || y = 6)
        {
               precipitationForecast = "sunny";
        }

    }

 }



}