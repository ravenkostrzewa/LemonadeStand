using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
       public Inventory ofInventory = new Inventory();
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
        public int glasses;
        public double lemons;
        public double sugar;
        public double ice;
        public double useLemons;
        public double useSugar;
        public double useIce;

        public void addLemons()
        {
            if (glasses >= 1 && lemons > 0 && sugar > 0 && ice == 0)
            {
                Console.WriteLine("Let's make lemonade! You have " + ofInventory.glass.Count + " glasses, " + ofInventory.lemons.Count + " lemons, " + ofInventory.sugar.Count + " sugar packets, " + " and " + ofInventory.ice.Count + " ice cubes. " + name + ", how many lemons would you like to use?");
                try
                {
                    useLemons = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(name + ", your entry is invalid. Your answer should consist of numbers and a decimal point with up to two decimal places if necessary. Do not use letters or symbols.");
                    addLemons();
                }
            }
            else if (glasses < 1 || lemons == 0 || sugar == 0 || ice == 0)
            {
                Console.WriteLine("You don't have the supplies necessary to be open for business! Your Glass Supply: " + ofInventory.glass.Count + "Your Lemon Supply: " + ofInventory.lemons.Count + "Your Sugar Packet Supply: " + ofInventory.sugar.Count + "Your Ice Cube Supply: " + ofInventory.ice.Count);
                sales();
            }
            }



        public void addSugar()
        {
            Console.WriteLine("Let's make lemonade! You have " + ofInventory.glass.Count + " glasses, " + ofInventory.lemons.Count + " lemons, " + ofInventory.sugar.Count + " sugar packets, " + " and " + ofInventory.ice.Count + " ice cubes. " + name + ", how many sugar packets would you like to use?");
            try
            {
                useSugar = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(name + ", your entry is invalid. Your answer should consist of numbers and a decimal point with up to two decimal places if necessary. Do not use letters or symbols.");
                addSugar();
            }
            if (sugar <= useSugar)
            {
                Console.WriteLine("You don't have enough sugar packets for that recipe! Your Sugar Packet Supply: " + ofInventory.sugar.Count);
                addSugar();
            }
            else
            {
            
            }
        }

        public void addIce()
        {
            Console.WriteLine("Let's make lemonade! You have " + ofInventory.glass.Count + " glasses, " + ofInventory.lemons.Count + " lemons, " + ofInventory.sugar.Count + " sugar packets, " + " and " + ofInventory.ice.Count + " ice cubes. " + name + ", how many ice cubes would you like to use?");
            try
            {
                useIce = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(name + ", your entry is invalid. Your answer should consist of numbers and a decimal point with up to two decimal places if necessary. Do not use letters or symbols.");
                addIce();
            }
            if (ice <= useIce)
            {
                Console.WriteLine("You don't have enough ice cubes for that recipe! Your Ice Cube Supply: " + ofInventory.ice.Count);
                addIce();
            }
            else
            {

            }
      }
      public void costOfLemonade()
      {
            Console.WriteLine(name + ", in dollars, how much would you like to charge per glass? ie. 1.25, 1, .60, 2.50, et cetera...");
            try
            {
                currentLemonadePrice = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(name + ", your entry is invalid. Your answer should consist of numbers and a decimal point with up to two decimal places if necessary. Do not use letters or symbols.");
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
                    Console.WriteLine("You made a profit of $" + todaysProfit + " today. You now have a total of $" + newCurrentBalance + ".");
                }
                else if (todaysSales < suppliesCost)
                {
                    todaysLoss = (suppliesCost - todaysSales);
                    Console.WriteLine("You lost $" + todaysLoss + " today. You now have a total of $" + newCurrentBalance + ".");
                }
                else
                {
                    Console.WriteLine("You broke even today with no profits and no losses. You now have a total of $" + newCurrentBalance + ".");
                }

            }
        }
    }
}

