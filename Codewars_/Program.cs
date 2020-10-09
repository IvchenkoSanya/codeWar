using System;
using System.Collections.Generic;

namespace Codewars_
{
    class Program
    {
        
        static void Main(string[] args)
        {
           var str1 =  Kata.PigIt("Pig latin is cool");
            var str2 = Kata.PigIt("Hello world !");
                Console.WriteLine(str1);
                Console.WriteLine(str2);
            
            Console.ReadKey();
        }
    }
}
