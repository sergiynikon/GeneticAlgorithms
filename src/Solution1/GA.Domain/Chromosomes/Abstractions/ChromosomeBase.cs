using GA.Domain.Genes;
using System;

namespace GA.Domain.Chromosomes.Abstractions
{
    public abstract class ChromosomeBase : IChromosome
    {
        protected ChromosomeBase(int length)
        {
            Length = length;
            Genes = new Gene[length];
        }

        public Gene[] Genes { get; }
        public int Length { get; }

        public double Fitness { get; set; }

        public virtual void ReplaceGene(int index, Gene newGene)
        {
            Genes[index] = newGene;
        }

        public virtual void ReplaceGenes(int startIndex, Gene[] newGenes)
        {
            Array.Copy(
                sourceArray: newGenes,
                sourceIndex: 0,
                destinationArray: Genes,
                destinationIndex: startIndex,
                length: newGenes.Length);
        }

        public Gene this[int index] => Genes[index];
        public abstract IChromosome Clone();
    }
}
