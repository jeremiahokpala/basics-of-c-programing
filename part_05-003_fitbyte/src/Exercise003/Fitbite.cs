namespace Exercise003
{
    public class Fitbyte
    {
        int age { get; set; }
        int restingHeartRate { get; set; }

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            double maxHeartRate = 206.3 - (0.711 * age);
            return (maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate;
        }
    }
}
