using System;
using System.Runtime.CompilerServices;
using GA.Domain.Generations.Abstractions;
using GA.Domain.Genes;

namespace GA.Domain.Chromosomes.Abstractions
{
    public interface IChromosome
    {
        int Length { get; }
        Gene[] Genes { get; }
        double Fitness { get; set; }
        void ReplaceGene(int index, Gene newGene);
        void ReplaceGenes(int startIndex, Gene[] newGenes);
        IChromosome Clone();
    }
}
