using System;

namespace RockPaperScissors
{
    public class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber) : base(name, strength, intelligence, magicalEnergy)
        {
            SpellNumber = spellNumber;
        }

        public override void Play()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("This is Wizard:  " + Name + " " + Strength + " " + Intelligence);
            Console.WriteLine($"\nThis is Wizard: {Name}, with a Strngth of: {Strength}, an Intelligence " +
                $"of: {Intelligence}, an SpellNumber of: {SpellNumber}, with magical energy of: {MagicalEnergy} ");
        }
    }
}
