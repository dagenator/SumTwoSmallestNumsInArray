using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumTwoSmallestNumsInArray
{
    public class ArrayCalculation
    {
        //Очередь с двумя последними минимальными эллементами
        private double[] ArrayWithMinimums;
        private readonly int ArrayLength;
        public ArrayCalculation(int num)
        {
            ArrayLength = num;
            ArrayWithMinimums = Enumerable.Repeat(double.PositiveInfinity, ArrayLength).ToArray();
        }
        
        private double GetSum()
        {
            double sum = 0;
            foreach (var var in ArrayWithMinimums)
            {
                sum += var;
            }

            return sum;
        }

        private void TryToSetNum(double num)
        {
            if (ArrayWithMinimums[^1] > num)
                ArrayWithMinimums[^1] = num;
            Array.Sort(ArrayWithMinimums);
        }

        public double GetSumTwoMinimumInArray(double[] arr)
        {
            if (arr.Length == 0)
                throw new Exception("Array is empty");

            foreach (var n in arr)
            {
                TryToSetNum(n);
            }

            return GetSum();
        }
    }
}
