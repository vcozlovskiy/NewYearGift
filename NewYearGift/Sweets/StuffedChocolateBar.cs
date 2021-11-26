using NewYearsGift.SweetsProperty;

namespace NewYearsGift.Sweets
{
    public class StuffedChocolateBar : ChocolateBar, IStuffebly
    {
        public Stuffing Stuffing { get; }

        public StuffedChocolateBar(float weight, float sugarConcentration, StuffingEnum stuffing)
               : base(sugarConcentration, weight)
        {
            Stuffing = new Stuffing(stuffing);
            this.SweetName = "Stuffed chocolate bar";
        }
    }
}