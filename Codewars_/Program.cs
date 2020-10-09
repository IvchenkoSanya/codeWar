using System;
using System.Collections.Generic;

namespace Codewars_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[][] array =
                            {
                               new []{1, 2, 3},
                               new []{4, 5, 6},
                               new []{7, 8, 9}
                           };
            var x = SnailSolution.Snail(array);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
