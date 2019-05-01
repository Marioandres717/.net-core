using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double Low;
        public double High;
        public char Letter
        {
            get
            {
                switch(Average)
                {
                case var d when d >= 90.0:
                     return 'A';

                case var d when d >= 80.0:
                     return 'B';

                case var d when d >= 70.0:
                     return 'C';

                case var d when d >= 60.0:
                     return 'D';

                default:
                     return 'F';
                }
            }
        }
        public int Count;

        public double Sum;

        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
        }

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }
    }
}