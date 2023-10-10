using DataStructures.Recursion;
using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RECURSION
            //AllRecurionQuestions.printNumberInReverse(5);
            //Console.WriteLine($"Factorial is {AllRecurionQuestions.factorial(3)}");
            Console.WriteLine($"Fibonacci is {AllRecurionQuestions.fibonacci(4)}");
            AllRecurionQuestions.printFibonacciSeries(4);
            #endregion


            #region ARRAYS
            int[] arrayReverse = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ReverseArray.ReverseLogicOne(arrayReverse);
            ReverseArray.ReverseLogicTwo(arrayReverse);
            ReverseArray.ReverseLogicThree("OMKAR");

            int[] a = { 7, 2, 3 }; int[] b = { 3, 2, 1 };
            AllArrayQuestions.CompareTheTriplets(a, b);
            List<int> lista = new List<int>() { 7, 2, 3 }; List<int> listb = new List<int>() { 3, 2, 1 };
            AllArrayQuestions.CompareTheTriplets(lista, listb);

            List<long> aBig = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            AllArrayQuestions.aVeryBigSum(aBig);
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3},
                new int[] { 4, 5, 6},
                new int[] { 9, 8, 9}
            };
            AllArrayQuestions.diagonalDifference(matrix);
            List<List<int>> matrixList = new List<List<int>>
            {
                new List<int> { 1, 2, 3},
                new List<int> { 4, 5, 6 },
                new List<int> { 9, 8, 9 }
            };
            AllArrayQuestions.diagonalDifference(matrixList);
            int[] plusMinus = new int[] { 1, 1, 0, -1, -1 };
            AllArrayQuestions.plusMinus(plusMinus);
            List<int> plusMinus1 = new List<int> { 1, 1, 0, -1, -1 };
            AllArrayQuestions.plusMinus(plusMinus1);
            AllArrayQuestions.staircase(4);
            int[] minMaxSum = new int[] { 1,3,5,7,9 };
            AllArrayQuestions.miniMaxSum(minMaxSum);
            List<int> minMaxSum1 = new List<int> { 1, 3, 5, 7, 9 };
            AllArrayQuestions.miniMaxSum(minMaxSum1);
            List<int> birthdayCakeCandles = new List<int> { 4,4,1,3 };
            AllArrayQuestions.birthdayCakeCandles(birthdayCakeCandles);
            #endregion

            StringFindings.StringsAreImmutable();
            StringFindings.UnderstandStringBuilderMemoryConsumption();
            StringFindings.UnderstandStringConcatinationMemoryConsumption();




            Console.ReadKey();
        }
    }
}
