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
        string name;

        public void setUpGame()
        {
            setUpPlayers();
        }

        public void setUpPlayers()
        {
            Console.WriteLine("Let's play Lemonade Stand! You have $30 to invest in your first day's ingredients and to purchase cups. With regard to the temperature and forecast, mix up the best-selling batches of lemonade to earn as much money as you can in one week. You will have the opportunity to purchase more supplies each morning in preparation for the day of sales. Each glass of lemonade must include lemon, sugar, and ice, but the quantities of each are up to your discretion. Good luck!");
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
                Player player = new Player();
                Customer customer = new Customer();
                lemonadeDay(players[i]);
                weather.GetTemperature();
                weather.forecast();
                //SHOPPING
                Console.WriteLine("It is " + weather.actualTemperature + " degrees fahrenheit today.");
                Console.WriteLine("It is " + weather.precipitationForecast + " today.");
                player.addLemons();
                player.addSugar();
                player.addIce();
                player.costOfLemonade();
                customer.MakeCustomers();
                customer.BuyLemonade();
                customer.lemonadeSales();
                player.sales();
            }
        }
        //move this?lemonadeDay to Day?
        public void lemonadeDay()
        {
            int day = currentDay.potentialCustomers;
            Weather weather = new Weather();
            int i = 0;
            int j = 0;
            Store store = new Store();
            Inventory inventory = new Inventory();
            for (i = 0; i <= players.Count; i++)
            {
                store.buyLemons(players[i]);
                store.buySugar(players[i]);
                store.buyIce(players[i]);
                store.buyGlass(players[i]);
                inventory.getIngredients(players[i]);
                players[i].addLemons(players[i]);
                players[i].addSugar(players[i]);
                players[i].addIce(players[i]);
                players[i].costOfLemonade(players[i]);
                currentDay.customer[j].buyLemonade(weather);
                currentDay.customer[0].buyLemonade(players[i]);
                bool check = currentDay.customer[j].interestedInLemonade;
                players[i].sales();
            }
        }
    }
}