using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal class MagicRing : Item, IEquipable, ISellable
    {
        public MagicRing(string name, string description) : base(name, description)
        {
        }

        public int Price => 100;

        public void Equip(Character user)
        {
            
        }

        public void Sell(Character user)
        {
            user.AddGold(Price);
        }
    }
}
