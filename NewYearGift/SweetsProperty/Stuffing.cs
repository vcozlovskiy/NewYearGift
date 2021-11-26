namespace NewYearsGift.SweetsProperty
{
    public class Stuffing
    {
        public string StuffedName { get; }

        public Stuffing(StuffingEnum stuffed)
        {
            switch (stuffed)
            {
                case StuffingEnum.CondensedMilk:
                    StuffedName = "CondensedMilk";
                    break;
                case StuffingEnum.Jam:
                    StuffedName = "Jam";
                    break;
                case StuffingEnum.Syrup:
                    StuffedName = "Syrup";
                    break;
            }
        }
    }
}