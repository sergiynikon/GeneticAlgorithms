using System;
using System.Collections.Generic;
using System.Text;

namespace GA.Domain.Randomizations.Abstractions
{
    public interface IRandomization
    {
        int GetRandomInt(int minValue, int maxValue);

        int[] GetRandomInts(int minValue, int maxValue, int length);

        /// <summary>
        ///     Gets double value between 0 and 1.
        /// </summary>
        /// <returns>Double value.</returns>
        double GetRandomDouble();

        double GetRandomDouble(double minValue, double maxValue);
    }
}
