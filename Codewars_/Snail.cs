using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars_
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            if (array.Length == 0 || array[0].Length == 0)
                return new int[0];
            int [] result = new int[array.Length*array.Length];
            var dir = "right";
            var imin = 0;
            var imax = array.Length - 1;
            var jmin = 0;
            var jmax = array.Length - 1;
            var k = 0;

            var i = imin;
            var j = jmin;
            var done = false;

            while (!done)
            {

                switch (dir)
                {
                    case "right":
                        i = imin;
                        for (j = jmin; j <= jmax; j++)
                            result[k++] = array[i][j];
                        dir = "down";
                        imin++;
                        break;
                    case "left":
                        i = imax;
                        for (j = jmax; j >= jmin; j--)
                            result[k++] = array[i][j];
                        dir = "up";
                        imax--;
                        break;
                    case "down":
                        j = jmax;
                        for (i = imin; i <= imax; i++)
                            result[k++] = array[i][j];
                        dir = "left";
                        jmax--;
                        break;
                    case "up":
                        i = imax;
                        j = jmin;
                        for (; i >= imin; i--)
                            result[k++] = array[i][j];
                        dir = "right";
                        jmin++;
                        break;
                }

                if (imin > imax || jmin > jmax)
                    done = true;
            }
            return result;
        }
    }
}
