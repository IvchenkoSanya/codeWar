using System;
using System.Collections.Generic;

namespace Codewars_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IList<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            var helper = new PagnationHelper<int>(collection, 10);
            Console.WriteLine(helper.PageIndex(10));
            Console.WriteLine(helper.PageIndex(24));

            Console.WriteLine();


            // pageIndex takes an item index and returns the page that it belongs on
            //should == 1 (zero based index)
            //should == 0
             //should == -1
            

            Console.ReadKey();
        }
    }
}
