using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartys
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public decimal priceAll;
        public bool healty;
        
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;
        private int numberOfpeople;
        public int NumberOfpeople {
            get { return numberOfpeople; }
            set {
                numberOfpeople = value;
                CalculateCostOfDecorations(fancyDecorations);


            }
        }
        private bool fancyDecorations;
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfpeople = numberOfPeople;
            SetHealthyOption(healthyOption);
            this.fancyDecorations = fancyDecorations;
           
        }
            public void SetHealthyOption(bool isHealty)
         {
            if (isHealty)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }
        

      


        public void CalculateCostOfDecorations(bool isExpensive)
        {
            fancyDecorations = isExpensive;
            if (isExpensive)
            {
                CostOfDecorations = (NumberOfpeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfpeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool isChecked)
        {
            decimal totalCost = CostOfDecorations + 
                ((CostOfBeveragesPerPerson +
                CostOfFoodPerPerson) * NumberOfpeople);

            if (isChecked)
            {
                return totalCost * .95M;
            }

            else
            {
                return totalCost;
            }
            
        }
    }
}
