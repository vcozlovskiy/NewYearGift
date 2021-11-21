using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public class Fruit : Sweets
    {
        public Fruit(float weight, float sugarConcentration) 
            : base(sugarConcentration, weight)
        {

        }
    }
}