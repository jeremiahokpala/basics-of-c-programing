namespace Exercise001
{
    public class Timer
    {
        private ClockHand seconds;
        private ClockHand hunSeconds;

        public Timer()
        {
            this.seconds = new ClockHand(60);
            this.hunSeconds = new ClockHand(100);
        }

        public void Advance()
        {
            this.hunSeconds.Advance();
            if (this.hunSeconds.value == 0)
            {
                seconds.Advance();
            }
        }

        public override string ToString()
        {
            return seconds + ":" + hunSeconds;
        }
    }
}
