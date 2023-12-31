namespace Exercise015
{
    public class Money
    {
        private int euros;
        private int cents;

        public Money(int euros, int cents)
        {
            if (cents > 99)
            {
                euros = euros + cents / 100;
                cents = cents % 100;
            }

            this.euros = euros;
            this.cents = cents;
        }

        public Money Plus(Money addition)
        {
            Money newMoney = new Money(this.euros + addition.euros, this.cents + addition.cents);
            return newMoney;
        }

        public Money Minus(Money decreaser)
        {
            Money zero = new Money(0, 00);
            if (decreaser.LessThan(this))
            {
                if (this.cents - decreaser.cents < 1)
                {
                    if (this.cents > 10)
                    {
                        Money decreaseMoney = new Money(this.euros - decreaser.euros - 1, 90);
                        return decreaseMoney;
                    }
                }
                Money newMoney = new Money(
                    this.euros - decreaser.euros,
                    this.cents - decreaser.cents
                );
                return newMoney;
            }

            return zero;
        }

        public bool LessThan(Money compared)
        {
            if (this.euros > compared.euros)
            {
                return false;
            }
            else if (this.euros == compared.euros && this.cents > compared.cents)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            string zero = "";
            if (this.cents <= 10)
            {
                zero = "0";
            }

            return this.euros + "." + zero + this.cents + "e";
        }
    }
}
