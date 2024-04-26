using System;
namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {   
        public int NumberOfWings { get; } = 4;
        public override string Sound()
        {
            return base.Sound() + "Bee Noise";
        }
    }
}