using System.Collections.Generic;
using GA.Domain.Chromosomes.Abstractions;

namespace GA.Domain.Crossovers.Abstractions
{
    public interface ICrossover
    {
        int ParentsNumber { get; }
        int ChildrenNumber { get; }
        IList<IChromosome> Cross(params IChromosome[] parents);
    }
}
