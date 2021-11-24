using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearsGift.Sweets
{
    public class Cookie : Sweet
    {
        public Cookie(float weight, float sugarConcentration)
            : base(sugarConcentration, weight)
        {
            this.SweetName = "Cookie";
        }
    }
}
