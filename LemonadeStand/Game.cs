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
            Console.WriteLine("Let's play Lemonade Stand! You have $30 to invest in your first day's ingredients and to purchase cups. With regard to the temperature and humidity, mix up the best-selling batches of lemonade and earn as much money as you can in one week. You will have the opportunity to purchase more supplies each morning in preparation for the day of sales. Each glass of lemonade must include lemon, sugar, and ice, but the quantities of each are up to your discretion. Good luck!");
            Console.WriteLine("Enter 1 to play by yourself or the total number of players if you will be playing with friends");
           int  number = Int32.Parse(Console.ReadLine());
            for (int x = 0; x <= number; x++)
            {
                Console.WriteLine("What is your name?");
                string userInput = Console.ReadLine();
               // players[i] = userInput;
            }

            //    PlayerOne.name = userInput;
            //    PlayerOne = new Player();
            //    Console.WriteLine("Enter 1 to play by yourself, 2 to play with a friend, or 3 to play with the computer.");
            //}

            //if (userInput == "2")
            //{
            //    Console.WriteLine("PlayerTwo, what is your name?");
            //    PlayerTwo.name = userInput;
            //    PlayerTwo = new Player();
            //}
            //else if (userInput == "3")
            //{
            //    PlayerTwo = new Computer();
            //    Console.WriteLine("Let's Play!");
            //}
            //else if (userInput == "1")
            //{
            //    Console.WriteLine("Let's Play!");
            //}
            //else if (userInput != "1" && userInput != "2 && userInput != "3")
            //{
            //    Console.WriteLine("Sorry, that is not a valid entry. Would you like to play Lemonade Stand? Enter yes or no.");
            //    if (userInput == "no")
            //    //go to end of game
            //    else
            //    {
            //        //loop
            //    }
            }
        

        public void RunGame()
        {
            int days = 0;
            while (days < 7)
            {
                Day day = new Day();
                lemonadeDay(day);
            }
        }
        public void lemonadeDay(Day currentDay)
        {
            int day = currentDay.potentialCustomers;
            // day = (currentDay.potentialCustomers = 0; currentDay.potentialCustomers <= 100; currentDay.potentialCustomers++);
            Weather weather = new Weather();
            int i = 0;
            int j = 0;

            players[i].shoppingList();
            players[i].completeTransaction();
            players[i].sellLemonade();
            currentDay.customer[j].BuyLemonade(weather);
            // currentDay.customer[0].buyLemonade(Weather weather);
            bool foo = currentDay.customer[j].interestedInLemonade;
            players[i].sales();


        }
    }
}