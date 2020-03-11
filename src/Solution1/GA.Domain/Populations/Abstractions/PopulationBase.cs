using GA.Domain.Chromosomes.Abstractions;
using GA.Domain.Generations.Abstractions;
using System.Collections.Generic;

namespace GA.Domain.Populations.Abstractions
{
    public abstract class PopulationBase : IPopulation
    {
        protected PopulationBase(int length)
        {
            Length = length;
            Chromosomes = new IChromosome[length];
        }
        public int Length { get; }

        public IChromosome[] Chromosomes { get; }

        public double Fitness { get; set; }

        public abstract IChromosome CreateNewChromosome();

        public IList<IGeneration> AllGenerations { get; }
    }
}
