using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentException();
        }

        var stepsNumber = 0;

        while (number != 1)
        {
            if (number == 1)
            {
                break;
            }

            if (number % 2 == 0)
            {
                number /= 2;
                stepsNumber++;
            }

            else
            {
                number = number * 3 + 1;
                stepsNumber++;
            }
        }

        return stepsNumber;
    }
}