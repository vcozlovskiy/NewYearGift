using NewYearsGift.Sweets;
using NewYearsGift.ContinerOfSweets;
using NewYearsGift.Gift;
using NewYearsGift.ConsoleInteractionWithGift;

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

            NewYaersGift newYaersGift = new NewYaersGift(s);

            InteractionWithGift interaction = new InteractionWithGift(newYaersGift);

            interaction.StartInteractionWithGift();
        }
    }
}
