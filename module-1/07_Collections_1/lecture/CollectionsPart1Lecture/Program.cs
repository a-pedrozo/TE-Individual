using System; // all operations stored
using System.Collections.Generic; // properties stored 

namespace CollectionsPart1Lecture // folder of program 
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			string[] arguments = new string[2];
			arguments[0] = "Die hard is a christmas movie";
			arguments[1] = "die hard is not a christmas movie";

			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			List<string> pizzas = new List<String>();
			pizzas.Add("chicken bacon range");
			pizzas.Add("sausage");
			pizzas.Add("mac n cheese");

			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			Console.WriteLine(pizzas[2]); // call list is same as array



			Console.WriteLine("####################");
			Console.WriteLine("Lists allow indexing");
			Console.WriteLine("####################");

			for (int i =0; i < pizzas.Count; i++) // Count == Length for Lists
            {
				Console.WriteLine(pizzas[i]); // this is how to recall all of list 
            }

			// Note: Talk about using statements here

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			foreach (string flavor in pizzas) // goes through every single variable in list 
            {
				Console.WriteLine(flavor);
            }

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			pizzas.Insert(1, "pepperoni");

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			pizzas.RemoveAt(3); // other way owuld be pizzas.Count-1

			pizzas.Remove("hawaiian"); // will remove first instance of hawaiian pizza, if not does nothing

			List<int> jerseyNumbers = new List<int>();
			jerseyNumbers.Add(6);
			jerseyNumbers.Add(9);
			jerseyNumbers.Add(420);
			jerseyNumbers.AddRange(new int[] { 12, 54, 2, 6, 69 });

			Console.WriteLine("####################");
			Console.WriteLine("Create a list using {} syntax");
			Console.WriteLine("####################");

			List<string> cities = new List<string> { "Sydny", "Ann Arbor", "Detroit", "Columbus", "Georgia", };

			Console.WriteLine(cities); // will not print out city names, must use forloop or foreach

			foreach(string cityList in cities) // how to properly use loop to print list
            {
				Console.WriteLine(cityList);
            }

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			pizzas.Add("cheese");
			pizzas.Add("cheese");

			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

			if (pizzas.Contains("hawaiian"))
            {
				Console.WriteLine("I'll pass");
            }
            else
            {
				Console.WriteLine("oh good");
            }

			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			int index = pizzas.IndexOf("pepperoni");

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] pizzaArray = pizzas.ToArray(); // creates list into an array 

			Console.WriteLine("####################");
			Console.WriteLine("Arrays can be turned into lists");
			Console.WriteLine("####################");

			int[] numbers = new int[] { 4, 8, 12 };
			List<int> numbersList = new List<int>(numbers); // one way of creating list from array

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");
			pizzas.Add("Anchovies");
			pizzas.Sort(); // will sort pizza string albaphet , int in acending order

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			pizzas.Reverse(); // will mirror flip current list ie : last becomes first and so on


			Console.WriteLine("####################");
			Console.WriteLine("Finding the smallest number in a list");
			Console.WriteLine("####################");

			List<int> ages = new List<int>(); 

			ages.Add(39);
			ages.Add(420);
			ages.Add(12);
			ages.Add(52);
			ages.Add(2);
			ages.Add(9);

			int smallestAge;


			//easy way
			ages.Sort(); // ascending order 1,2,3,4,5 etc
			smallestAge = ages[0]; // grab first item on sorted list 

			//way to do it in hw 
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

			List<string> games = new List<string> { "Twilight Struggle", "Dark Souls", "Mario Sunshine", "Halo", "Fortnite" };
			/*cannot modify list while list is looping, must create new list, DO NOT DO THIS 
			foreach (string game in games)
            {
				if (game.StartsWith("Fortnite"))
                {
					games.Remove(game);
                }
            }
			*/    // creating new list 
			List<string> filteredGames = new List<string>();
			foreach (string game in games)
            {
				if (!game.Contains("Fortnite"))
                {
					filteredGames.Add(game);
				}
				
            }

			Console.WriteLine("####################");
			Console.WriteLine("Transforming a list to another list");
			Console.WriteLine("####################"); // this will be like upcoming hw

			List<string> colors = new List<string> { "Green", "Red", "Blue" };
			List<int> colorNumbers = new List<int>();

			foreach (string color in colors) // string color in colors : colorLengths.Add(color.Length) for example 
            {
				sodaNumbers.Add(soda.Count);
            }



			Console.WriteLine("####  BREAKOUT #####");
			Console.WriteLine("Create a list of 3 strings");
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
