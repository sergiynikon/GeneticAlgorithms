using System.Collections.Generic;
using GA.Domain.Chromosomes.Abstractions;
using GA.Domain.Generations.Abstractions;

namespace GA.Domain.Selections.Abstractions
{
    public interface ISelection
    {
        IList<IChromosome> Select(int numberOfChildren, IGeneration generation);
    }
}