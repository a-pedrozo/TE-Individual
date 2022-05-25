using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsPart2Lecture
{
    public class LectureCode
    {
		public void Start()
		{
			// ----------------------------------------
			// HashSets
			// ----------------------------------------
			HashSetEmailListExamples();
			//hashset dont allow dupicates but looks lot like list 


			// ----------------------------------------
			// Dictionaries
			// ----------------------------------------
			DictionarySportsJerseyExample();

			// ----------------------------------------
			// Example Program: Count the number of times a coin flips heads or tails
			// ----------------------------------------
			DictionaryCoinFlipExample();

			// ----------------------------------------
			// Less Common Cases with Dictionaries
			// ----------------------------------------
			DictionaryItemPricesExample();

			// ----------------------------------------
			// Example Program: Check to see if a username and password match
			// ----------------------------------------
			UsernamePasswordExample();
		}


		private void HashSetEmailListExamples()
		{
			// Declaring a hash set for tracking E-Mail addresses
			HashSet<string> emails = new HashSet<string>();


			// Adding to hash sets
			emails.Add("matt.eland@techelevator.com");
			emails.Add("john@techelevator.com");
			emails.Add("vinney@techelevator.com");
			emails.Add("matt.eland@techelevator.com");
            // Removing from hash sets

            // Checking if something is in a hash set
            if (emails.Contains("john@techelevator.com"))
            {
				Console.WriteLine("john is getting spam today");
            }

			// Looping over a hash set (you won't do this too much)
		}

		private void DictionarySportsJerseyExample()
		{
			// Declaring and initializing a Dictionary of Jersey numbers and sports players 
			Dictionary<int, string> players = new Dictionary<int, string>(); // creates new dictionary empty, int is key, string is value


			// Adding an item to a Dictionary keys must be different but values can be the same
			players[43] = "Jimothey";
			players[420] = "jaquellen";
			players[12] = "tom brady";
			players[76] = "the gronk";
			players[39] = "im dave";
			// Retrieving an item from a Dictionary by its key
			string playerName = players[76]; // declaring new variable and assigning the value by the dictionary key 
			Console.WriteLine("the team need to fire " + playerName);

			// Updating an item in a Dictionary /don't use .add for adding/updating dictionary 
			players[12] = "A-Aron";
            // Check to see if a key already exists
            if (players.ContainsKey(12))
            {
				Console.WriteLine("we have player 12 " + players[12]);
            }
			players.Remove(43);
			// Remove an element from the Dictionary
		}		


		private void DictionaryCoinFlipExample()
		{
			// Flip a coin some number of times
			Random random = new Random();
			List<bool> coinFlipsThatAreHeads = new List<bool>();

			const int timesToFlip = 10;

			for (int i = 0; i < timesToFlip; i++)
            {
				int coinValue = random.Next(0, 2); // Will be either 0 or 1
				bool isHeads = (coinValue == 0); 

				coinFlipsThatAreHeads.Add(isHeads);
            }

			// Track the number of coin flips into a dictionary
			Dictionary<bool, int> flipCount = new Dictionary<bool, int>();
			foreach (bool isHeads in coinFlipsThatAreHeads) // foreach(variable type, variable name in list name)
			{   // have we seen this coin value before?
				if (flipCount.ContainsKey(isHeads))
                {    // we've seen it before, increase its count by 1
					flipCount[isHeads] = flipCount[isHeads] + 1;

                }
				else
                {  // this is the first time we've seen this coin value, start it off at 1
					flipCount[isHeads] = 1;
                }
            }
		}	 

		private void DictionaryItemPricesExample()
		{     // alternate way of adding values to dictionary 
			Dictionary<string, double> itemPrices = new Dictionary<string, double>
            {
				{ "diet dr pepper", 3.50 },
				{ "monster", 399.99 },
				{ "taquitos", 12},
            };
			itemPrices["yogurt"] = 8.25; // most common way to add to dictionary 

			// Declaring and initializing a Dictionary (one-line version)
			double total = 0;
			foreach (KeyValuePair<string, double> kvp in itemPrices)
            {
				Console.WriteLine(kvp.Key + ": " + kvp.Value);
				total += kvp.Value;
				
            }
			Console.WriteLine(total);

			// Iterate through the keys and key-value pairs in the Dictionary (You will RARELY do this)
		}


		private void UsernamePasswordExample()
		{

		}
	}
}
