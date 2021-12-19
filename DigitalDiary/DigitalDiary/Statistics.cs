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
            Min = double.MinValue;
            Max = double.MaxValue;
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
            Count++;
            Min = Math.Min(Max, number);
            Max = Math.Max(Min, number);
        }
    }
}
