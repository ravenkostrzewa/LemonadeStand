using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        double currentLemonadePrice;
        double currentRecipeSales;
        int currentRecipesSold;
        int lemonadeMix;
        double weekToDateProfit;
        double suppliesCost;
        double todaysSales;
        double weekToDateSales;
        double newCurrentBalance;
        int lemons;
        int sugar;
        int ice;
        public double dollars;
        public double lemonCost = .30;
        public double totalLemonCost;
        public double sugarPacketCost = .05;
        public double totalSugarPacketCost;
        public double iceCost = .50;
        public double totalIceCost;
        public double glassCost = .10;
        public double totalGlassCost;


        ///money is in dollar

        public virtual void shoppingList()
        {
            int number = 0;
            Console.WriteLine("How many lemons would you like to buy?");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                double totalLemonCost = (lemonCost) * (number);
            }
            catch
            {
                Console.WriteLine("Only enter integars, no letters or symbols.");
                shoppingList();
            }
            Console.WriteLine("How many packets of sugar would you like to buy?");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                double totalSugarPacketsCost = (sugarPacketCost) * (number);
            }
            catch
            {
                Console.WriteLine("How many ice cubes would you like to buy?");
                shoppingList();
            }
            try
            {
                number = Int32.Parse(Console.ReadLine());
                double totalIceCost = (iceCost) * (number);
            }
            catch
            {
                Console.WriteLine("How many glasses would you like to buy?");
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    double totalGlassesCost = (glassCost) * (number);
                }
                catch
                {

                    suppliesCost = (lemonCost + sugarPacketCost + iceCost + glassCost);
                }
            }
        }
        public void sellLemonade()
        {
            Console.WriteLine("How many lemons would you like to use?");
            try
            {
                lemons = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("How many sugar packets would you like to use?");
                try
                {
                    sugar = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("How many ice cubes would you like to use?");
                    try
                    {
                        ice = Int32.Parse(Console.ReadLine());
                    }
                    catch { }
                }
                Console.WriteLine("In dollars, how much would you like to charge per glass?");
                try
                {
                    currentLemonadePrice = Int32.Parse(Console.ReadLine());
                }
                catch { }
            }
        }
    }
}