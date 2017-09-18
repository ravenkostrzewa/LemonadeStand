using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public double currentLemonadePrice;
        public double currentRecipeSales;
        public int currentRecipesSold;
        public int lemonadeMix;
        double weekToDateProfit;
        double suppliesCost;
        double todaysSales;
        double weekToDateSales;
        double newCurrentBalance;
        public int glasses;
        public int lemons;
        public int sugar;
        public int ice;
        public double dollars = 30;
        public double lemonCost = .70;
        public double totalLemonCost;
        public double sugarPacketCost = .05;
        public double totalSugarPacketCost;
        public double iceCost = .05;
        public double totalIceCost;
        public double glassCost = .10;
        public double totalGlassCost;
        public Player player = new Player(); 


        ///money is in dollars

        public virtual void buyLemons(Player player)
        {
            int number = 0;
            Console.WriteLine(player.name + ", how many lemons would you like to buy?");
            double totalLemonCost = 0.0;

            try
            {
                number = Int32.Parse(Console.ReadLine());
                totalLemonCost = ((lemonCost) * (number));
            }
            catch
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                buyLemons(player);
            }
            if (dollars >= totalLemonCost)
            {
                dollars = (dollars - totalLemonCost);
                lemons = number + lemons;
                newCurrentBalance = dollars;
                Console.WriteLine("You have purchased " + number + " lemons. You have " + lemons + " lemons in your inventory. You now have $" + newCurrentBalance + ".");
            }
            else if (dollars <= .70)
            {
                buySugar(player);
            }
            else
            {
                newCurrentBalance = dollars;
                Console.WriteLine("That's out of your price range! You can only spend the money you have. You have $" + newCurrentBalance + ". Let's try going shopping for lemons again so you can budget accordingly.");
                buyLemons(player);
            }
        }

        public virtual void buySugar(Player player)
        {
            int number = 0;
            Console.WriteLine(player.name + ", how many sugar packets would you like to buy?");
            double totalSugarCost = 0;

            try
            {
                number = Int32.Parse(Console.ReadLine());
                totalSugarCost = ((sugarPacketCost) * (number));
            }
            catch
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                buySugar(player);
            }
            if (dollars >= totalSugarCost)
            {
                dollars = (dollars - totalSugarCost);
                sugar = number + sugar;
                newCurrentBalance = dollars;
                Console.WriteLine("You have purchased " + number + " sugar packets. You have " + sugar + " sugar packets in your inventory. You now have $" + newCurrentBalance + ".");
            }
            else if (dollars <= .05)
            {
                player.makeLemonade(player);
            }
            else
            {
                newCurrentBalance = dollars;
                Console.WriteLine("That's out of your price range! You can only spend the money you have. You have $" + newCurrentBalance + ". Let's try going shopping for sugar packets again so you can budget accordingly.");
                buySugar(player);
            }
        }

        public virtual void buyIce(Player player)
        {
            int number = 0;
            Console.WriteLine(player.name + ", how many ice cubes would you like to buy?");
            double totalIceCost = 0.0;

            try
            {
                number = Int32.Parse(Console.ReadLine());
                totalIceCost = ((iceCost) * (number));
            }
            catch
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                buyIce(player);
            }
            if (dollars >= totalIceCost)
            {
                dollars = (dollars - totalIceCost);
                ice = number + ice;
                newCurrentBalance = dollars;
                Console.WriteLine("You have purchased " + number + " ice cubes. You have " + ice + " ice cubes in your inventory. You now have $" + newCurrentBalance + ".");
            }
            else if (dollars <= .05)
            {
                player.makeLemonade(player);
            }
            else
            {
                newCurrentBalance = dollars;
                Console.WriteLine("That's out of your price range! You can only spend the money you have. You have $" + newCurrentBalance + ". Let's try going shopping for ice cubes again so you can budget accordingly.");
                buyIce(player);
            }
        }

        public virtual void buyGlass(Player player)
        {
            int number = 0;
            Console.WriteLine(player.name + ", how many glasses would you like to buy?");
            double totalGlassCost = 0.0;

            try
            {
                number = Int32.Parse(Console.ReadLine());
                totalGlassCost = ((glassCost) * (number));
            }
            catch
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                buyGlass(player);
            }
            if (dollars >= totalGlassCost)
            {
                dollars = (dollars - totalGlassCost);
                glasses = number + glasses;
                newCurrentBalance = dollars;
                Console.WriteLine("You have purchased " + number + " glasses. You have " + glasses + " glasses in your inventory. You now have $" + newCurrentBalance + ".");
            }
            else if (dollars <= .10)
            {
                player.makeLemonade(player);
            }
            else
            {
                newCurrentBalance = dollars;
                Console.WriteLine("That's out of your price range! You can only spend the money you have. You have $" + newCurrentBalance + ". Let's try going shopping for glasses again so you can budget accordingly.");
                buyGlass(player);
            }
        }
    }
}



