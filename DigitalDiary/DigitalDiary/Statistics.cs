using System;

namespace DigitalDiary
{
    public class Statistics
    {
        private double Min;
        private double Max;
        private double Sum;
        private int Count;

        public Statistics()
        {
            Min = double.MaxValue;
            Max = double.MinValue;
            Count = 0;
            Sum = 0.0;
        }

        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Min = Math.Min(number, Min);
            Max = Math.Max(number, Max);
        }

        public void ShowStatistics(Statistics statistics)
        {
            Console.WriteLine($"The highest grade is {statistics.Max}");
            Console.WriteLine($"The lowest grade is {statistics.Min}");
            Console.WriteLine($"The average grade is {statistics.Average:N2}");
        }
    }
}
