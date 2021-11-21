using System;
using System.Collections.Generic;

namespace NewYearGift
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweet andy = new Candy(1, 1);
            Sweet ady = new Fruit(21, 31);
            Sweet any = new ChocolateBar(40, 71);


            Sweet[] f = {
                ady,
                any,
                andy
            };

            SweetsContiner s = new SweetsContiner(f);

            s.Sort(ParametricSorter.SortParametrs.Sugar);

            foreach (Sweet st in s.Sweets)
            {
                Console.WriteLine(st.ConcentrationSugar + " " + st.Weight);
            }
        }
    }
}
