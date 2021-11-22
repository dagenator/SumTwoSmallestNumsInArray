using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SumTwoSmallestNumsInArray;

namespace ArrayCalculationTests
{

    [TestFixture]
    class ArrayCalculationTests
    {

        [Test]
        public void ExceptionTest()
        {
            ArrayCalculation calc = new ArrayCalculation();

            Assert.Throws<Exception>(() => calc.GetSumTwoMinimumInArray( new double[] { } ));
        }

        [TestCase(1, new double[] {1, 4, 5, 0 })]  
        [TestCase(-10, new double[] { 1, -7, -3,-1, 4  })]  
        [TestCase(0, new double[] { -1, 1, 4, 10 })]
        [TestCase(double.NaN, new double[] {double.PositiveInfinity, double.NegativeInfinity })]
        public void TestCases( double expectedResult, double[] inputArray)
        {
            ArrayCalculation calc = new ArrayCalculation();
            Assert.AreEqual(expectedResult, calc.GetSumTwoMinimumInArray(inputArray));
        }

    }
}
