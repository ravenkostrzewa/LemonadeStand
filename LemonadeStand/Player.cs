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

        //int currentLemonadePrice;
        public double currentRecipeSales;
        public double currentRecipesSold;
        public double lemonadeMix;
        public double weekToDateProfit;
        //int suppliesCost;
        public double todaysSales;
        public double weekToDateSales;
        //int newCurrentBalance;
        public int lemons;
        public int sugar;
        public int ice;

        //  Inventory lists
        //List<Lemon> lemons = new List<Lemon>();
        //List<Sugar> sugar = new List<Sugar>();
        //List<Ice> ice = new List<Ice>();
        //List<Glass> glass = new List<Glass>();


        //money is in dollars 0.00



        //Console.WriteLine("Only enter integars and a decimal point, no letters or symbols.");
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
        }public virtual void completeTransaction()
        {
            newCurrentBalance = (newCurrentBalance - suppliesCost);
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
                Console.WriteLine("How much would you like to charge per glass? Eg. 1 or .50 or 2.25");
                try
                {
                    currentLemonadePrice = Int32.Parse(Console.ReadLine());
                }
                catch { }
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

