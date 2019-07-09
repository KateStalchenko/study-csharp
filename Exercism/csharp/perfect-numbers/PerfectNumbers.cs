using System;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        var factors = Enumerable.Range(1, number - 1).Where(x => (number % x) == 0).ToList();

        var sum = factors.Sum();

        if (factors.Count() == 2 && factors.Contains(1))
        {
            return Classification.Deficient;
        }

        if (sum == number)
        {
            return Classification.Perfect;
        }
        if (sum > number)
        {
            return Classification.Abundant;
        }
        return Classification.Deficient;
    }
}