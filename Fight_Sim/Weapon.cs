using System;
using System.Collections.Generic;

namespace Fight_Sim
{
    public class Weapon
    {
        public string weaponName;

        public int weaponDmg = 5;

        public List<string> weapons = new List<string>{"Bow", "Sword", "Axe"};

        public void Damage(Fighter target)
        {

        }

        public void EnemyWeapon()
        {
            //Random Enemy Weapon
            Random gen = new Random();
            int rWeapon = gen.Next(weapons.Count);
            weaponName = weapons[rWeapon];
        }

        public void PlayerWeapon()
        {
            Console.WriteLine("Which weapon do you want? Write one of the following numbers.");
            Console.WriteLine("1: Bow | 2: Sword | 3: Axe. Choose wisely.");
            int pw = 0;
            while (pw < 1 || pw > 3)
            {
                Int32.TryParse(Console.ReadLine(), out pw);
            }
            weaponName = weapons[pw-1];
            Console.WriteLine($"You have chosen the {weaponName}.");
        }

        public void StrongOrWeakAgainst(Weapon t)
        {
            //Strong against
            if (weaponName == "Bow" && t.weaponName == "Sword" || weaponName == "Sword" && t.weaponName == "Axe" || weaponName == "Axe" && t.weaponName == "Bow")
            {
                weaponDmg += 2;
            }
        }

        public void Choose(string input)
        {
            
        }
    }
}