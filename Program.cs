using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] gameCharacters = new GameCharacter[5];
            gameCharacters[0] = new Warrior("\nPanda", 7, 9,"Bambu");
            gameCharacters[1] = new Warrior("\nShrek", 9, 8, "Burro");
            gameCharacters[2] = new Wizard("\nHoudini",6, 9, 200, 99);
            gameCharacters[3] = new Wizard("\nLavand", 5, 9, 150, 89);
            gameCharacters[4] = new Wizard("\nEric Chine", 6, 10, 125, 100);

            for (int i = 0; i < gameCharacters.Length; i++)
            {
                //Console.WriteLine($"Rank {i+1}");
                gameCharacters[i].Play();
                Console.WriteLine($"Rank {i + 1}");
            }

            Console.ReadKey();
        }


       public static string Message()
        {
            return "Welcome to BONUS-13 Game Character using C#! ";
        }

    }



}
