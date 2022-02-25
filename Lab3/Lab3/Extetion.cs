using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    static class Extetion
    {
       public static string Add(this string elgiz, int b)
        {
            if (b % 2 == 0)
            {
                return ($"{elgiz}s");
                
            }
            else
            {
                return elgiz;
            }
        }


    }
}
