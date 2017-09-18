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
        public int lemons;
        public int sugar;
        public int ice;
        public double dollars = 30;
        public double lemonCost = .30;
        public double totalLemonCost;
        public double sugarPacketCost = .05;
        public double totalSugarPacketCost;
        public double iceCost = .50;
        public double totalIceCost;
        public double glassCost = .10;
        public double totalGlassCost;


        ///money is in dollars

        public virtual void buyLemons(Player player)
        {
            int number = 0;
            Console.WriteLine(player.name + ", how many lemons would you like to buy?");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                double totalLemonCost = ((lemonCost) * (number));
                newCurrentBalance = (dollars - totalLemonCost);
                dollars = newCurrentBalance;
                Console.WriteLine("You now have $" + newCurrentBalance);
            }
            catch
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                buyLemons(player);
            }
        }

        public virtual void buySugar(Player player)
        {
            int number = 0;
            Console.WriteLine(player.name + ", how many packets of sugar would you like to buy?");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                double totalSugarPacketsCost = ((sugarPacketCost) * (number));
                newCurrentBalance = (dollars - totalSugarPacketsCost);
                dollars = newCurrentBalance;
                Console.WriteLine("You now have $" + newCurrentBalance);
            }
            catch
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                buySugar(player);
            }
        }

        public virtual void buyIce(Player player)
        {
            int number = 0;
            Console.WriteLine(player.name + ", how many ice cubes would you like to buy?");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                double totalIceCost = ((iceCost) * (number));
                newCurrentBalance = (dollars - totalIceCost);
                dollars = newCurrentBalance;
                Console.WriteLine("You now have $" + newCurrentBalance);
            }
            catch
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                buyIce(player);
            }
        }

        public virtual void buyGlasses(Player player)
        {
            int number = 0;
            Console.WriteLine(player.name + ", how many glasses would you like to buy?");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                double totalGlassesCost = ((glassCost) * (number));
                newCurrentBalance = (newCurrentBalance - totalGlassesCost);
                dollars = newCurrentBalance;
                Console.WriteLine("You now have $" + newCurrentBalance);
            }
            catch
            {
                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point if necessary, not letters or symbols.");
                buyGlasses(player);
            }
            suppliesCost = (lemonCost + sugarPacketCost + iceCost + glassCost);
        }

        public void completeTransaction(Player player)
        {
            newCurrentBalance = (dollars - suppliesCost);
            dollars = newCurrentBalance;
            Console.WriteLine("You have $" + newCurrentBalance + " remaining.");
        }
    }
}
