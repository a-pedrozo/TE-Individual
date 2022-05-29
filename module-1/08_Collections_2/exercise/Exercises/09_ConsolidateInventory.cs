using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given two Dictionaries, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2,
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         *
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *
         * ConsolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         *
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse,
                                                            Dictionary<string, int> remoteWarehouse)
        {// will need foreach statement over dictionaries multiple  can modify existing dictionaries or create new one 
            Dictionary<string, int> combinedInventory = new Dictionary<string, int>();
            
            foreach (KeyValuePair<string, int> skuNum in mainWarehouse) // looping through mainwarehouse 
            {
                if (combinedInventory.ContainsKey(skuNum.Key))
                {
                    combinedInventory[skuNum.Key] = combinedInventory[skuNum.Key] + skuNum.Value; // updating value to combinedInventory if key exists
                }
                else
                {
                    combinedInventory[skuNum.Key] = skuNum.Value; // adding if key does not exist

                }
            }
            foreach (KeyValuePair<string, int> skuNum in remoteWarehouse) // looping through remote warehouse  
            {
                if (combinedInventory.ContainsKey(skuNum.Key))
                {
                    combinedInventory[skuNum.Key] = combinedInventory[skuNum.Key] + skuNum.Value; // same as first if statement 
                }
                else
                {
                    combinedInventory[skuNum.Key] = skuNum.Value;

                }
            }

            return combinedInventory;
        }
    }
}
