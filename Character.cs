using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УраааааДз
{
    internal class Character
    {
        private string name;
        private int health=100;
        private int maxhealth=100;
        private int energy= 100;
        private int maxenergy = 200;
        private int gold = 500;
        private Weapon weaponplayer;
        private Armor armorplayer;
        private Ring ringplayer;
        public Character(string name) 
        {
            this.name = name;
        }
        public void AddHealth(int value)
        {
            if (health >= maxhealth) { health = maxhealth; Console.WriteLine("Здоровье уже на максимуме!"); }
            if (health < maxhealth)
            {
                health += value;
                Console.Write($"Здоровья прибавилось на {value}");
                if (health >= maxhealth) { health = maxhealth; Console.WriteLine($", теперь у {name} {health}/{maxhealth} здоровья!"); }
                else { Console.WriteLine($", теперь у {name} {health}/{maxhealth} здоровья!"); }
            }
        }
        public void AddEnergy(int value)
        {
            if (energy >= maxenergy) { energy = maxenergy; Console.WriteLine("Энергия уже на максимуме!"); }
            if (energy < maxenergy)
            {
                energy += value;
                Console.Write($"Энергии прибавилось на {value}");
                if (energy >= maxenergy){ energy = maxenergy; Console.WriteLine($", теперь у {name} {energy}/{maxenergy} энергии!");}
                else { Console.WriteLine($", теперь у {name} {energy}/{maxenergy} энергии!"); }
            }
        }
        public void AddGold(int value)
        {
            gold += value;
            Console.Write($"Золота прибавилось на {value}, теперь у {name} {gold} золота!");
            if (gold < 0) {gold = 0; Console.WriteLine($", теперь у {name} {gold} золота!"); }
        }
        public void EquipWeapon(Weapon weapon)
        {
            if (weaponplayer != null)
            {
                Console.WriteLine($"Снимаем {weaponplayer.Name}!");
            }
            Console.WriteLine($"Вы экипировали оружие {weapon.Name}!");
            weaponplayer = weapon;
            
        }
        public void EquipArmor(Armor armor)
        {
            if (armorplayer != null)
            {
                Console.WriteLine($"Снимаем {armorplayer.Name}!");
            }
            Console.WriteLine($"Вы экипировали броню {armor.Name}!");
            armorplayer = armor;

        }
        public void EquipRing(Ring ring)
        {
            if (ringplayer != null)
            {
                Console.WriteLine($"Снимаем {ringplayer.Name}!");
            }
            Console.WriteLine($"Вы экипировали кольцо {ring.Name}!");
            ringplayer = ring;
        }
        public void UnequipWeapon() 
        {
            if (weaponplayer != null)
            {
                Console.WriteLine("Вы сняли свое оружие!");
                weaponplayer = null;
            }
        }
        public void UnequipArmor()
        {
            if (armorplayer != null)
            {
                Console.WriteLine("Вы выкинули броню!");
                armorplayer = null;
            }
        }
        public void UnequipRing()
        {
            if (ringplayer != null)
            {
                Console.WriteLine("Вы выкинули свое кольцо!");
                ringplayer = null;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{name} имеет {health}/{maxhealth} здоровья, {energy}/{maxenergy} энергии, {gold} золота");
            if (weaponplayer != null)
            { Console.WriteLine($"Имеется оружие {weaponplayer.Name}"); }
            else { Console.WriteLine("Оружия не имеется"); }
            if (armorplayer != null)
            { Console.WriteLine($"Надета броня {armorplayer.Name}"); }
            else { Console.WriteLine("Броня не надета"); }
            if (ringplayer != null)
            { Console.WriteLine($"Экипировано кольцо {ringplayer.Name}"); }
            else { Console.WriteLine("Кольцо не экипировано"); }
            }
    }
}
