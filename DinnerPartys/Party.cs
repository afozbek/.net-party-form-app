using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartys
{
     public class Party
    {

        //Ortak olan özellikler...
        public Party(int numberOfPeople, bool fancyDecorations )
        {


            this.fancyDecorations = fancyDecorations;
            this.numberOfPeople = NumberOfPeople;

        }






        const int CostOfFoodPerPerson = 25; 
        public decimal CostOfDecorations = 0;
        public bool fancyDecorations;
        public int numberOfPeople;

        public virtual int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        //This method same in both class so doesnt need to virtual
        public  void CalculateCostOfDecorations(bool isExpensive)
        {
            fancyDecorations = isExpensive;
            if (isExpensive)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public virtual decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
            

            if (NumberOfPeople > 12)
            {
                TotalCost += 100M;
            }



            return TotalCost;

        }


    }
}
