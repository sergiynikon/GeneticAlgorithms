using GA.Domain.Genes;
using System;
using System.Collections;
using System.Linq;

namespace GA.Domain.Chromosomes.Extensions
{
    public static class GeneExtension
    {
        public static int ToInt(this Gene[] genes)
        {
            var bitArray = new BitArray(genes.Select(g => g.Value).ToArray());
            return GetIntFromBitArray(bitArray);
        }

        private static int GetIntFromBitArray(BitArray bitArray)
        {

            if (bitArray.Length > 32)
                throw new ArgumentException("Argument length shall be at most 32 bits.");

            int[] array = new int[1];
            bitArray.CopyTo(array, 0);
            return array[0];

        }
    }
}
