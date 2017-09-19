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
        int number;

        public void setUpGame()
        {
            setUpPlayers();
        }

        public void setUpPlayers()
        {
            Console.WriteLine("Let's play Lemonade Stand! You have $30 to invest in your first day's ingredients and to purchase cups. With regard to the temperature and forecast, mix up the best-selling batches of lemonade to earn as much money as you can in one week. You will have the opportunity to purchase more supplies each morning in preparation for the day of sales. Each glass of lemonade must include lemon, sugar, and ice, but the quantities of each are up to your discretion. Good luck!");
            Console.WriteLine("Enter 1 to play by yourself or the total number of players if you will be playing with friends.");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                for (int x = 1; x <= number; x++)
                {
                    Console.WriteLine("What is your name?");
                    string userInput = Console.ReadLine();
                    Player player = new Player();
                    player.name = userInput;
                    players.Add(player);
                }
            }
            catch
            {
                Console.WriteLine("Your entry is invalid. Your answer should be an integar.");
            }
        }

        public void RunGame()
        {
            int days = 0;
            int i;
            while (days < 7)
            {
                Day day = new Day();
                Inventory inventory = new Inventory();
                Weather weather = new Weather();
                Player player = new Player();
                Customer customer = new Customer();
                Store store = new Store();


                for (i = 0; i <= players.Count; i++)
                {
                    weather.GetTemperature();
                    weather.forecast();
                    store.buyLemons(players[i]);
                    store.buySugar(players[i]);
                    store.buyIce(players[i]);
                    store.buyGlass(players[i]);
                    players[i].ofInventory.getIngredients();     
                    day.Forecast(weather);
                    player.addLemons();
                    player.addSugar();
                    player.addIce();
                    player.costOfLemonade();
                    customer.MakeCustomers();
                    customer.BuyLemonade(weather);
                    bool check = customer.interestedInLemonade;
                    players[i].sales();
                }
            }
            Console.WriteLine("Game Over");
        }
    }
}
