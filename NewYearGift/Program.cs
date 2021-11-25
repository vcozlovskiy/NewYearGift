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

            SweetsContainer<Sweet> s = new SweetsContainer<Sweet>(f);

            while (true)
            {
                Console.WriteLine("Choice what you want to do:");
                Console.WriteLine("1. Add sweets");
                Console.WriteLine("2. Take sweets");
                Console.WriteLine("3. Sort sweets by parameter");
                Console.WriteLine("4. Show all sweets");

                Console.Write(">");

                char consoleKey = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (consoleKey)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        Console.WriteLine("Your new year gift contains:");
                        foreach (Sweet sweet in s)
                        {
                            Console.WriteLine(" " + sweet.SweetName);
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Chois invalid");
                        break;
                }
            }
        }
    }
}
