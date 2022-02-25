using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    static class Class2
    {
        static public void Palendrom(this int eded)
        {
            int neweded = 0;
            int n=eded;
            while (n>0)
            {
                neweded = (neweded * 10) + n % 10;
                n = (n - n % 10) / 10;
            }
            if (eded == neweded)
            {
                Console.WriteLine("eded palendromdur");
            }
            else
                Console.WriteLine("eded palendrom deyil");
        }
                    

        



    }
}
