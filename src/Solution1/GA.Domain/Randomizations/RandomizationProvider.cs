using GA.Domain.Randomizations.Abstractions;

namespace GA.Domain.Randomizations
{
    public static class RandomizationProvider
    {
        public static IRandomization Instance => Instance ?? new SimpleRandomization();
    }
}
