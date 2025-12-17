using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal class Armor : Item, IEquipable
    {
        public Armor(string name, string description) : base(name, description)
        {
        }
        public object Name { get; protected set; }
        public void Equip(Character user)
        {
            user.EquipArmor(this as Armor);
        }
    }
}
