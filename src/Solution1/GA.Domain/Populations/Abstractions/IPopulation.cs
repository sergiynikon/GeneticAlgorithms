using GA.Domain.Chromosomes.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using GA.Domain.Generations.Abstractions;

namespace GA.Domain.Populations.Abstractions
{
    public interface IPopulation
    {
        int Length { get; }
        double Fitness { get; set; }
        IChromosome[] Chromosomes { get; }
        IList<IGeneration> AllGenerations { get; }
        IChromosome CreateNewChromosome();
    }
}
