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

            Console.WriteLine("player1 username " + player1.Username);
            Console.WriteLine("player1 Score " + player1.Score);
            #endregion



            GameEngine game = new GameEngine();
            Animal animal1 = game.HuntAnimal();

            Console.WriteLine("animal 1 animalType " + animal1.AnimalType);
            Console.WriteLine("animal1 points " + animal1.Points);

            player1.Score = player1.Score + animal1.Points;
            Console.WriteLine("player1 Score " + player1.Score);


            Animal animal2 = game.HuntAnimal();

            Console.WriteLine("animal 2 animalType " + animal2.AnimalType);
            Console.WriteLine("animal 2 points " + animal2.Points);


            Animal animal3 = game.HuntAnimal();

            Console.WriteLine("animal 3 animalType " + animal3.AnimalType);
            Console.WriteLine("animal 3 points " + animal3.Points);

            player1.Score = player1.Score + animal2.Points + animal3.Points;
            Console.WriteLine("player1 Score " + player1.Score);
        }
    }
}
