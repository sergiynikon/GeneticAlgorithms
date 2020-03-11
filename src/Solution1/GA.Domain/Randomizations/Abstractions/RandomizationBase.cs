using System;
using System.Collections.Generic;
using System.Text;

namespace GA.Domain.Randomizations.Abstractions
{
    public abstract class RandomizationBase : IRandomization
    {
        public int[] GetRandomInts(int minValue, int maxValue, int length)
        {
            var randomInts = new int[length];

            for (int i = 0; i < length; i++)
            {
                randomInts[i] = GetRandomInt(minValue, maxValue);
            }

            return randomInts;
        }

        public abstract double GetRandomDouble();

        public double GetRandomDouble(double minValue, double maxValue)
        {
            return minValue + GetRandomDouble() * (maxValue - minValue);
        }

        public abstract int GetRandomInt(int minValue, int maxValue);
    }
}
