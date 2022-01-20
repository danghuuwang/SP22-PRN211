using System;

namespace exercise6_animal
{
    class Cat : Animal
    {
        public Cat(string type) : base(type)
        {
        }

        public void Climb(string place)
        {
            Console.WriteLine($"Cat climbs {place}");
        }

        public override string GetSound()
        {
            return "Meo meo";
        }

        public override string GetInformation()
        {
            return $"Type: {Type}\n" +
                   $"Animal: Cat";
        }
    }
}