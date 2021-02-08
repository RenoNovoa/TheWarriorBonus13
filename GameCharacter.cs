using System;

namespace RockPaperScissors
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public GameCharacter()
        {
           
        }

        public GameCharacter(string name, int strength, int intelligence) //Overloaded Constructor
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public virtual void Play()//Here we define the virtual Play Method to override it and the child 
        {
            Console.Write(Name + " " + Strength + " " + Intelligence ); 
        }
    }
}
