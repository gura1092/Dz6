using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal class Ring : Item, IEquipable
    {
        public Ring(string name, string description) : base(name, description)
        {
        }
        public object Name { get; protected set; }

        public void Equip(Character user)
        {
            user.EquipRing(this as Ring);
        }
    }
}
