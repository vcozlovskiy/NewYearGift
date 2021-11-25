using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.Sweets
{
    public class Candy : Sweet
    {
        public Candy(float weight, float sugarConcentration) 
            : base(weight, sugarConcentration)
        {
            this.SweetName = "Candy";
        }
    }
}