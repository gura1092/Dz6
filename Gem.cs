using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal class Gem : Item, ISellable
    {
        public Gem(string name, string description) : base(name, description)
        {
        }

        public int Price => 500;

        public void Sell(Character user)
        {
            user.AddGold(Price);
        }
    }
}
