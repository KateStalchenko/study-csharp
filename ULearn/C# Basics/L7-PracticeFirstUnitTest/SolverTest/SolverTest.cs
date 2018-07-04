using Solver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SolverTest
{
    [TestClass]
    public class SolverTest
    {
        void Test(double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticEquationSolver.Solve(a, b, c);

            Assert.AreEqual(expectedResult.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }

        [TestMethod]
        public void OrdinaryEquation()
        {
            Test(1, -3, 2, 2, 1);
        }

        [TestMethod]
        public void NegativeDiscriminant()
        {
            Test(1, 1, 1);
        }

        [TestMethod]
        public void ZeroDiscriminant()
        {
            Test(1, 2, 1, -1);
        }

        [TestMethod]
        public void ZeroA()
        {
            Test(0, -1, 1, 1);
        }

        [TestMethod]
        public void FunctionalTest()
        {
            var rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                var a = rnd.NextDouble() * 10;
                var b = rnd.NextDouble() * 10;
                var c = rnd.NextDouble() * 10;
                var result = QuadraticEquationSolver.Solve(a, b, c);
                for (int j = 0; j < result.Length; j++)
                {
                    Assert.AreEqual(0, a * result[j] * result[j] + b * result[j] + c, 10e-6);
                }
            }
        }
    }
}
