using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class AllArrayQuestions
    {
        #region Compare Triplet
        public static int[] CompareTheTriplets(int[] a, int[] b)
        {
            int[] result = { 0, 0 };
            if(a.Length == 3 && b.Length == 3)
            {
                for(int i = 0; i < 3; i++)
                {
                    if (a[i] > b[i])
                        result[0] = result[0] + 1;
                    else if (a[i] < b[i])
                        result[1] = result[1] + 1;
                }
            }
            return result;
        }
        public static List<int> CompareTheTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int> { 0, 0 };
            if (a.Count == 3 && b.Count == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (a[i] > b[i])
                        result[0] = result[0] + 1;
                    else if (a[i] < b[i])
                        result[1] = result[1] + 1;
                }
            }
            return result;
        }
        #endregion
        #region Sum of big array
        public static long aVeryBigSum(List<long> ar)
        {
            long sum =0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum = sum + ar[i];
            }
            return sum;
        }
        #endregion
        #region Matrix diagonal difference
        public static int diagonalDifference(int[][] matrix)
        {
            int n = matrix.Length;
            int leftdiagonalSum = 0;
            int rightdiagonalSum = 0;
            for (int i = 0; i < n; i++)
            {
                leftdiagonalSum = leftdiagonalSum + matrix[i][i];
                rightdiagonalSum = rightdiagonalSum + matrix[i][n-i-1];
            }

            return Math.Abs(leftdiagonalSum - rightdiagonalSum);
        }
        public static int diagonalDifference(List<List<int>> matrix)
        {
            int n = matrix.Count;
            int leftdiagonalSum = 0;
            int rightdiagonalSum = 0;
            for (int i = 0; i < n; i++)
            {
                leftdiagonalSum = leftdiagonalSum + matrix[i][i];
                rightdiagonalSum = rightdiagonalSum + matrix[i][n - i - 1];
            }
            return Math.Abs(leftdiagonalSum - rightdiagonalSum);
        }

        #endregion

        #region Given an array of integers, calculate the ratios of its elements that are positive, negative,
        public static void plusMinus(int[] arr)
        {
            int n = arr.Length;
            double positiveRatio = 0.0f;
            double negativeRatio = 0.0f;
            double zeroRatio = 0.0f;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    positiveRatio += 1;
                else if (arr[i] < 0)
                    negativeRatio += 1;
                else
                    zeroRatio += 1;
            }
            Console.WriteLine((positiveRatio/n).ToString("F6"));
            Console.WriteLine((negativeRatio/n).ToString("F6"));
            Console.WriteLine((zeroRatio/n).ToString("F6"));
        }
        public static void plusMinus(List<int> arr)
        {
            int n = arr.Count;
            double positiveRatio = 0.0f;
            double negativeRatio = 0.0f;
            double zeroRatio = 0.0f;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    positiveRatio += 1;
                else if (arr[i] < 0)
                    negativeRatio += 1;
                else
                    zeroRatio += 1;
            }
            Console.WriteLine((positiveRatio / n).ToString("F6"));
            Console.WriteLine((negativeRatio / n).ToString("F6"));
            Console.WriteLine((zeroRatio / n).ToString("F6"));
        }

        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                // Print spaces
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }

                // Print #
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }

                // Move to the next line
                Console.WriteLine();
            }
        }

        public static void miniMaxSum(int[] arr)
        {
            long[] result = new long[5];
            long sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0;j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        sum = sum + arr[j];
                    }
                }
                result[i] = sum;
                sum = 0;
            }
            Console.WriteLine($"{result.Min()} {result.Max()}");
        }

        //You can also sort the array 
        public static void miniMaxSum(List<int> arr)
        {
            long[] result = new long[5];
            long sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0;j < arr.Count; j++)
                {
                    if (i != j)
                    {
                        sum = sum + arr[j];
                    }
                }
                result[i] = sum;
                sum = 0;
            }
            Console.WriteLine($"{result.Min()} {result.Max()}");
        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            candles.Sort();
            candles.Reverse();
            int count = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                if (candles[0] == candles[i])
                {
                    count++;
                }
            }
            return count;
        }
        #endregion
    }
}
