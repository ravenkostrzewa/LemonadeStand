﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public double glassesBought;
        public bool precipitation;
        public int temperature;
        public double dollars;
        public double pricePerGlass;
        public double lemonsPerGlass;
        public double sugarPerGlass;
        public double icePerGlass;
        int dailyPotentialCustomers;
        public bool buyLemonade;
        public bool interestedInLemonade;
        public bool buyAnotherGlass;
        public int potentialCustomers;
        Random rnd = new Random();



        List<Customer> customer = new List<Customer>();

        public void MakeCustomers()
        {
            for (int i = 0; i < 100; i++)
            {
                customer.Add(new Customer());
            }
        }



        public void BuyLemonade(Weather weather)
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

        public void lemonadeSales(bool interestedInLemonade) {
            if (interestedInLemonade = true && lemonsPerGlass >= 2 && lemonsPerGlass <= 5 && pricePerGlass <= 1.75)
            {
                if (rnd.Next(1, 100) <= 80)
                {
                    buyLemonade = true;
                }
                if (rnd.Next(1, 4) == 4)
                {
                    buyAnotherGlass = true;
                }
                else if (rnd.Next(1, 4) != 4)
                {
                    buyAnotherGlass = false;
                }
                else if (rnd.Next(1, 100) > 80)
                {
                    buyLemonade = false;
                }
                else if (interestedInLemonade = true && sugarPerGlass >= 1 && sugarPerGlass <= 5 && pricePerGlass <= 1.75 && precipitation == false)
                {
                    if (rnd.Next(1, 100) <= 85)
                    {
                        buyLemonade = true;
                    }
                    if (rnd.Next(1, 4) == 4)
                    {
                        buyAnotherGlass = true;
                    }
                    else if (rnd.Next(1, 4) != 4)
                    {
                        buyAnotherGlass = false;
                    }
                    else if (rnd.Next(1, 100) > 80)
                    {
                        buyLemonade = false;
                    }
                    else if (interestedInLemonade = true && icePerGlass >= 6 && icePerGlass <= 11 && pricePerGlass <= 1.75 && precipitation == false)
                    {
                        if (rnd.Next(1, 100) <= 90)
                        {
                            buyLemonade = true;
                        }
                        if (rnd.Next(1, 4) == 4)
                        {
                            buyAnotherGlass = true;
                        }
                        else if (rnd.Next(1, 4) != 4)
                        {
                            buyAnotherGlass = false;
                        }
                        else if (rnd.Next(1, 100) > 80)
                        {
                            buyLemonade = false;
                        }
                        else if (interestedInLemonade = true && icePerGlass >= 6 && icePerGlass <= 11 && temperature >= 81)
                        {
                            if (rnd.Next(1, 100) <= 90)
                            {
                                buyLemonade = true;
                            }
                            if (rnd.Next(1, 4) == 4)
                            {
                                buyAnotherGlass = true;
                            }
                            else if (rnd.Next(1, 4) != 4)
                            {
                                buyAnotherGlass = false;
                            }
                            else if (rnd.Next(1, 100) > 80)
                            {
                                buyLemonade = false;
                            }
                            else if (interestedInLemonade == true && pricePerGlass <= 1.00)
                            {
                                if (rnd.Next(1, 100) <= 90)
                                {
                                    buyLemonade = true;
                                }
                                if (rnd.Next(1, 4) == 4)
                                {
                                    buyAnotherGlass = true;
                                }
                                else if (rnd.Next(1, 4) != 4)
                                {
                                    buyAnotherGlass = false;
                                }
                                else if (rnd.Next(1, 100) > 80)
                                {
                                    buyLemonade = false;
                                }
                                else if (rnd.Next(1, 100) <= 10)
                                {
                                    buyLemonade = true;
                                }
                                else
                                {
                                    buyLemonade = false;
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}