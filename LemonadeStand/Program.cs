﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {


        static void Main(string[] args)
        {
            //Game game = new Game();
            //game.setUpPlayers();
            //game.RunGame();
            Weather weather = new Weather();

            weather.GetTemperature();
            weather.forecast();
            Console.ReadKey();
        }
    }
}