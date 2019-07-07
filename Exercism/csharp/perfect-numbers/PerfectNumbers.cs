using System;
using System.Collections.Generic;
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

        var factors = new List<int>();
        for (var i = 1; i < int.MaxValue; i++)
        {
            if (i >= number)
            {
                break;
            }

            if (number % i == 0)
            {
                factors.Add(i);
            }
        }

        var sum = factors.Sum();
        return sum == number ? Classification.Perfect : sum > number ? Classification.Abundant : Classification.Deficient;
    }
}