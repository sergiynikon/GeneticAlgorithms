using GA.Domain.Chromosomes.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GA.Domain.Fitnesses.Abstractions
{
    public interface IFitness
    {
        double Calculate(IChromosome chromosome);
    }
}
