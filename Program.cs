using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Character character = new Character("Гриха");
            Inventory inventory = new Inventory(10);
            inventory.Add(new Armor("Броня", "она защищает тебя от урона противника!"));
            inventory.Add(new Weapon("Оружие", "оно наносит урон твоему противнику!"));
            inventory.Add(new HealthPotion("Зелье здоровья", "оно лечит тебя на некоторое кол-во здоровья!"));
            inventory.Add(new Food("Еда", "она восстанавливает некоторое кол-во энергии!"));
            inventory.Add(new Gem("Драгоценный камень", "он очень ценный и его можно будет продать за 500 gold!"));
            inventory.Add(new OldBoot("Старый ботинок", "да он никому не нужен, выкинь его!"));
            inventory.Add(new MagicRing("Магичекское кольцо", "оно обладает некой МАГИЕЙ!"));
            inventory.Add(new Scroll("Свиток", "он дает тебе огромный прирост энергии!"));
            bool truefalse = true;
            while (truefalse)
            {
                //Console.Clear();
                character.ShowInfo();
                inventory.ShowInventory();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 — Использовать предмет");
                Console.WriteLine("2 — Экипировать предмет");
                Console.WriteLine("3 — Продать предмет");
                Console.WriteLine("4 — Выбросить предмет");
                Console.WriteLine("5 - Добавить предмет");
                Console.WriteLine("0 — Выход");
                int num = IntInput();
                if (num == 0) { Console.WriteLine("Сеанс окончен!"); truefalse = false; continue; }
                else if (num == 1)
                {
                    Console.WriteLine("Выберите индекс предмета:");
                    int index = IntInput();
                    Item item = inventory.GetItem(index);
                    if (item == null)
                    {
                        Console.WriteLine("Предмет не найден!");
                        Console.ReadKey();
                        continue;
                    }
                    if (item is IUsable iusable)
                    {
                        iusable.Use(character);
                        
                    }
                    else { Console.WriteLine("Этот предмет нельзя использовать"); }
                    if (item is IStackable stackable && stackable.Count == 0)
                    {
                        inventory.RemoveAt(index);
                    }
                }
                else if (num == 2)
                {
                    Console.WriteLine("Выберите индекс предмета:");
                    int index = IntInput();
                    Item item = inventory.GetItem(index);
                    if (item == null)
                    {
                        Console.WriteLine("Предмет не найден!");
                        Console.ReadKey();
                        continue;
                    }
                    if (item is IEquipable iequipable)
                    {
                        iequipable.Equip(character);
                    }
                    else { Console.WriteLine("Этот предмет нельзя экипировать"); }
                }
                else if (num == 3)
                {
                    Console.WriteLine("Выберите индекс предмета:");
                    int index = IntInput();
                    Item item = inventory.GetItem(index);
                    if (item == null)
                    {
                        Console.WriteLine("Предмет не найден!");
                        Console.ReadKey();
                        continue;
                    }
                    if (item is ISellable isellable)
                    {
                        isellable.Sell(character);
                        
                    }
                    else { Console.WriteLine("Этот предмет нельзя продать"); }
                    if (item is IStackable stackable && stackable.Count == 0)
                    {
                        inventory.RemoveAt(index);
                    }
                }
                else if (num == 4)
                {
                    Console.WriteLine("Выберите индекс предмета:");
                    int index = IntInput();
                    Item item = inventory.GetItem(index);
                    if (item == null)
                    {
                        Console.WriteLine("Предмет не найден!");
                        Console.ReadKey();
                        continue;
                    }
                    if (item is IDiscardable idiscardable)
                    {
                        idiscardable.Discard();
                        
                    }
                    else { Console.WriteLine("Этот предмет нельзя выбросить"); }
                    if (item is IStackable stackable && stackable.Count == 0)
                    {
                        inventory.RemoveAt(index);
                    }
                }
                else if (num == 5)
                {
                    Console.WriteLine("Выберите индекс предмета, который хотите добавить:");
                    int index = IntInput();
                        Item item = inventory.GetItem(index);
                        if (item is IStackable istackable)
                        {
                            if (item != null) { istackable.AddOne(); }
                            else { Console.WriteLine(""); }
                        }
                        else { Console.WriteLine("Предметы не стакуются!"); }
                }
                else { Console.WriteLine("Ввод неправилен, повторите еще раз!"); continue; }
                }
            }
        
        static int IntInput()
        {
            while (true)
            {
                string num = Console.ReadLine();
                if (int.TryParse(num, out int tempnum))
                {
                    return tempnum;
                }
                else
                {
                    Console.WriteLine("Неправильный ввод, повторите еще раз!");
                }
            }
        }
    }

}
