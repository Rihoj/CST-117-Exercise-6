using System;
namespace CST_117_Exercise_6
{
    public class Dice
    {
        private int sides;
        public Dice(int sides)
        {
            this.sides = sides;

        }

        public int rollDie()
        {
            return Randomizer.generate(sides);
        }
    }
}