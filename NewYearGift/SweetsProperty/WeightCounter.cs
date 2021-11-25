using NewYearsGift.ContinerOfSweets;
using NewYearsGift.Sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.SweetsProperty
{
    public static class WeightCounter
    {
        public static Weight WeightAllSweets(this SweetsContainer sweets)
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