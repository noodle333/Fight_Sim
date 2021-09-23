using System;
using System.Collections.Generic;

namespace Fight_Sim
{
    public class Item
    {
        public string itemName;

        //HEALING HAT (1hp per round), "Invisibility glasses(look really cool, and also dodges attack randomly), TAUNT MOUTHPIECE (GRANTS A CHANCE OF OPPONENT LOSING MATCH DUE TO CRYING)
        public List<string> specialItems = new List<string>{"Healing Hat", "Invisibility Glasses", "Taunt Mouthpiece"};

        public void EnemyItem()
        {
            Random gen = new Random();
            int randItem = gen.Next(specialItems.Count);
            itemName = specialItems[randItem];
        }

        public void PlayerItem()
        {
            Console.WriteLine("What item would you like? Choose wisely.");
            Console.WriteLine("1: Healing Hat - Heals 1 point per round");
            Console.WriteLine("2: Invisibility Glasses - They look really cool, and you sometimes dodge attacks");
            Console.WriteLine("3: Taunt Mouthpiece - Insult your opponent every round, small chance they end up crying and miss out on 5 rounds");
            int pi = 0;

            while (pi < 1 || pi > 3)
            {
                Console.WriteLine("Write the number in front of the item you want.");
                Int32.TryParse(Console.ReadLine(), out pi);
            }
            itemName = specialItems[pi-1];
            Console.WriteLine($"You chose the {itemName}");
        }

        public void ItemEffect()
        {
            if (itemName == specialItems[0])
            {

            }
            else if (itemName == specialItems[1])
            {

            }
            else if (itemName == specialItems[2])
            {
                
            }
        }
    }
}