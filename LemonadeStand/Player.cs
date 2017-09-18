using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        Inventory backpack = new Inventory();

        public double newCurrentBalance;
        public double dollars;
        public double suppliesCost;
        public double lemonCost = .30;
        public double sugarPacketCost = .05;
        public double totalSugarPacketCost;
        public double iceCost = .05;
        public double totalIceCost;
        public double glassCost = .15;
        public double totalGlassCost;
        public double currentLemonadePrice;
        public string name;
        public double currentRecipeSales;
        public double currentRecipesSold;
        public double lemonadeMix;
        public double weekToDateProfit;
        public double todaysSales;
        public double weekToDateSales;
        public int lemons;
        public int sugar;
        public int ice;

        //  Inventory lists
        //List<Lemon> lemons = new List<Lemon>();
        //List<Sugar> sugar = new List<Sugar>();
        //List<Ice> ice = new List<Ice>();
        //List<Glass> glass = new List<Glass>();


        //money is in dollars 0.00

        public void useLemons(Player player)
        {
            Console.WriteLine(player.name + ", how many lemons would you like to use?");
            try
            {
                lemons = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                useLemons(player);
            }
        }

        public void useSugar(Player player)
        {
            Console.WriteLine(player.name + ", how many sugar packets would you like to use?");
            try
            {
                sugar = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                useSugar(player);
            }
        }

        public void useIce(Player player)
        {
            Console.WriteLine(player.name + ", how many ice cubes would you like to use?");
            try
            {
                ice = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                useIce(player);
            }
        }

        public void chargePerGlass(Player player)
        {
            Console.WriteLine(player.name + ", in dollars, how much would you like to charge per glass? ie. 1.25, 1, .60, 2.50, et cetera...");
            try
            {
                currentLemonadePrice = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                chargePerGlass(player);
            }
        }

        public void sales()
        {
            todaysSales = (currentRecipeSales + todaysSales);
            double todaysProfit = (todaysSales - suppliesCost);
            double todaysLoss = (suppliesCost - todaysSales);
            weekToDateProfit = (todaysProfit + weekToDateProfit);
            weekToDateSales = (todaysSales + weekToDateSales);
            currentRecipeSales = (currentLemonadePrice * currentRecipeSales);
            {

                newCurrentBalance = ((todaysSales - suppliesCost) + newCurrentBalance);

                currentRecipeSales = ((currentLemonadePrice) * (currentRecipesSold));
                todaysSales = (currentRecipeSales + todaysSales);
                currentRecipeSales = 0;

                weekToDateSales = (todaysSales + weekToDateSales);

                if (todaysSales > suppliesCost)
                {
                    todaysProfit = (todaysSales - suppliesCost);
                    Console.WriteLine("You made " + todaysProfit + " dollars in profit today. You now have " + newCurrentBalance + "dollars.");
                }
                else if (todaysSales < suppliesCost)
                {
                    todaysLoss = (suppliesCost - todaysSales);
                    Console.WriteLine("You lost " + todaysLoss + "dollars today.");
                }
                else
                {
                    Console.WriteLine("You broke even today- no profits and no losses.");
                }

            }
        }
    }
}

