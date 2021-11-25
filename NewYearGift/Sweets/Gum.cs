using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.Sweets
{
    public class Gum : Sweet
    {
        public Gum(float weight, float sugarConcentration)
               : base(weight, sugarConcentration)
        {
            this.SweetName = "Gum";
        }
    }
}