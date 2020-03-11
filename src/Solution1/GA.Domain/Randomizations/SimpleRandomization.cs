using GA.Domain.Randomizations.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GA.Domain.Randomizations
{
    public class SimpleRandomization : RandomizationBase
    {
        /// <summary>
        ///     Get unique seed value
        /// </summary>
        /// <returns>Int value.</returns>
        private static int GetNewSeedValue() => Guid.NewGuid().GetHashCode();

        /// <inheritdoc/>
        public override double GetRandomDouble()
        {
            // create random instance with unique seed value.
            var rnd = new Random(GetNewSeedValue());
            return rnd.NextDouble();
        }


        public override int  GetRandomInt(int minValue, int maxValue)
        {
            // create random instance with unique seed value.
            var rnd = new Random(GetNewSeedValue());
            return rnd.Next(minValue, maxValue);
        }
    }
}
