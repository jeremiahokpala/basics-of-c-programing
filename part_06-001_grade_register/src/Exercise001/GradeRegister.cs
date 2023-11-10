namespace Exercise001
{
    using System.Collections.Generic;
    using System;

    public class GradeRegister
    {
        private List<int> grades;
        private List<int> exampoints;

        public GradeRegister()
        {
            this.grades = new List<int>();
            this.exampoints = new List<int>();
        }

        public void AddGradeBasedOnPoints(int points)
        {
            this.grades.Add(PointsToGrades(points));

            this.exampoints.Add((points));
        }

        public int NumberOfGrades(int grade)
        {
            int count = 0;
            foreach (int received in this.grades)
            {
                if (received == grade)
                {
                    count++;
                }
            }
            return count;
        }

        public static int PointsToGrades(int points)
        {
            int grade = 0;
            if (points < 50)
            {
                grade = 0;
            }
            else if (points < 60)
            {
                grade = 1;
            }
            else if (points < 70)
            {
                grade = 2;
            }
            else if (points < 80)
            {
                grade = 3;
            }
            else if (points < 90)
            {
                grade = 4;
            }
            else
            {
                grade = 5;
            }
            return grade;
        }

        public double AverageOfGrades()
        {
            // Hint! You don't need to round the -1, but you do need it for all the other results...

            if (grades.Count == 0)
            {
                return Math.Round(-1.0, 2);
            }
            else
            {
                double avr = 0;
                double avr1 = 0;

                foreach (int grade in grades)
                {
                    avr = avr + grade;
                }
                avr1 = avr / grades.Count;

                return Math.Round(avr1, 2);
            }
        }

        public double AverageOfPoints()
        {
            if (exampoints.Count == 0)
            {
                return Math.Round(-1.0, 2);
            }
            else
            {
                double avr = 0;
                double avr1 = 0;

                foreach (int point in exampoints)
                {
                    avr = avr + point;
                }
                avr1 = avr / exampoints.Count;

                return Math.Round(avr1, 2);
            }
        }
    }
}
