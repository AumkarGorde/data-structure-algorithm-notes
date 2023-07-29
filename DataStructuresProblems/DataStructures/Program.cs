using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayReverse = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            ReverseArray.ReverseLogicOne(arrayReverse);
            ReverseArray.ReverseLogicTwo(arrayReverse);
            Console.ReadKey();
        }
    }
}
