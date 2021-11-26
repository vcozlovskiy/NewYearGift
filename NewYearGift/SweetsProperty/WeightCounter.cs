using NewYearsGift.ContinerOfSweets;
using NewYearsGift.Sweets;

namespace NewYearsGift.SweetsProperty
{
    public static class WeightCounter
    {
        public static Weight WeightAllSweets(this SweetsContainer<Sweet> sweets)
        {
            float weight = 0;

            foreach (Sweet sweet in sweets)
            {
                weight += sweet.Weight.Kilograms;
            }

            return new Weight(weight);
        } 
    }
}