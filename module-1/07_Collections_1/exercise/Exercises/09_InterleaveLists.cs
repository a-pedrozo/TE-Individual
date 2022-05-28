using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        DIFFICULTY: HARD
        InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo) 
        {
            List<int> combinedList = new List<int>(); // new master list
            int maxCount = listOne.Count + listTwo.Count; // combining length of list 1 and 2 for master list
            int index1 = 0; // list 1 starts index0 
            int index2 = 0; // list 2 starts index0
            int oddOrEven = 0; 
            
            
            for(int i = 1; i <= maxCount; i++) // forloop offset from 0 , not odd or even
            {
                oddOrEven = i % 2;  // decides whether to pull from list 1 or 2
                if (oddOrEven == 1 && index1 <= listOne.Count - 1) // staying within list 1 bounary length 
                {
                    combinedList.Add(listOne[index1]);
                    index1 += 1;
                }
                else
                {
                    if (index2 <= listTwo.Count - 1) // determines 
                    {
                        combinedList.Add(listTwo[index2]);
                        index2 += 1;
                    }
                    else
                    {
                        combinedList.Add(listOne[index1]);
                        index1 += 1;
                    }
                }
                
              
                    

                

            }



            return combinedList;
        }
    }
}
