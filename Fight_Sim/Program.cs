using System;
using System.Collections.Generic;

namespace Fight_Sim
{
    class Program
    {
        static void Main(string[] args)
        {
            //TO DO: HP CANT GO BELOW 0. FLOOR OR CLAMP? SPECIAL ITEMS TO CHOOSE FROM
            Fighter player = new Fighter("Player");
            Fighter bot = new Fighter("Enemy");
            
            Console.WriteLine($"Welcome {player.name} and {bot.name}.");
            Console.WriteLine($"{player.name}, your opponent {bot.name} has chosen the {bot.weapon.weaponName}.");
            player.weapon.PlayerWeapon();
            player.item.PlayerItem();

            player.weapon.StrongOrWeakAgainst(bot.weapon);
            bot.weapon.StrongOrWeakAgainst(player.weapon);

            //GAME LOOP
            while (player.GetAlive() && bot.GetAlive())
            {
                player.Attack(bot);
                bot.Attack(player);
                Console.WriteLine($"{player.name} has {player.hp} hp. DAMN");
                Console.WriteLine($"{bot.name} has {bot.hp} hp. DAMN");
                
                player.GetAlive();
                bot.GetAlive();
            }

            //CHECK WINNER
            if (player.hp > bot.hp)
            {
                Console.WriteLine($"{player.name} wins! What a fight!");                
            }
            else {
                Console.WriteLine($"{bot.name} wins! What a pathetic attempt!");
            }
            Console.ReadLine();
        }
    }
}
