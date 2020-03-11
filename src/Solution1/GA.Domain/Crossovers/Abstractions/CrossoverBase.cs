using System;
using System.Collections.Generic;
using System.Text;
using GA.Domain.Chromosomes.Abstractions;
using GA.Domain.Randomizations;

namespace GA.Domain.Crossovers.Abstractions
{
    public abstract class CrossoverBase : ICrossover
    {
        private readonly double _crossoverProbability;
        protected CrossoverBase(int parentsNumber, int childrenNumber, double crossoverProbability)
        {
            ParentsNumber = parentsNumber;
            ChildrenNumber = childrenNumber;
            _crossoverProbability = crossoverProbability;
        }

        public int ParentsNumber { get; }
        public int ChildrenNumber { get; }

        public IList<IChromosome> Cross(params IChromosome[] parents)
        {
            if (parents == null)
            {
                throw new ArgumentNullException(nameof(parents));
            }

            if (parents.Length != ParentsNumber)
            {
                throw new ArgumentException($"Length of {nameof(parents)} should be {ParentsNumber}.");
            }

            if (CrossCondition())
            {
                return PerformCross(parents);
            }

            return parents;
        }

        protected abstract IList<IChromosome> PerformCross(params IChromosome[] parents);

        private bool CrossCondition()
        {
            return RandomizationProvider.Instance.GetRandomDouble() <= _crossoverProbability;
        }
    }
}
