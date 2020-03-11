using System;
using System.Collections.Generic;
using GA.Domain.Chromosomes.Abstractions;
using GA.Domain.Generations.Abstractions;

namespace GA.Domain.Selections.Abstractions
{
    public abstract class SelectionBase : ISelection
    {
        private readonly int _numberOfParents;

        protected SelectionBase(int numberOfParents)
        {
            _numberOfParents = numberOfParents;
        }

        public IList<IChromosome> Select(int numberOfChildren, IGeneration generation)
        {
            if (generation == null)
            {
                throw new ArgumentNullException(nameof(generation));
            }

            if (numberOfChildren < _numberOfParents)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfChildren), $"The number of selecting chromosomes should be at least {2}");
            }

            if (numberOfChildren > generation.Chromosomes.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfChildren), $"The number of chromosomes in the generation is {generation.Chromosomes.Count}, but {nameof(numberOfChildren)} is {numberOfChildren}");
            }

            return PerformSelect(numberOfChildren, generation);
        }

        public abstract IList<IChromosome> PerformSelect(int number, IGeneration generation);
    }
}