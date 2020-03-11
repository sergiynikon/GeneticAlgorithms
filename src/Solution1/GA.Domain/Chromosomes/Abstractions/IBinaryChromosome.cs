using System;
using System.Collections.Generic;
using System.Text;

namespace GA.Domain.Chromosomes.Abstractions
{
    public interface IBinaryChromosome
    {
        void InverseGene(int index);
    }
}
