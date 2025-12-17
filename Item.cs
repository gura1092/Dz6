using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal abstract class Item 
    {
        protected string name;
        protected string description;
        public Item(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public object Name { get; internal set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{name} - {description}");
        }
    }
}
