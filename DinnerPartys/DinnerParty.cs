using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartys
{
    class DinnerParty:Party
    {
        public const int CostOfFoodPerPerson = 25;
       
        
        public decimal CostOfBeveragesPerPerson;
        


        
        public int NumberOfpeople {
            get
            {
                return base.NumberOfPeople;
            }
            set {
                base.NumberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }



       
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
            :base(numberOfPeople,fancyDecorations)
        {
            base.NumberOfPeople = numberOfPeople;
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
            
           
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

        //OVERLOAD IT FROM BASE CLASS
        public decimal CalculateCost(bool isChecked)
        {
            decimal totalCost = base.CalculateCost() + 
                (CostOfBeveragesPerPerson * NumberOfPeople);

            if (isChecked)
            {
                return totalCost * .95M;
            }

            else
            {
                return totalCost;
            }

        }



        //public override void CalculateCostOfDecorations(bool isExpensive)
        //{
        //    fancyDecorations = isExpensive;
        //    if (isExpensive)
        //    {
        //        CostOfDecorations = (NumberOfpeople * 15.00M) + 50M;
        //    }
        //    else
        //    {
        //        CostOfDecorations = (NumberOfpeople * 7.50M) + 30M;
        //    }
        //}


    }
}
