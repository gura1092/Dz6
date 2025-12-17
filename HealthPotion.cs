using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal class HealthPotion : Item, IUsable, IStackable
    {
        public HealthPotion(string name, string description) : base(name, description)
        {

        }

        public int Count { get; private set; } = 2;

        public void AddOne()
        {
            Count++;
        }

        public void RemoveOne()
        {
            if (Count > 0) { Count--; }
        }

        public void Use(Character user)
        {
            user.AddHealth(10);
            RemoveOne();
        }
        public override void ShowInfo()
        {
            if (Count > 1) { Console.WriteLine($"{name} x{Count} - {description}"); }
            else
            {
                Console.WriteLine($"{name} - {description}");
            }
        }
    }
}
