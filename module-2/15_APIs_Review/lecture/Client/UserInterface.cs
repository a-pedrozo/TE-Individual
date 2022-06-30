using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DadabaseApp
{
    /// <summary>
    /// This class is responsible for all user input and menu code.
    /// </summary>
    public class UserInterface
    {
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

                Console.WriteLine("1) List Dad Jokes");
                Console.WriteLine("2) Add a Dad Joke");
                Console.WriteLine("3) Get Dad Jokes by Dad");
                Console.WriteLine("4) Update a Dad Joke");
                Console.WriteLine("5) Delete a Dad Joke");
                Console.WriteLine("6) Quit");
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

                    case "3": // Get Dad Jokes by Dad
                        throw new NotImplementedException();
                        break;

                    case "4": // Update a Dad Joke
                        throw new NotImplementedException();
                        break;

                    case "5": // Delete a Dad Joke
                        throw new NotImplementedException();
                        break;

                    case "6": // Quit
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
            List<Joke> jokes = GetJokesFromServer();

            // Display all Jokes with their IDs
            foreach (Joke joke in jokes)
            {
                string jokeHeader = $"{joke.Id}) ";

                Console.WriteLine($"{jokeHeader.PadRight(5)} {joke.Setup}...");
            }

            Console.WriteLine();
            Console.WriteLine("What Joke do you want to update?");
            string jokeIdStr = Console.ReadLine();
            try
            {
                int jokeId = int.Parse(jokeIdStr);

                Joke oldJoke = null; // TODO: Get a joke by ID
                throw new NotImplementedException();

                SetJokeProperties(oldJoke);

                // TODO: Set it on the server
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Could not interpret that as a joke ID.");
            }
        }

        private int AddDadJoke()
        {
            Joke newJoke = new Joke();
            newJoke.Id = -1;
            newJoke.DateAdded = DateTime.Now;

            SetJokeProperties(newJoke);

            throw new NotImplementedException("Need to adjust this to work with an API!");
            int newJokeId = -1;// formerly: jokesDAO.AddJoke(newJoke);

            Console.WriteLine("Joke added! Its ID is " + newJokeId);

            return newJokeId;
        }

        private void SetJokeProperties(Joke newJoke)
        {
            Console.WriteLine("What is the joke's setup?");
            Console.WriteLine();
            string setup = Console.ReadLine();

            Console.WriteLine("What is the joke's punchline?");
            Console.WriteLine();
            string punchline = Console.ReadLine();

            Console.WriteLine("What dad said this?");
            Console.WriteLine();
            string dad = Console.ReadLine();

            newJoke.Setup = setup;
            newJoke.Punchline = punchline;
            newJoke.DadName = dad;
        }

        private List<Joke> ShowAllDadJokes()
        {
            List<Joke> jokes = GetJokesFromServer(); // Formerly: jokesDAO.GetAllDadJokes();

            foreach (Joke joke in jokes)
            {
                Console.WriteLine(joke.Setup);
                Console.WriteLine(joke.Punchline);
                Console.WriteLine();
            }

            return jokes;
        }

        private List<Joke> GetJokesFromServer()
        {
            throw new NotImplementedException();
        }
    }
}
