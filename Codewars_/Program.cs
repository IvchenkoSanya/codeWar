using System;
using System.Collections.Generic;

namespace Codewars_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var x = SortBinaryTreeByLevels.TreeByLevels(null);

            var y = SortBinaryTreeByLevels.TreeByLevels(new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1));

            foreach (var item in y)
            {
                Console.WriteLine(item);
            }





                        Console.ReadKey();
        }
    }
}
