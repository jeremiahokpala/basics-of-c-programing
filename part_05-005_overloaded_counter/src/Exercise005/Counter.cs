namespace Exercise005
{
    public class Counter
    {
        public int value { get; set; }

        public Counter()
        {
            this.value = 0;
        }

        public Counter(int startValue)
        {
            this.value = startValue;
        }

        public void Increase()
        {
            this.value++;
        }

        public void Decrease()
        {
            this.value--;
        }

        public void Increase(int increaseBy)
        {
            if (increaseBy < 0) { }
            else
            {
                this.value += increaseBy;
            }
        }

        public void Decrease(int decreaseBy)
        {
            if (decreaseBy < 0) { }
            else
            {
                this.value -= decreaseBy;
            }
        }
    }
}
