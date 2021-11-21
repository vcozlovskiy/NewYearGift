using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public class Fruit : Sweet
    {
        public Fruit(float weight, float sugarConcentration) 
            : base(sugarConcentration, weight)
        {

        }
    }
}