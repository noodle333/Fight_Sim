using System;
using System.Collections.Generic;

namespace Fight_Sim
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter player = new Fighter("Player");
            Fighter bot = new Fighter("Enemy");
            
            Console.WriteLine($"Welcome {player.name} and {bot.name}.");
            Console.WriteLine($"{player.name}, your opponent {bot.name} has chosen the {bot.weapon.weaponName}.");
            player.weapon.PlayerWeapon();

            player.weapon.StrongOrWeakAgainst(bot.weapon);
            bot.weapon.StrongOrWeakAgainst(player.weapon);
            Console.ReadLine();

            // player.ChooseWeapon(Console.ReadLine());
            
            while (player.isAlive && bot.isAlive)
            {
                
            }
            //Each tick, attack each other w weapon
            //Each figther attack method that has the opponent as a target
            //When game loop ends, show result
        }
    }
}
