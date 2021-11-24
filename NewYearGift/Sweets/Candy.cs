using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.Sweets
{
    public class Candy : Sweet
    {
        public Candy(float weaght, float sugarConcentratio) 
            : base(weaght, sugarConcentratio)
        {
            this.SweetName = "Candy";
        }
    }
}