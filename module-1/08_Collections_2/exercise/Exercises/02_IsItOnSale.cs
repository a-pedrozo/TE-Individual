﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given a string item number (a.k.a. SKU), return the discount percentage if the item is on sale.
         * If the item is not on sale, return 0.00.
         *
         * If the item number is empty or null, return 0.00.
         *
         * "KITCHEN4001" -> 0.20
         * "GARAGE1070" -> 0.15
         * "LIVINGROOM"	-> 0.10
         * "KITCHEN6073" -> 0.40
         * "BEDROOM3434" -> 0.60
         * "BATH0073" -> 0.15
         *
         * The item number should be case insensitive so "kitchen4001", "Kitchen4001", and "KITCHEN4001"
         * should all return 0.20.
         *
         * IsItOnSale("kitchen4001") → 0.20
         * IsItOnSale("") → 0.00
         * IsItOnSale("GARAGE1070") → 0.15
         * IsItOnSale("dungeon9999") → 0.00   
         *
         */
        public double IsItOnSale(string itemNumber)
        {
            Dictionary<string, double> discountItem = new Dictionary<string, double>();
            discountItem["KITCHEN4001"] = 0.20;
            discountItem["GARAGE1070"] = 0.15;
            discountItem["LIVINGROOM"] = 0.10;
            discountItem["KITCHEN6073"] = 0.40;
            discountItem["BEDROOM3434"] = 0.60;
            discountItem["BATH0073"] = 0.15;

            if (itemNumber == "" || itemNumber == null)
            {
                return 0.00;
            }

            else
            {
                if (discountItem.ContainsKey(itemNumber.ToUpper()))
                {
                    return discountItem[itemNumber.ToUpper()];

                }
                else
                {
                     return 0.00;
                }

            }
                  

        }
    }
}
