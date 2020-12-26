using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HuntingApp
{
    class GameEngine
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public void AnimalAttack()
        {

        }
        public Animal HuntAnimal()
        {

            int r = GetRandomNum();

            //create a fish object the return;
            Animal animal = new Animal();

            if (r == 1) // bass
            {
                animal.AnimalType = "cyote";
                animal.Points = 10;
                animal.DamageDealt = 20;
            }
            else if (r == 2)
            {
                animal.AnimalType = "snake";
                animal.Points = 2;
                animal.DamageDealt = 50;
            }
            else if (r == 3)
            {
                animal.AnimalType = "deer";
                animal.Points = 20;
                animal.DamageDealt = 2;
            }
            else if (r == 4)
            {
                animal.AnimalType = "wolf";
                animal.Points = 5;
                animal.DamageDealt = 22;
            }
            else if (r == 5)
            {
                animal.AnimalType = "bear";
                animal.Points = 30;
                animal.DamageDealt = 70;
            }
            else
            {
                animal.AnimalType = "No animal try again ";
                animal.Points = 0;
                animal.DamageDealt = 0;
            }


            return animal;
        }
        public int GetRandomNum()
        {

            Random num = new Random();
            //Thread.Sleep(1000);
            lock (syncLock)
            { // synchronize
                return random.Next(1, 8);
            }
            //int computerchoice = num.Next(1, 8);
            //return computerchoice;

        }
    }
}
