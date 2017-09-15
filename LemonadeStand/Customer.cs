using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customers
    {
        public double glassesBought;
        public bool humid;
        public bool percipitation;
        public double dollars;
        public double pricePerGlass;
        public double lemonsPerGlass;
        public double sugarPerGlass;
        public double icePerGlass;
        int dailyPotentialCustomers;
        public bool buysLemonade;
        public bool interestedInLemonade;
        public bool buysAnotherGlass;
        //public double dailyPotentialCustomers;
        Random rnd = new Random();
    }


    List<Customers> customer = new List<Customers>();

    public void MakeCustomers(Customers)
    {
        for (int i = 0; i < 100; i++)
        {
            customer.Add(new Customers());
        }
    }


}
}
public void BuyLemonade(weather)
{
    if (weather.temperature <= 50)
    {
        if (rnd.Next(1, 100) <= 50)
        {
            interestedInLemonade = true;
        }
        else
        {
            interestedInLemonade = false;
        }
    else if (weather.temperature >= 51 && weather.temperature <= 60)
        {
            if (rnd.Next(1, 100) <= 70)
            {
                interestedInLemonade = true;
            }
            else
            {
                interestedInLemonade = false;
            }
        }
        else if (weather.temperature >= 61 && weather.temperature <= 70)
        {
            if (rnd.Next(1, 100) <= 70)
            {
                interestedInLemonade = true;
            }
        }
        else if (weather.temperature >= 71 && weather.temperature <= 80)
        {
            if (rnd.Next(1, 100) <= 80)
            {
                interestedInLemonade = true;
            }
        }
        else if (weather.temperature >= 81)
        {
            if (rnd.Next(1, 100) <= 50)
            {
                interestedInLemonade = true;
            }
        }
        else
        {
            interestedInLemonade = false;
        }
    }

public void lemonadeSales(interestedInLemonade);
            if (interestedInLemonade = true && lemonsPerGlass >= 2 && lemonsPerGlass <= 5 && pricePerGlass <= 1.75)
            {
                if (rnd.Next(1, 100) <= 80)
                {
                    buysLemonade = true;
                }
                    if (rnd.Next(1, 4) == 4)
                    {
                        buysAnotherGlass = true;
                    }
                    else if (rnd.Next(1, 4) != 4)
                    {
                        buysAnotherGlass = false;
                    }
                else if (rnd.Next(1, 100) > 80)
                {
                    buysLemonade = false;
                }
            else if (interestedInLemonade = true && sugarPerGlass >= 1 && sugarPerGlass <= 5 && pricePerGlass <= 1.75 && weather.humidity == yes)
            {
                if (rnd.Next(1, 100) <= 85)
                {
                    buysLemonade = true;
                }
                    if (rnd.Next(1, 4) == 4)
                    {
                        buysAnotherGlass = true;
                    }
                    else if (rnd.Next(1, 4) != 4)
                    {
                        buysAnotherGlass = false;
                    }
                    else if (rnd.Next(1, 100) > 80)
                    {
                        buysLemonade = false;
                    }
                else if (interestedInLemonade = true && icePerGlass >= 6 && icePerGlass <= 11 && pricePerGlass <= 1.75)
                {
                    if (rnd.Next(1, 100) <= 90)
                    {
                        buysLemonade = true;
                    }
                    if (rnd.Next(1, 4) == 4)
                    {
                        buysAnotherGlass = true;
                    }
                    else if (rnd.Next(1, 4) != 4)
                    {
                        buysAnotherGlass = false;
                    }
                else if (rnd.Next(1, 100) > 80)
                {
                    buysLemonade = false;
                }
               else if (interestedInLemonade = true && icePerGlass >= 6 && icePerGlass <= 11 && weather.temperature >= 81)
                {
                    if (rnd.Next(1, 100) <= 90)
                    {
                        buysLemonade = true;
                    }
                        if (rnd.Next(1, 4) == 4)
                        {
                            buysAnotherGlass = true;
                        }
                        else if (rnd.Next(1, 4) != 4)
                        {
                            buysAnotherGlass = false;
                        }
                    else if (rnd.Next(1, 100) > 80)
                    {
                        buysLemonade = false;
                    }
                    else if (interestedInLemonade == true && pricePerGlass <= 1.00)
                    {
                        if (rnd.Next(1, 100) <= 90)
                        {
                            buysLemonade = true;
                        }
                            if (rnd.Next(1, 4) == 4)
                            {
                                buysAnotherGlass = true;
                            }
                            else if (rnd.Next(1, 4) != 4)
                            {
                                buysAnotherGlass = false;
                            }
                        else if (rnd.Next(1, 100) > 80)
                        {
                            buysLemonade = false;
                        }
                   else if (rnd.Next(1, 100) <= 10)
                    {
                        buysLemonade = true;
                    }
                    else
                    {
                        buysLemonade = false;
                    }

                }
        }
    }
}