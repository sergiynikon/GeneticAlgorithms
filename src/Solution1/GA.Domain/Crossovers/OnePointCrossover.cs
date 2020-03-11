using GA.Domain.Chromosomes.Abstractions;
using GA.Domain.Crossovers.Abstractions;
using GA.Domain.Genes;
using GA.Domain.Randomizations;
using System.Collections.Generic;
using System.Linq;

namespace GA.Domain.Crossovers
{
    public class OnePointCrossover : CrossoverBase
    {
        public OnePointCrossover(double crossoverProbability) : base(parentsNumber: 2, childrenNumber: 2, crossoverProbability)
        {
        }

        protected override IList<IChromosome> PerformCross(params IChromosome[] parents)
        {
            var parent1 = parents[0];
            var parent2 = parents[1];
            var splitIndex = RandomizationProvider.Instance.GetRandomInt(0, parent1.Length - 1);

            //var part11 = parent1.Genes.Take(splitIndex);
            //var part12 = parent1.Genes.Skip(splitIndex).Take(parent1.Length - (splitIndex + 1));
            //var part21 = parent2.Genes.Take(splitIndex);
            //var part22 = parent2.Genes.Skip(splitIndex).Take(parent2.Length - (splitIndex + 1));

            //var child1Genes = part11.Concat(part22);
            //var child2Genes = part21.Concat(part12);

            //var child1 = new BinaryChromosome();

            var child1 = parent1.Clone();
            child1.ReplaceGenes(splitIndex, parent2.Genes.Skip(splitIndex) as Gene[]);

            var child2 = parent2.Clone();
            child2.ReplaceGenes(splitIndex, parent1.Genes.Skip(splitIndex) as Gene[]);

            return new List<IChromosome> {child1, child2};
        }
    }
}