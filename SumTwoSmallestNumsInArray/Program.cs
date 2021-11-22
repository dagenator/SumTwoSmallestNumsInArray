using System;
using System.Collections.Generic;

namespace SumTwoSmallestNumsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCalculation calc = new ArrayCalculation();
            double res = calc.GetSumTwoMinimumInArray(new double[] { -1, 1, 4, 10, -3 });
            Console.WriteLine(res);
        }
    }
}
