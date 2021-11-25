using NewYearsGift.SweetsProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.Sweets
{
    public class StuffedChocolateBar : ChocolateBar, IStuffebly
    {
        public Stuffing Stuffing { get; }

        public StuffedChocolateBar(float weight, float sugarConcentration, Stuffing stuffing)
               : base(sugarConcentration, weight)
        {
            Stuffing = stuffing;
            this.SweetName = "Stuffed chocolate bar";
        }
    }
}