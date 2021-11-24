using NewYearsGift.SweetsProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.Sweets
{
    public class StaffedChocolateBar : ChocolateBar, IStuffebly
    {
        public Stuffing Stuffing { get; }

        public StaffedChocolateBar(float weight, float sugarConcentration, Stuffing stuffing)
               : base(sugarConcentration, weight)
        {
            Stuffing = stuffing;
            this.SweetName = "Staffed chocolate bar";
        }
    }
}