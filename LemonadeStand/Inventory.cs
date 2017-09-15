using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        // member variables
        List<Lemon> lemon = new List<Lemon>();
        List<Sugar> sugar = new List<Sugar>();
        List<Ice> ice = new List<Ice>();

        // member methods
        public void addLemon()
        {
            for (int i = 0; i < 1000; i++)
            {
                lemon.Add(new Lemon());
            }

            for (int i = 0; i < 1000; i++)
            {
                sugar.Add(new Sugar());
            }

            for (int i = 0; i < 1000; i++)
            {
                ice.Add(new Ice());
            }
        }


    }
}
