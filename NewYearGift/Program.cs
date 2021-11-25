using System;
using NewYearsGift.SortingParametersEnum;
using System.Collections.Generic;
using NewYearsGift.Sweets;
using NewYearsGift.ContinerOfSweets;

namespace NewYearsGift
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweet andy = new Candy(1, 1);
            Sweet any = new ChocolateBar(40, 71);


            Sweet[] f = {
                any,
                andy
            };

            SweetsContainer s = new SweetsContainer(f);

            s.Sort(SortParametrs.Sugar);

            foreach (Sweet st in s.Sweets)
            {
                Console.WriteLine(st);
            }
        }
    }
}
