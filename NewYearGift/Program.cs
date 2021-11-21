using System;
using System.Collections;

namespace NewYearGift
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit(10,10);
            Candy candy = new Candy(1,2);
            ChocolateBar chocolate = new ChocolateBar(4,5);

            Sweets[] f = { fruit, candy, chocolate };
            SweetsContiner continer = new SweetsContiner(f);

            Console.WriteLine(continer.WeightAllSweets());

            continer.Sweets.Sort();

        }
    }
}
