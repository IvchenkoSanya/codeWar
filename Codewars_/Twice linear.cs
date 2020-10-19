using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars_
{
    public class DoubleLinear
    {
        public static int DblLinear(int n)
        {
            int x1 = 0;
            int x2 = 0;

            List<int> doubleLeaner = new List<int>() { 1 };

            for (int i = 0; i < n; i++)
            {
                if (X(doubleLeaner[x1]) < Y(doubleLeaner[x2]))
                {
                    doubleLeaner.Add(X(doubleLeaner[x1]));
                    x1++;
                }
                else if (X(doubleLeaner[x1]) > Y(doubleLeaner[x2]))
                {
                    doubleLeaner.Add(Y(doubleLeaner[x2]));
                    x2++;
                }
                else
                {
                    x1++;
                    i--;
                }
            }
            return doubleLeaner[n];
        }

        public static int X (int x) => 2 * x + 1;
        public static int Y (int x) => 3 * x + 1;
    }
}
