using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Print welcome message and ask for username 

            //printing welcome mesage
            Console.WriteLine("**********************************************Welcome to the hunting game***************************");
            Console.WriteLine("By Matthew");
            //asking user what their name is
            Console.WriteLine("what is your username");

            //making a varible called userName and capturing the data from the user
            string userInput = Console.ReadLine();

            //printing the varible
            Console.WriteLine("hello " + userInput);

            #endregion
                       #region create player object and set score to 0
            //created a new instance and set the username 
            Player player1 = new Player();
            player1.Username = userInput;
            player1.Score = 0;
            player1.Health = 100;

            Console.WriteLine("player  username: " + player1.Username);
            
            Console.WriteLine("player Score: " + player1.Score);
            Console.WriteLine("player  health: " + player1.Health + "hp");
            #endregion


            
            GameEngine game = new GameEngine();

            for (int attempt = 1; attempt <= 10; attempt++)
            {
                Console.WriteLine("attempt = " + attempt);
                Animal animal1 = game.HuntAnimal();
                Console.WriteLine("animal " + attempt + " animalType " + animal1.AnimalType);
                Console.WriteLine("animal " + attempt  + animal1.Points);
                Console.WriteLine(" this animal has done : " + animal1.DamageDealt);

                player1.Score = player1.Score + animal1.Points;
                Console.WriteLine("       Score " + player1.Score);
                player1.Health = player1.Health - animal1.DamageDealt;
                Console.WriteLine("     your health right now is :" + player1.Health);

                if (player1.Health <= 0)
                {
                    Console.WriteLine("You are dead meat for the animals. You are very juicy too to them.");
                    break;
                }
                else
                {
                    Console.WriteLine("try again");
                }

            }
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("FINAL RESULT");
            Console.WriteLine("player1 Score: " + player1.Score);
            Console.WriteLine("player1 health: " + player1.Health);
            if (player1.Health <= 0)
            {
                Console.WriteLine("You are dead meat for the animals. You are very juicy too to them.");
            }
            else
            {
                Console.WriteLine("you have won because your health was over 0!!!!!");
            }

                //Animal animal1 = game.HuntAnimal();

                //Console.WriteLine("animal 1 animalType " + animal1.AnimalType);
                //Console.WriteLine("animal1 points " + animal1.Points);
                //Console.WriteLine(" this animal has done : " + animal1.DamageDealt);

                //player1.Score = player1.Score + animal1.Points;
                //Console.WriteLine("player1 Score " + player1.Score);
                //player1.Health = player1.Health - animal1.DamageDealt;
                //Console.WriteLine("your health right now is :" + player1.Health);


                //Animal animal2 = game.HuntAnimal();

                //Console.WriteLine("animal 2 animalType " + animal2.AnimalType);
                //Console.WriteLine("animal 2 points " + animal2.Points);
                //Console.WriteLine(" this animal has done : " + animal2.DamageDealt);

                //player1.Score = player1.Score + animal2.Points;
                //Console.WriteLine("player1 Score " + player1.Score);
                //player1.Health = player1.Health - animal2.DamageDealt;
                //Console.WriteLine("your health right now is :" + player1.Health);


                //Animal animal3 = game.HuntAnimal();

                //Console.WriteLine("animal 3 animalType " + animal3.AnimalType);
                //Console.WriteLine("animal 3 points " + animal3.Points);
                //Console.WriteLine(" this animal has done : " + animal3.DamageDealt);

                //player1.Score = player1.Score + animal3.Points + animal3.Points;
                //Console.WriteLine("player1 Score " + player1.Score);
                //player1.Health = player1.Health - animal3.DamageDealt;
                //Console.WriteLine("your health right now is :" + player1.Health);

                //if (player1.Health <= 0)
                //{
                //    Console.WriteLine("You are dead meat for the animals. You are very juicy too to them.");
                //}
                //else
                //{
                //    Console.WriteLine("you have won!!");
                //}

                //for (int attempt = 1; attempt <= 5; attempt++)
                //{
                //    Console.WriteLine("attempt = " + attempt);
                //}
            }
    }
}
