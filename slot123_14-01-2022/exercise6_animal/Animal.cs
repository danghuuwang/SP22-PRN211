namespace exercise6_animal
{
    abstract class Animal
    {
        public string Type { get; set; }

        protected Animal(string type)
        {
            Type = type;
        }

        public abstract string GetSound();
        public abstract string GetInformation();
    }
}