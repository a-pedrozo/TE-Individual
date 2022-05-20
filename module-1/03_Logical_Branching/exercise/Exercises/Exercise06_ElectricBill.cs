using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.Exercises.LogicalBranching
{
    /*
     * Tech Electric is an energy provider with a simple pricing model:
     *     The first 100 units are $0.20 per unit.
     *     Anything more than 100 units is $0.25 per unit.
     *     
     * The following problems have you calculate a customer's total for their energy usage.
     */
    public class ElectricBill
    {
        // You can use these constants in your solutions.
        private const double BaseRate = 0.20;
        private const double ExcessRate = 0.25;
        private const double ExcessUnitsLimit = 100.0;
        private const double DiscountFactor = 0.95;

        /*
         * Implement the logic to calculate what a customer owes for the units they've used.
         *
         * calculateElectricBill(50) ➔ 10.0
         * calculateElectricBill(63.7) ➔ 12.74
         * calculateElectricBill(110) ➔ 22.5
         */
        public double CalculateElectricBill(double unitsUsed)
        {
            if (unitsUsed <= ExcessUnitsLimit)
            {
                return BaseRate * unitsUsed;
            }
            if (unitsUsed > ExcessUnitsLimit)
            {
                return (ExcessUnitsLimit * BaseRate) + ((unitsUsed -ExcessUnitsLimit) * ExcessRate);
            }
            else
                return BaseRate * unitsUsed;
        }  
        

        /*
         * Tech Electric realized some of their customers have renewable energy like solar panels.
         * To reward those customers, they'll give them 5% off their bill.
         * Using the same rates, implement the logic to calculate what a customer owes for the units
         * they've used and if they have renewable energy.
         *
         * calculateElectricBill(50, false) ➔ 10.0
         * calculateElectricBill(50, true) ➔ 9.5
         * calculateElectricBill(110, true) ➔ 21.375
         */
        public double CalculateElectricBill(double unitsUsed, bool hasRenewableEnergy)
        {
            if (unitsUsed <= ExcessUnitsLimit)
            {
                if (hasRenewableEnergy == true)
                {
                    return BaseRate * unitsUsed * DiscountFactor;
                }
                else 
                    return BaseRate * unitsUsed;
            }
            if (unitsUsed > ExcessUnitsLimit)
            {
                if (hasRenewableEnergy == true)
                {
                    return ((ExcessUnitsLimit * BaseRate) + ((unitsUsed - ExcessUnitsLimit) * ExcessRate)) * DiscountFactor;
                }
                else
                    return (ExcessUnitsLimit * BaseRate) + ((unitsUsed - ExcessUnitsLimit) * ExcessRate);
            }
            else
                return BaseRate * unitsUsed;
        }

        /*
         * Customers with renewable energy can put electricity back into the grid. Each
         * customer's net usage (units used - units returned) is calculated so that Tech
         * Electric can determine what discounts to apply and whether the customer should
         * receive money back.
         * 
         * - The first 100 units are $0.20 per unit.
         * - Anything more than 100 units is calculated at a cost of $0.25 per unit.
         * - Any customer who puts electricity back into the grid receives a 5% discount.
         * - If a customer returns more energy than they've used, they receive a credit of
         *   $0.20 per unit for each returned unit. Their credit does not include the 5% discount.
         *
         * Implement the logic to calculate a customer's bill when provided with a number of units
         * used and units returned.
         *
         * calculateElectricBill(50, 0) ➔ 10.0
         * calculateElectricBill(50, 4) ➔ 8.74
         * calculateElectricBill(50, 60) ➔ -2.0
         * calculateElectricBill(110, 6) ➔ 19.95
         * calculateElectricBill(110, 20) ➔ 17.1
         * calculateElectricBill(110, 120) ➔ -2.0
         */
        public double CalculateElectricBill(double unitsUsed, double unitsReturned)
        {   double costUnder100Units = BaseRate * unitsUsed;
            double costOver100Units = (unitsUsed - ExcessUnitsLimit) * ExcessRate + (ExcessUnitsLimit * BaseRate);

            if (unitsReturned > unitsUsed) //applied credit 
            {
                return BaseRate * unitsReturned;
            }
            else if (unitsUsed > ExcessUnitsLimit)
            {
                return costOver100Units * DiscountFactor;
            }
            else
                return costUnder100Units * DiscountFactor;


            
        }
    }
}
