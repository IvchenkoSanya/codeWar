using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars_
{
    public class Kata
    {
        public static string PigIt(string str)
        {
            #region firstAttemp

            var resStr = "";

            foreach (string item in str.Split(' '))
            {
                if (item.Length > 1)
                    resStr += item.Remove(0, 1) + item.Substring(0, 1) + "ay ";
                else
                    resStr += item + " ";
            }
            return resStr.Remove(resStr.Length-1);

            #endregion
            //return string.Join(" ", str.Split(' ').Select(x => x.Substring(1) + x.Substring(0, 1) + "ay"));
        }
    }
}
