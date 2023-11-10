using System;

namespace Exercise012
{
    public class Multiplier
    {
        private int number;

        public Multiplier(int number)
        {
            this.number = number;
        }

        public int Multiply(int number)
        {
            this.number = this.number * number;
            return this.number;
        }
    }
}
