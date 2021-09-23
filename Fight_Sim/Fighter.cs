using System;
using System.Collections.Generic;

namespace Fight_Sim
{
    public class Fighter
    {
        //List of evil names to be given to opponent
        public List<string> enemyNames = new List<string>{"Skeletor", "Big Wheel", "Calender Man", "Batcow", "Alphabet Face", "BULLSHIT MAN (KARL PILKINGTON)"};

        public string name;

        public int hp = 100;

        public bool isAlive = true;

        public Weapon weapon = new Weapon();

        public Item item = new Item();

        public Fighter(string type)
        {
            if (type == "Enemy")
            {
                EnemyName();
                weapon.EnemyWeapon();
                item.EnemyItem();
            }
            else {
                PlayerName();
            }
        }

        public void Attack(Fighter target)
        {
            weapon.Damage(target);
        }

        public bool GetAlive()
        {
            return !(hp <= 0);
        }

        public void EnemyName()
        {
            //Randomly select a random enemy name.
            Random gen = new Random();
            int enemyName = gen.Next(enemyNames.Count);
            name = enemyNames[enemyName];
        }

        public void PlayerName()
        {
            Console.WriteLine("Player One. What's your name?");
            name = Console.ReadLine();
        }
    }
}