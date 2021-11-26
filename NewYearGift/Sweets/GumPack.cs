using System;
using System.Collections.Generic;
using NewYearsGift.ContinerOfSweets;

namespace NewYearsGift.Sweets
{
    public class GumPack : Sweet
    {
        private SweetsContainer<Gum> Gums { get; }

        public int NumberOfGums
        {
            get
            {
                return Gums.Count;
            }
            private set
            {

            }
        } 

        public GumPack(float weight, float sugarConcentration,
            int numberOfGums)
               : base(weight, sugarConcentration)
        {
            this.SweetName = "Pac of gum";

            List<Gum> gumList = new List<Gum>(); 
            
            for (int i = 0; i < numberOfGums; i++)
            {
                gumList.Add(new Gum(weight,sugarConcentration));
            }

            Gums = new SweetsContainer<Gum>();
            NumberOfGums = numberOfGums;
        }

        public Gum GetGum()
        {
            Gum tempGum;

            if (Gums.Count > 0)
            {
                tempGum = Gums.First();
                Gums.Remove(tempGum);

                return tempGum;
            }
            else
            {
                throw new Exception("Pack is empty");
            }
        }

        public override string ToString()
        {
            return $"{SweetName}: \n" +
                   $"Gums count - {NumberOfGums},\n" +
                   $"Sugar - {ConcentrationSugar},\n" +
                   $"Weigth - {Gums[0].Weight.Kilograms}";
        }
    }
}