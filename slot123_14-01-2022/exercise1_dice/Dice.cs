using System;

namespace exercise1_dice
{
    public class Dice
    {
        public int Side { get; set; }

        public Dice(int sides)
        {
            Side = sides;
        }

        public int Roll()
        {
            return (new Random()).Next(1, Side);
        }
    }
}