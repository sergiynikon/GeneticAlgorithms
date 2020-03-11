using GA.Domain.Chromosomes.Abstractions;
using GA.Domain.Chromosomes.Extensions;

namespace GA.Domain.Chromosomes
{
    public class BinaryChromosome : ChromosomeBase, IBinaryChromosome
    {
        public BinaryChromosome(int length) : base(length)
        {
        }

        public void InverseGene(int index)
        {
            Genes[index].Value = Genes[index].Value == 1 ? 0 : 1;
        }

        public override IChromosome Clone()
        {
            var newChromosome = new BinaryChromosome(Length);
            newChromosome.ReplaceGenes(startIndex:0, Genes);
            return newChromosome;
        }
    }
}
