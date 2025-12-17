using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal class Scroll : Item, IUsable, ISellable
    {
        public Scroll(string name, string description) : base(name, description)
        {
        }

        public int Price => 200;

        public void Sell(Character user)
        {
            user.AddGold(Price);
        }

        public void Use(Character user)
        {
            user.AddEnergy(50);
        }
    }
}
