namespace Exercise010
{
    using System;

    public class Apartment
    {
        private int rooms;
        private int squares;
        private int pricePerSquare;

        public Apartment(int rooms, int squares, int pricePerSquare)
        {
            this.rooms = rooms;
            this.squares = squares;
            this.pricePerSquare = pricePerSquare;
        }

        public bool LargerThan(Apartment compared)
        {
            return this.squares > compared.squares;
        }

        private int Price()
        {
            return this.pricePerSquare * this.squares;
        }

        public int PriceDifference(Apartment compared)
        {
            // Math.Abs returns the absolute value


            return Math.Abs(this.Price() - compared.Price());
        }

        public bool MoreExpensiveThan(Apartment compared)
        {
            return this.Price() > compared.Price();
        }
    }
}
