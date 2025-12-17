using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal class Weapon : Item, IEquipable
    {
        public Weapon(string name, string description) : base(name, description) { }

        public object Name { get; protected set; }

        public void Equip(Character user)
        {
            user.EquipWeapon(this as Weapon);
        }
    }
}
