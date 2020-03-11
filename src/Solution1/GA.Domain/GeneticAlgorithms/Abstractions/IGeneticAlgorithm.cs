using GA.Domain.Chromosomes.Abstractions;
using GA.Domain.Crossovers.Abstractions;
using GA.Domain.Fitnesses.Abstractions;
using GA.Domain.Generations.Abstractions;
using GA.Domain.Mutations.Abstractions;
using GA.Domain.Populations.Abstractions;
using GA.Domain.Selections.Abstractions;
using GA.Domain.Terminations.Abstractions;

namespace GA.Domain.GeneticAlgorithms.Abstractions
{
    public interface IGeneticAlgorithm
    {
        int GenerationNumber { get; }
        IChromosome BestChromosome { get; }
        IPopulation Population { get; }
        IFitness Fitness { get; }
        ISelection Selection { get; }
        ICrossover Crossover { get; }
        IMutation Mutation { get; }
        ITermination Termination { get; }
    }
}