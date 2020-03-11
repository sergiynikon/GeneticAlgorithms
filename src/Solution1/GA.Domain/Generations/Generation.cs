using System.Collections.Generic;
using System.Linq;
using GA.Domain.Chromosomes.Abstractions;
using GA.Domain.Generations.Abstractions;

namespace GA.Domain.Generations
{
    public class Generation : IGeneration
    {
        public int GenerationNumber { get; }
        public IList<IChromosome> Chromosomes { get; private set; }
        public IChromosome BestChromosome { get; set; }
        public void EvaluateBest()
        {
            Chromosomes = Chromosomes
                .OrderByDescending(c => c.Fitness).ToList();

            BestChromosome = Chromosomes.First();
        }

    }
}