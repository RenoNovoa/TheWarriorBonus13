using System;

namespace RockPaperScissors
{
    public class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior(string name, int strength, int intelligence, string weaponType)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            WeaponType = weaponType;

        }

        public override void Play()// Here we override the the play method from the base class
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("This is Warrior: " + Name + " " + Strength + " " + Intelligence);
            Console.WriteLine($"\nThis is warrior: {Name}, with a strenght of: {Strength} and Inteligence " +
                $"Of: {Intelligence}, and I Figth with {WeaponType} ");
        }     
    }
}
