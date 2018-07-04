using System;
using Solver;

namespace L7_PracticeFirstUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var result = QuadraticEquationSolver.Solve(a, b, c);
            foreach (var response in result)
            {
                Console.WriteLine(response);
            }
        }
    }
}
