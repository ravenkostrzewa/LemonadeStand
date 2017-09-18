using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        List<Lemon> lemon = new List<Lemon>();
        List<Sugar> sugar = new List<Sugar>();
        List<Ice> ice = new List<Ice>();
        List<Glass> glass = new List<Glass>();

        public virtual void getIngredients(players)
        {
            for (int i = 0; i < 1000000000; i++)
            {
                lemon.Add(new Lemon());
            }

            for (int i = 0; i < 1000000000; i++)
            {
                sugar.Add(new Sugar());
            }

            for (int i = 0; i < 1000000000; i++)
            {
                ice.Add(new Ice());
            }
            for (int i = 0; i < 1000000000; i++)
            {
                glass.Add(new Glass());
            }
        }


    }
}
