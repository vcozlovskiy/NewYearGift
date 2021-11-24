using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.Sweets
{
    public class Gum : Sweet
    {
        public Gum(float weaght, float sugarConcentratio)
               : base(weaght, sugarConcentratio)
        {
            this.SweetName = "Gum";
        }
    }
}