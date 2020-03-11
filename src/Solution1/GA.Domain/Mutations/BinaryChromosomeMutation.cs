using GA.Domain.Chromosomes;
using GA.Domain.Chromosomes.Abstractions;
using GA.Domain.Mutations.Abstractions;
using GA.Domain.Randomizations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GA.Domain.Mutations
{
    public sealed class BinaryChromosomeMutation : MutationBase
    {
        public BinaryChromosomeMutation(double mutationProbability) : base(mutationProbability)
        {
        }

        public override void PerformMutate(IChromosome chromosome, double probability)
        {
            var binaryChromosome = chromosome as BinaryChromosome;
            var indexChromosomeToMutate = RandomizationProvider.Instance.GetRandomInt(0, chromosome.Length);

            binaryChromosome.InverseGene(indexChromosomeToMutate);
        }
    }
}
