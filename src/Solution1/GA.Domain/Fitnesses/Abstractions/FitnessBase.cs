using GA.Domain.Chromosomes.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GA.Domain.Fitnesses.Abstractions
{
    public abstract class FitnessBase : IFitness
    {
        private readonly Func<IChromosome, double> _fitnessFunc;

        protected FitnessBase(Func<IChromosome, double> fitnessFunc)
        {
            _fitnessFunc = fitnessFunc;
        }
        public virtual double Calculate(IChromosome chromosome)
        {
            return _fitnessFunc?.Invoke(chromosome) ?? double.MaxValue;
        }
    }
}
