using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars_
{
    class ROT13
    {
        public static string Rot13(string input)
        {
            char[] tmp = input.ToCharArray();
            for (int i = 0; i < tmp.Length; i++)
            {
                int number = (int)tmp[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                        number -= 13;
                    else
                        number += 13;
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                        number -= 13;
                    else
                        number += 13;
                }
                tmp[i] = (char)number;
            }
            return new string(tmp);
        }
    }
}
