using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemon> lemons;
        public List<Sugar> sugar;
       public  List<Ice> ice;
       public  List<Glass> glass;

        public Inventory()
        {
             lemons = new List<Lemon>();
             sugar = new List<Sugar>();
             ice = new List<Ice>();
            glass = new List<Glass>();
        }

        public void getIngredients()
        {
            for (int i = 0; i <= 10000; i++)
            {
                lemons.Add(new Lemon());
            }

            for (int i = 0; i <= 10000; i++)
            {
                sugar.Add(new Sugar());
            }

            for (int i = 0; i <= 10000; i++)
            {
                ice.Add(new Ice());
            }
            for (int i = 0; i <= 10000; i++)
            {
                glass.Add(new Glass());
            }
        }
    }
}
