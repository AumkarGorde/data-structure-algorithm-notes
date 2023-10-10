using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    public static class AllRecurionQuestions
    {
        /*A recursive funtion will always have base case
         A recursive method solves a problem by calling a copy of itself to work on smaller problem
         */
        public static void printNumberInReverse(int n)
        {
            if (n == 0) 
            {
                Console.WriteLine("Returning from: 0"); // Add this line
                return;
            }
            else
            {
                Console.WriteLine(n);
                printNumberInReverse(n-1);
                Console.WriteLine("Returning from: " + n);
            }
        }

        /*Factorial using recursion
          Formula n * (n-1) 
        
        Can culation is done at the time of unwinding 
        CalculateFactorial(0) returns 1
        CalculateFactorial(1) returns 1 * 1 = 1
        CalculateFactorial(2) returns 2 * 1 = 2
        CalculateFactorial(3) returns 3 * 2 = 6
        CalculateFactorial(4) returns 4 * 6 = 24
        CalculateFactorial(5) returns 5 * 24 = 120
         */
        public static long factorial(int n)
        {
            if(n == 0) return 1;
            else
            {
                return n * factorial(n-1);
            }
        }

        /* Fibonacci 
            Term 1 (n = 1): F(1) = 0
            Term 2 (n = 2): F(2) = 1
            Term 3 (n = 3): F(3) = F(2) + F(1) = 1 + 0 = 1
            Term 4 (n = 4): F(4) = F(3) + F(2) = 1 + 1 = 2
            Term 5 (n = 5): F(5) = F(4) + F(3) = 2 + 1 = 3
            Here entire calculation is done during return i.3e
            if F(4) where n = 4
            in else F(3) + F(2)
                First F(3) is done where n = 3
                      in else F(2) + F(1)
                         First F(2) 
                               return is 1 --> i.e line 59 F(2) is retrived now do cal for F(1)
                         Second F(1)
                               return is 1 --> i.e line 59 both F(2) and F(1) is retrived so add and return (1+1) = 2
                Second F(2) is done where n = 2
                       directly return 1
            so now F(3) and F(2) is retrived in line 63 and 65 so add (2+1) = 3
            and at last return answer 3
         */
        public static long fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }

        public static void printFibonacciSeries(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Fibonacci series is : {fibonacci(i)}");
                var t = fibonacci(i);
            }
        }
    }
}
