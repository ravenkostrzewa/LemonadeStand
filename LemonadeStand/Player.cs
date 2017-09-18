using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        Inventory ofInventory = new Inventory();

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

        public void makeLemonade(Player player)
        {
            if (glasses < 1 || lemons == 0 || sugar == 0 || ice == 0)
            {
                Console.WriteLine("You don't have the supplies necessary to be open for business! Your Glass Supply: " + glasses + "Your Lemon Supply: " + lemons + "Your Sugar Packet Supply: " + sugar + "Your Ice Cube Supply: " + ice);
                //end day
            }
            else
            {
                Console.WriteLine("Let's make lemonade! You have " + glasses + " glasses, " + lemons + " lemons, " + sugar + " sugar packets, " + " and " + ice + " ice cubes. " + player.name + ", how many lemons would you like to use?");
                try
                {
                    useLemons = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point with up to two decimal places if necessary. Do not use letters or symbols.");
                }
                if (lemons <= useLemons)
                {
                    Console.WriteLine("You don't have enough lemons for that recipe! Your Lemon Supply: " + lemons);
                    //loop back to Console.WriteLine(how many lemons?)
                }
                else
                {
                    Console.WriteLine("Let's make lemonade! You have " + glasses + " glasses, " + lemons + " lemons, " + sugar + " sugar packets, " + " and " + ice + " ice cubes. " + player.name + ", how many sugar packets would you like to use?");
                    try
                    {
                        useSugar = Int32.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point with up to two decimal places if necessary. Do not use letters or symbols.");
                    }
                    if (sugar <= useSugar)
                    {
                        Console.WriteLine("You don't have enough sugar packets for that recipe! Your Sugar Packet Supply: " + sugar);
                        //loop back to Console.WriteLine(how much sugar?)
                    }
                    else
                    {
                        Console.WriteLine("Let's make lemonade! You have " + glasses + " glasses, " + lemons + " lemons, " + sugar + " sugar packets, " + " and " + ice + " ice cubes. " + player.name + ", how many ice cubes would you like to use?");
                        try
                        {
                            useIce = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point with up to two decimal places if necessary. Do not use letters or symbols.");
                        }
                        if (ice <= useIce)
                        {
                            Console.WriteLine("You don't have enough ice cubes for that recipe! Your Ice Cube Supply: " + ice);
                        }
                        //loop back to Console.WriteLine(how much ice?)
                        else
                        {
                            Console.WriteLine(player.name + ", in dollars, how much would you like to charge per glass? ie. 1.25, 1, .60, 2.50, et cetera...");
                            try
                            {
                                currentLemonadePrice = Int32.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(player.name + ", your entry is invalid. Your answer should consist of numbers and a decimal point with up to two decimal places if necessary. Do not use letters or symbols.");
                            }
                        }
                    }
                }
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

