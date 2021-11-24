using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.Sweets
{
    public class ChocolateBar : Sweet
    {
        public ChocolateBar(float weaght, float sugarConcentratio)
               : base(weaght, sugarConcentratio)
        {
            this.SweetName = "ChocolateBar";
        }
    }
}