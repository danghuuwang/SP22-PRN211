using System;

namespace exercise6_animal
{
    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string type, string breed) : base(type)
        {
            Breed = breed;
        }

        public override string GetSound()
        {
            return "Gau Gau";
        }

        public override string GetInformation()
        {
            return $"Type: {Type}\n" +
                   $"Animal: Dog\n" +
                   $"Breed: {Breed}";
        }
    }
}