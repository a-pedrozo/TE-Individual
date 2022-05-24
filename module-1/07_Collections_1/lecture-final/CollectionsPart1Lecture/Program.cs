using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        public static void Main(string[] args)
        {
			string[] arguments = new string[2];
			arguments[0] = "Die Hard is a Christmas movie!";
			arguments[1] = "Die Hard is NOT a Christmas movie!";

			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			List<string> pizzas = new List<string>();
			pizzas.Add("Chicken Bacon Ranch");
			pizzas.Add("Arugula Proschutto");
			pizzas.Add("Glass Shards");

			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			Console.WriteLine(pizzas[2]);

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow indexing");
			Console.WriteLine("####################");

            for (int i = 0; i < pizzas.Count; i++)
            {
				string flavor = pizzas[i];

				Console.WriteLine(flavor);
            }

			// Note: Talk about using statements here

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			foreach (string flavor in pizzas)
            {
				Console.WriteLine(flavor);
            }

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			pizzas.Insert(1, "Pepperoni");

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			pizzas.RemoveAt(3); // pizzas.Count - 1

			pizzas.RemoveAt(pizzas.Count - 1);

			pizzas.Remove("Hawaiian");

			List<int> jerseyNumbers = new List<int>();
			jerseyNumbers.Add(6);
			jerseyNumbers.Add(9);
			jerseyNumbers.Add(17);
			jerseyNumbers.AddRange(new int[] { 1, 2, 3, 4 });

			Console.WriteLine("####################");
			Console.WriteLine("Create a list using {} syntax");
			Console.WriteLine("####################");

			List<string> cities = new List<string> { "Sydney", "Ann Arbor", "Detroit", "Columbus, GA" };

			Console.WriteLine(cities); // Displays the name of the class! Not the items

			foreach (string city in cities)
            {
				Console.WriteLine(city);
            }

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			pizzas.Add("Sausage");
			pizzas.Add("Sausage");

			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

			if (pizzas.Contains("Glass Shards"))
            {
				Console.WriteLine("I'll pass");
            }
			else
            {
				Console.WriteLine("Oh good; Matt isn't cooking");
            }

			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			int index = pizzas.IndexOf("Pepperoni");

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] pizzaArray = pizzas.ToArray();

			Console.WriteLine("####################");
			Console.WriteLine("Arrays can be turned into lists");
			Console.WriteLine("####################");

			int[] numbers = new int[] { 4, 8, 12 };
			List<int> numbersList = new List<int>(numbers);

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");

			pizzas.Add("Arugula");
			pizzas.Sort();

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			pizzas.Reverse();


			Console.WriteLine("####################");
			Console.WriteLine("Finding the smallest number in a list");
			Console.WriteLine("####################");

			List<int> ages = new List<int>();
			ages.Add(39);
			ages.Add(69);
			ages.Add(3);
			ages.Add(18);
			ages.Add(52);

			int smallestAge;

			// Easy way
			ages.Sort(); // Ascending order: 1, 2, 3, 4, 5...
			smallestAge = ages[0]; // First item is the smallest since we've sorted

			smallestAge = ages[ages.Count - 1];
			foreach (int age in ages)
            {
				if (age < smallestAge)
                {
					smallestAge = age;
                }
            }

			Console.WriteLine("####################");
			Console.WriteLine("Copying and filtering to another list");
			Console.WriteLine("####################");

			List<string> games = new List<string> { "Twilight Struggle", "Dark Souls", "Pong", "Beer Pong" };

			/* DO NOT REMOVE OR ADD FROM LISTS THAT YOU ARE LOOPING OVER!!!
			foreach (string game in games)
            {
				if (game.StartsWith("Beer"))
                {
					games.Remove(game);
                }
            }
			*/

			List<string> filteredGames = new List<string>();
			foreach (string game in games)
            {
				if (!game.Contains("Beer"))
                {
					filteredGames.Add(game);
                }
            }

			Console.WriteLine("####################");
			Console.WriteLine("Transforming a list to another list");
			Console.WriteLine("####################");




			Console.WriteLine("####  BREAKOUT #####");
			Console.WriteLine("Create a list of 3 strings");

			List<string> colors = new List<string> { "Purple", "Blue", "Green" };

			List<int> colorLengths = new List<int>();
			foreach (string color in colors)
            {
				colorLengths.Add(color.Length);
            }

			Console.WriteLine("Create a list of ints containing the Length of each string from the string list");
			Console.WriteLine("#### /BREAKOUT #####");




			Console.WriteLine("####################");
			Console.WriteLine("Modifying lists while looping over them is bad");
			Console.WriteLine("####################");
			Console.WriteLine();



			Console.WriteLine("####################");
			Console.WriteLine("       STACKS");
			Console.WriteLine("####################");
			Console.WriteLine();



			Console.WriteLine("####################");
			Console.WriteLine("       QUEUES");
			Console.WriteLine("####################");
			Console.WriteLine();



		}
	}
}
