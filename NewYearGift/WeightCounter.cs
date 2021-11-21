using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public static class WeightCounter
    {
        public static Weight WeightAllSweets(this SweetsContiner sweets)
        {
            float weight = 0;

            foreach (Sweet sweet in sweets)
            {
                weight += sweet.Weight.Kilogramms;
            }

            return new Weight(weight);
        } 
    }
}