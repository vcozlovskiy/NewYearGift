using NewYearsGift.Gift;
using NewYearsGift.Sweets;
using NewYearsGift.SweetsProperty;
using NewYearsGift.SortingParametersEnum;
using System;


namespace NewYearsGift.ConsoleInteractionWithGift
{
    public class InteractionWithGift
    {
        private NewYaersGift newYaersGift;
        public InteractionWithGift(NewYaersGift newYaersGift)
        {
            this.newYaersGift = newYaersGift;
        }


        public void StartInteractionWithGift()
        {
            while (true)
            {
                MenuGiftShow();
                ProcessUserChoice();
            }
        }

        private void MenuGiftShow()
        {
            Console.WriteLine();
            Console.WriteLine("Gift menu: \n" +
                                "Choice what you want to do: \n" +
                                "1. Add sweets\n" +
                                "2. Take sweets\n" +
                                "3. Sort sweets by parameter\n" +
                                "4. Show all sweets");
            Console.Write(">");
        }

        private void ProcessUserChoice()
        {
            char consoleKey = Console.ReadKey().KeyChar;
            Console.Clear();

            switch (consoleKey)
            {
                case '1':
                    AddSweets();
                    break;
                case '2':
                    TakeSweets();
                    break;
                case '3':
                    SortByParameter();
                    break;
                case '4':
                    SweetsShow();
                    break;
                default:
                    Console.WriteLine("Choice invalid");
                    break;
            }
        }

        private void AddSweets()
        {
            Console.WriteLine("Choose what you want to add:");
            string[] ItemList =
            {
                "Candy",
                "Chocolate bar",
                "Cookie",
                "Gum",
                "Gum pack",
                "Stuffed cookie",
                "Stuffed chocolate bar",
            };

            int i = 0;
            foreach (string sweet in ItemList)
            {
                Console.WriteLine($"{++i}. {sweet}");
            }

            Console.Write(">");

            int.TryParse(Console.ReadLine(), out int choice);
            AddSweetToSweets((SweetsEnum)(choice - 1));
        }

        private void TakeSweets()
        {
            SweetsShow();

            int choice = (int)Console.ReadKey().KeyChar - 49;
            Console.WriteLine();
            if (choice <= newYaersGift.Sweets.Count && choice >= 0)
            {
                Console.WriteLine($"{newYaersGift.Sweets[choice].SweetName} removed from gift");
                newYaersGift.Sweets.Remove(newYaersGift.Sweets[choice]);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }

        private void SweetsShow()
        {
            Console.WriteLine("Your new year gift contains:");
            foreach (Sweet sweet in newYaersGift.Sweets)
            {
                Console.WriteLine($"{newYaersGift.Sweets.IndexOf(sweet) + 1}. {sweet.SweetName}");
            }
            Console.Write(">");
        }

        private void AddSweetToSweets(SweetsEnum sweets)
        {
            Sweet sweet;
            (float, float) weigthAndSugar = GetWeigthAndSugar();


            switch (sweets)
            {
                case SweetsEnum.Candy:
                    sweet = new Candy(weigthAndSugar.Item1, weigthAndSugar.Item2);
                    break;
                case SweetsEnum.ChocolateBar:
                    sweet = new ChocolateBar(weigthAndSugar.Item1, weigthAndSugar.Item2);
                    break;
                case SweetsEnum.Cookie:
                    sweet = new Cookie(weigthAndSugar.Item1, weigthAndSugar.Item2);
                    break;
                case SweetsEnum.Gum:
                    sweet = new Gum(weigthAndSugar.Item1, weigthAndSugar.Item2);
                    break;
                case SweetsEnum.GumPack:
                    sweet = new GumPack(weigthAndSugar.Item1, weigthAndSugar.Item2, 10);
                    break;
                case SweetsEnum.StuffedChocolateBar:
                    sweet = new StuffedChocolateBar(weigthAndSugar.Item1, weigthAndSugar.Item2, GetStuffing());
                    break;
                case SweetsEnum.StuffedCookie:
                    sweet = new StuffedCookie(weigthAndSugar.Item1, weigthAndSugar.Item2, GetStuffing());
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }

            newYaersGift.Sweets.Add(sweet);
            Console.WriteLine($"{newYaersGift.Sweets.Last().SweetName} addet to gift.");
        }

        private (float, float) GetWeigthAndSugar()
        {
            Console.Write("Enter weigth:");
            float.TryParse(Console.ReadLine(), out float weigth);
            Console.Write("Enter sugar concentration:");
            float.TryParse(Console.ReadLine(), out float sugar);

            return (weigth, sugar);
        }

        private StuffingEnum GetStuffing()
        {
            int stuffing;
            Console.WriteLine("Choice stuffing:\n" +
                              "1. Jam\n" +
                              "2. Condenset milk\n" +
                              "3. Syrup\n");
            int.TryParse(Console.ReadLine(), out stuffing);

            while (stuffing > 2 || stuffing < 0)
            {
                Console.WriteLine("Invalid choice, try again");
                int.TryParse(Console.ReadLine(), out stuffing);
            }

            return (StuffingEnum)stuffing;
        }

        private void SortByParameter()
        {
            Console.WriteLine("Choice parameter:\n" +
                              "1. Shugar\n" +
                              "2. Weigth");
            Console.Write(">");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= 1)
            {
                newYaersGift.Sweets.Sort((SortParameters)choice);
                Console.WriteLine("Sorting done");
            }
            else
            {
                Console.WriteLine("Invalid parameter");
            }
        }
    }
}
