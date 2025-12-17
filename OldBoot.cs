using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal class OldBoot : Item, IDiscardable
    {
        public OldBoot(string name, string description) : base(name, description)
        {
        }

        public void Discard()
        {
            Console.WriteLine($"Вы выкинули {name}");
        }
    }
}
