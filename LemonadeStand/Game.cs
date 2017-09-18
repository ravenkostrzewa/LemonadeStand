using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        List<Player> players = new List<Player>();
        string userInput;

        public void setUpGame()
        {
            setUpPlayers();
        }

        public void setUpPlayers()
        {
            Console.WriteLine("Let's play Lemonade Stand! You have $30 to invest in your first day's ingredients and to purchase cups. With regard to the temperature and humidity, mix up the best-selling batches of lemonade to earn as much money as you can in one week. You will have the opportunity to purchase more supplies each morning in preparation for the day of sales. Each glass of lemonade must include lemon, sugar, and ice, but the quantities of each are up to your discretion. Good luck!");
            Console.WriteLine("Enter 1 to play by yourself or the total number of players if you will be playing with friends.");
            int number = Int32.Parse(Console.ReadLine());
            for (int x = 1; x <= number; x++)
            {
                Console.WriteLine("What is your name?");
                string userInput = Console.ReadLine();
                players.Add(new Player());
            }
        }

        public void RunGame()
        {
            int days = 0;
            while (days < 7)
            {
                Day day = new Day();
                Weather weather = new Weather();
                lemonadeDay(day);
                weather.GetTemperature();
                weather.forecast();
                //shopping
                Console.WriteLine("It is " + weather.actualTemperature + " degrees fahrenheit today.");
                Console.WriteLine("It is " + weather.precipitationForecast + " today");

            }
        }
        public void lemonadeDay(Day currentDay)
        {
            int day = currentDay.potentialCustomers;
            // day = (currentDay.potentialCustomers = 0; currentDay.potentialCustomers <= 100; currentDay.potentialCustomers++);
            Weather weather = new Weather();
            int i = 0;
            int j = 0;
            Store store = new Store();
            for (i = 0; i <= players.Count; i++)
            {
                store.buyLemons(players[i]);
                store.buySugar(players[i]);
                store.buyIce(players[i]);
                store.buyGlasses(players[i]);
                players[i].useLemons(players[i]);
                players[i].useSugar(players[i]);
                players[i].useIce(players[i]);
                players[i].chargePerGlass(players[i]);            }
                store.completeTransaction(players[i]);
                //currentDay.customer[j].BuyLemonade(weather);
                // currentDay.customer[0].buyLemonade(Weather weather);
                //bool check = currentDay.customer[j].interestedInLemonade;
                players[i].sales();
        }
    }
}