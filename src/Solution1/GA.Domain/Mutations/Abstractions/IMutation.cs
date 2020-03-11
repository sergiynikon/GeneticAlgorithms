using GA.Domain.Chromosomes.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GA.Domain.Mutations.Abstractions
{
    public interface IMutation
    {
        void Mutate(IChromosome chromosome, double probability);
    }
}
