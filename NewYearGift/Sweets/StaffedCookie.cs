using NewYearsGift.Sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.Sweets
{
    public class StaffedCookie : Cookie, IStuffebly
    {
        public StaffedCookie(float weight, float sugarConcentration)
               : base(sugarConcentration, weight)
        {
            this.SweetName = "Staffed cookie";
        }
    }
}