using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using DadabaseClient.ApiClients;
using DadabaseApp.Models;

namespace DadabaseApp
{
    /// <summary>
    /// This class is responsible for all user input and menu code.
    /// </summary>
    public class UserInterface
    {
        private DadJokesRestClient apiClient = new DadJokesRestClient();

        /// <summary>
        /// Lists main menu options for the user.
        /// </summary>
        public void ShowMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Matt's \"Dad-a-base\"!");
            Console.WriteLine();
            Console.WriteLine("Get it? It's funny because it\'s a database of dad jokes.");
            Console.WriteLine("You\'ll laugh later.");
            Console.WriteLine();

            bool shouldQuit = false;

            while (!shouldQuit)
            {

                Console.WriteLine("What do you want to do?");
                Console.WriteLine();

                Console.WriteLine("1) Get Dad Jokes");
                Console.WriteLine("2) Add a Dad Joke");
                Console.WriteLine("3) Update a Dad Joke");
                Console.WriteLine("4) Delete a Dad Joke");
                Console.WriteLine("5) Quit");
                Console.WriteLine();

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1": // List Dad Jokes
                        ShowAllDadJokes();
                        break;

                    case "2": // Add a Dad Joke
                        AddDadJoke();
                        break;

                    case "3": // Update a Dad Joke
                        UpdateDadJoke();
                        break;

                    case "4": // Delete a Dad Joke
                        DeleteDadJoke();
                        break;

                    case "5": // Quit
                        shouldQuit = true;
                        Console.WriteLine("Have fun telling dad jokes!");
                        break;

                    default:
                        Console.WriteLine("That's not a thing. Go think about what you did.");
                        break;
                }
            }
        }

        private void UpdateDadJoke()
        {
            DisplayJokesWithIds();

            Console.WriteLine();
            Console.WriteLine("What Joke do you want to update?");
            string jokeIdStr = Console.ReadLine();
            try
            {
                int jokeId = int.Parse(jokeIdStr);

                Joke oldJoke = apiClient.GetJokeById(jokeId);

                if (oldJoke == null)
                {
                    Console.WriteLine("That joke could not be found.");
                    return;
                }

                SetJokeProperties(oldJoke);

                Joke newJoke = apiClient.UpdateJoke(oldJoke);

                if (newJoke == null)
                {
                    Console.WriteLine("The Joke could not be updated.");
                }
                else
                {
                    Console.WriteLine("Joke updated!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Could not interpret that as a joke ID.");
            }
        }

        private void DisplayJokesWithIds()
        {
            List<Joke> jokes = apiClient.GetAllJokes();

            // Display all Jokes with their IDs
            foreach (Joke joke in jokes)
            {
                string jokeHeader = $"{joke.Id}) ";

                Console.WriteLine($"{jokeHeader.PadRight(5)} {joke.Setup}...");
            }
        }

        private void DeleteDadJoke()
        {
            DisplayJokesWithIds();

            Console.WriteLine();
            Console.WriteLine("What Joke do you want to delete?");
            string jokeIdStr = Console.ReadLine();
            try
            {
                int jokeId = int.Parse(jokeIdStr);

                bool deleted = apiClient.DeleteJokeById(jokeId);

                if (deleted)
                {
                    Console.WriteLine("Boom! Roasted!");
                }
                else 
                {
                    Console.WriteLine("That joke could not be found.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Could not interpret that as a joke ID.");
            }
        }

        private Joke AddDadJoke()
        {
            Joke newJoke = new Joke("", "");
            newJoke.Id = -1;
            newJoke.DateAdded = DateTime.Now;

            SetJokeProperties(newJoke);

            newJoke = apiClient.CreateJoke(newJoke);

            if (newJoke == null)
            {
                Console.WriteLine("The joke could not be created");
            }
            else
            {
                Console.WriteLine("Joke added! Its ID is " + newJoke.Id);
            }

            return newJoke;
        }

        private void SetJokeProperties(Joke newJoke)
        {
            Console.WriteLine("What is the joke's setup?");
            string setup = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the joke's punchline?");
            string punchline = Console.ReadLine();
            Console.WriteLine();

            newJoke.Setup = setup;
            newJoke.Punchline = punchline;
        }

        private List<Joke> ShowAllDadJokes()
        {
            List<Joke> jokes = apiClient.GetAllJokes();

            foreach (Joke joke in jokes)
            {
                Console.WriteLine(joke.Setup);
                Console.WriteLine(joke.Punchline);
                Console.WriteLine();
            }

            return jokes;
        }

    }
}
