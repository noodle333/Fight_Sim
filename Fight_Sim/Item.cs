using System;
using System.Collections.Generic;

namespace Fight_Sim
{
    public class Item
    {
        public string itemName;

        //HEALING HAT (1hp per round), "Invisibility glasses(look really cool, and also dodges attack randomly), TAUNT MOUTHPIECE (GRANTS A CHANCE OF OPPONENT LOSING MATCH DUE TO CRYING)
        public List<string> specialItems = new List<string>{"Healing Hat", "Invisibility Glasses", "Taunt Mouthpiece"};

        public List<string> tauntInsults = new List<string>{"Ain't no way your haircut that receeded at 20 bruh", "Ayo where'd you get those velcro ass shoes? Toys R Us?",
        "Pickle chin ass boy", "Pickle head looking mf", "Boy your girlfriend look like my mom", "Damn you bout as dumb as Karl Pilkington", "You losing cause you blind af boy you be like Stevie, what's his name",
        "DAMN BOY NO WONDER YOU AINT GOT NO WOMEN WALKING AROUND WITH THOSE BLAZERS", "OMM YOU THE UGLIEST MF IVE EVER SEEN SINCE I SAW MARK ZUCKERBERG FOR THE FIRST TIME", "BOY YOU LOOK LIKE A MIX BETWEEN A GECCO AND A SEAL",
        "DAMN YOU GOT THEM LIZARD EYES BOY"};

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
            Console.WriteLine("3: Taunt Mouthpiece - Insult your opponent every round, small chance they end up crying and abandon the match");
            int pi = 0;

            while (pi < 1 || pi > 3)
            {
                Console.WriteLine("Write the number in front of the item you want.");
                Int32.TryParse(Console.ReadLine(), out pi);
            }
            itemName = specialItems[pi-1];
            Console.WriteLine($"You chose the {itemName}");
        }

        public void ItemEffect(Fighter f, Fighter o)
        {
            Random gen = new Random();
            if (itemName == specialItems[0])
            {
                f.hp += 1;
                Console.WriteLine($"{f.name}'s Healing Hat gave them +1 hp!");
            }
            else if (itemName == specialItems[1])
            {   
                int rDodge = gen.Next(1, 4);
                if (rDodge == 3)
                {
                    //Fake dodge because I am very tired
                    f.hp += 5;
                    Console.WriteLine($"{f.name} dodged the attack!");       
                }
            }
            else if (itemName == specialItems[2])
            {
                int rLoss = gen.Next(1, 20);
                int rInsult = gen.Next(tauntInsults.Count);
                Console.WriteLine($"{f.name} says: {tauntInsults[rInsult]}");
                if (rLoss == 17)
                {
                    Console.WriteLine($"It's super effective! {o.name} starts crying and runs away!");
                    o.hp = 0;
                }
                else {
                    Console.WriteLine($"{o.name} doesn't seem bothered by the insult");
                }
            }
        }
    }
}