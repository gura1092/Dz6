using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal class Inventory
    {
        private List<Item> items;
        private int maxitems;
        public Inventory(int maxitems)
        {
            items = new List<Item>(maxitems);
            this.maxitems = maxitems;
        }
        public void Add(Item item)
        {
            if (items.Count >= maxitems)
            {
                Console.WriteLine("Инвентарь полон!");
                return;
            }
            items.Add(item);
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                if (items[index] is IStackable stackable && stackable.Count > 1)
                {
                    stackable.RemoveOne();
                    Console.WriteLine($"Удален один предмет '{items[index].Name}'. Осталось: {stackable.Count}");
                }
                else
                {
                    items.RemoveAt(index);
                    Console.WriteLine($"Предмет '{items[index].Name}' полностью удален из инвентаря");
                }
                return;
            }
            Console.WriteLine("Такого индекса не существует!");
        }
        public Item GetItem(int index) 
        {
            if (index >= 0 && index < maxitems)
            {
                return items[index];
            }
            Console.WriteLine("Такого индекса не существует!");
            return null;
        }
        public void ShowInventory()
        {
            Console.WriteLine("uwu ИНВЕНТАРЬ uwu");
            if (items.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст");
                return;
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.Write($"{i}. ");
                items[i].ShowInfo();
            }
        }
    }
}
