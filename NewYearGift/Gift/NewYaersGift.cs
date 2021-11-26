using NewYearsGift.ContinerOfSweets;
using NewYearsGift.Sweets;

namespace NewYearsGift.Gift
{
    public class NewYaersGift
    {
        public SweetsContainer<Sweet> Sweets { get; }

        public NewYaersGift(SweetsContainer<Sweet> sweets)
        {
            Sweets = sweets;
        }
    }
}