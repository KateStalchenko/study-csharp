//Задано время Н часов(ровно). Вычислить угол в градусах между часовой и минутной стрелками.

using System;
using System.Collections.Generic;

namespace Practice01_Ulearn
{
    class Time
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> time = new Dictionary<int, int>
            {
                [0] = 90,
                [1] = 60,
                [2] = 30,
                [3] = 0,
                [4] = 330,
                [5] = 300,
                [6] = 270,
                [7] = 240,
                [8] = 210,
                [9] = 180,
                [10] = 160,
                [11] = 120,
                [12] = 90
            };

            int difference = 0;
            Console.WriteLine("Write the time in 12h format: ");
            int userTime = int.Parse(Console.ReadLine());

            if (userTime < 0 || userTime > 12)
            {
                Console.WriteLine("Incorrect time!");
            }
            else if (0 <= userTime && userTime <= 12)
            {
                difference = time[userTime] - 90;
                Console.WriteLine($"The angle is {difference} degrees.");
            }

            Console.ReadKey();
        }
    }
}