using System.Collections.Generic;
using GA.Domain.Chromosomes.Abstractions;

namespace GA.Domain.Generations.Abstractions
{
    public interface IGeneration
    {
        int GenerationNumber { get; }
        IList<IChromosome> Chromosomes { get; }
        IChromosome BestChromosome { get; set; }
        void EvaluateBest();
    }
}