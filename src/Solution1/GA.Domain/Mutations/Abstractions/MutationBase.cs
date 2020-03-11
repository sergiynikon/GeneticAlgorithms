using GA.Domain.Chromosomes.Abstractions;
using GA.Domain.Randomizations;
using GA.Domain.Randomizations.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GA.Domain.Mutations.Abstractions
{
    public abstract class MutationBase : IMutation
    {
        private static double DefaultMutationProbability = 0.01;

        private readonly double _mutationProbability;

        protected MutationBase()
        {
            _mutationProbability = DefaultMutationProbability;
        }

        protected MutationBase(double mutationProbability)
        {
            _mutationProbability = mutationProbability;
        }
        public void Mutate(IChromosome chromosome, double probability)
        {
            if (chromosome == null)
            {
                throw new ArgumentNullException(nameof(chromosome));
            }

            if (MutateCondition())
            {
                PerformMutate(chromosome, probability);
            }
        }

        public abstract void PerformMutate(IChromosome chromosome, double probability);

        private bool MutateCondition()
        {
            return RandomizationProvider.Instance.GetRandomDouble() <= _mutationProbability;
        }
    }
}
