using System;

namespace RockPaperScissors
{
    public class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy) : base(name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            base.Play();
            Console.Write($" {MagicalEnergy}");
        }
    }
}
