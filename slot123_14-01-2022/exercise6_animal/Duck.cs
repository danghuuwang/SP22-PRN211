using System;

namespace exercise6_animal
{
    class Duck : Animal
    {
        public Duck(string type) : base(type)
        {
        }

        public void Swim(string place)
        {
            Console.WriteLine($"Cat swims {place}");
        }

        public override string GetSound()
        {
            return "Wack wack";
        }

        public override string GetInformation()
        {
            return $"Type: {Type}\n" +
                   $"Animal: Duck";
        }
    }
}