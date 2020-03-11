using System.Collections.Generic;
using System.Linq;
using GA.Domain.Chromosomes.Abstractions;
using GA.Domain.Generations.Abstractions;
using GA.Domain.Randomizations;
using GA.Domain.Selections.Abstractions;

namespace GA.Domain.Selections
{
    public class TournamentSelection : SelectionBase
    {
        public TournamentSelection(int numberOfCandidates, bool allowBestCandidateCompleteNextSelection = false) : base(numberOfParents:2)
        {
            NumberOfCandidates = numberOfCandidates;
            AllowBestCandidateCompleteNextSelection = allowBestCandidateCompleteNextSelection;
        }


        public int NumberOfCandidates { get; set; }
        public bool AllowBestCandidateCompleteNextSelection { get; set; }

        public override IList<IChromosome> PerformSelect(int number, IGeneration generation)
        {
            var candidates = generation.Chromosomes;

            var selectedCandidates = new List<IChromosome>();

            while (selectedCandidates.Count < number)
            {
                var candidateIndexes = RandomizationProvider.Instance.GetRandomInts(
                    minValue: 0,
                    maxValue: candidates.Count, 
                    length: NumberOfCandidates);

                var currentBestCandidate = candidates
                    .Where((c, i) => candidateIndexes.Contains(i))
                    .OrderByDescending(c => c.Fitness)
                    .First();

                selectedCandidates.Add(currentBestCandidate);

                if (!AllowBestCandidateCompleteNextSelection)
                {
                    candidates.Remove(currentBestCandidate);
                }
            }

            return selectedCandidates;
        }
    }
}