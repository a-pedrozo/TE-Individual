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
			emails.Add("vinny@techelevator.com");
			emails.Add("matt.eland@techelevator.com");

			// Removing from hash sets

			// Checking if something is in a hash set
			if (emails.Contains("john@techelevator.com"))
            {
				Console.WriteLine("John is getting spam today!");
            }

			// Looping over a hash set (you won't do this too much)
		}

		private void DictionarySportsJerseyExample()
		{
			// Declaring and initializing a Dictionary of Jersey numbers and sports players
			Dictionary<int, string> players = new Dictionary<int, string>();

			// Adding an item to a Dictionary
			players[43] = "Jimothy";
			players[26] = "Hamothy Yeah Sure Yeah";
			players[23] = "Jimothy";

			// Retrieving an item from a Dictionary by its key
			string playerName = players[26];
			Console.WriteLine("The team thinks the player to blame is " + playerName);

			// Updating an item in a Dictionary
			players[26] = "A-Aron";

			// Check to see if a key already exists
			if (players.ContainsKey(43))
            {
				Console.WriteLine("We have a player 43:" + players[43]);
            }

			// Remove an element from the Dictionary
			players.Remove(23);
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

			foreach (bool isHeads in coinFlipsThatAreHeads)
            {
				// Have we seen this coin value before?
				if (flipCount.ContainsKey(isHeads))
				{
					// We've seen it before! Increase its count by 1
					flipCount[isHeads] = flipCount[isHeads] + 1;
				}
				else
                {
					// This is the first time we've seen this coin value, Start it off at 1
					flipCount[isHeads] = 1;
                }
            }

			Console.WriteLine("There were " + flipCount[true] + " heads");
			Console.WriteLine("There were " + flipCount[false] + " tails");
		}

		private void DictionaryItemPricesExample()
		{
			// Declaring and initializing a Dictionary (one-line version)
			Dictionary<string, double> itemPrices = new Dictionary<string, double>
			{
				{ "Diet Doctor Pepper", 3.50 },
				{ "Monster", 399.99 },
				{ "Taquitos", 12 }
			};
			itemPrices["Yogurt"] = 8.2;

			// Iterate through the keys and key-value pairs in the Dictionary (You will RARELY do this)
			double total = 0;
			foreach (KeyValuePair<string, double> kvp in itemPrices)
            {
				Console.WriteLine(kvp.Key + ": " + kvp.Value);
				total += kvp.Value;
            }

			Console.WriteLine(total);
		}

		private void UsernamePasswordExample()
		{
			Dictionary<string, string> passwords = new Dictionary<string, string>();
			passwords["MELAND"] = "FuzzyBunny"; // Super secure!
			passwords["DAN"] = "Finger Guns";
			passwords["JOHN"] = "Killer!";

			Console.WriteLine("What's your username?");
			string username = Console.ReadLine();
			username = username.ToUpper();

			Console.WriteLine("What's your password?");
			string password = Console.ReadLine();

			// Are they a registered user?
			if (passwords.ContainsKey(username))
            {
				string actualPassword = passwords[username];
				if (actualPassword == password)
                {
					Console.WriteLine("Welcome to the system!");
                } 
				else
                {
					Console.WriteLine("Invalid Username or Password");
                }
            }
			else
            {
				Console.WriteLine("Invalid Username or Password");
            }

		}
	}
}
