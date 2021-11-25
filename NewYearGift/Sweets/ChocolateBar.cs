using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.Sweets
{
    public class ChocolateBar : Sweet
    {
        public ChocolateBar(float weight, float sugarConcentration)
               : base(weight, sugarConcentration)
        {
            this.SweetName = "ChocolateBar";
        }
    }
}