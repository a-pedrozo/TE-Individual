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
        private DadJokesRestClient jokesClient = new DadJokesRestClient();
        private AuthenticationRestClient loginClient = new AuthenticationRestClient();

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

            bool shouldQuit = false;

            while (!shouldQuit)
            {
                Console.WriteLine();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine();

                if (jokesClient.HasAuthToken)
                {
                    Console.WriteLine("1) Log Out");
                }
                else
                {
                    Console.WriteLine("1) Log In");
                }

                Console.WriteLine("2) Register");
                Console.WriteLine("3) Get Dad Jokes");
                Console.WriteLine("4) Add a Dad Joke");
                Console.WriteLine("5) Update a Dad Joke");
                Console.WriteLine("6) Delete a Dad Joke");
                Console.WriteLine("7) Quit");
                Console.WriteLine();

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1": // Log In / Log Out
                        if (jokesClient.HasAuthToken)
                        {
                            LogOut();
                        } 
                        else
                        {
                            LogIn();
                        }
                        break;

                    case "2": // Register
                        Register();
                        break;

                    case "3": // List Dad Jokes
                        ShowAllDadJokes();
                        break;

                    case "4": // Add a Dad Joke
                        AddDadJoke();
                        break;

                    case "5": // Update a Dad Joke
                        UpdateDadJoke();
                        break;

                    case "6": // Delete a Dad Joke
                        DeleteDadJoke();
                        break;

                    case "7": // Quit
                        shouldQuit = true;
                        Console.WriteLine("Have fun telling dad jokes!");
                        break;

                    default:
                        Console.WriteLine("That's not a thing. Go think about what you did.");
                        break;
                }
            }
        }


        private void Register()
        {
            Console.WriteLine("What is your username?");
            string username = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("What is your password?");
            string password = Console.ReadLine();

            Console.WriteLine();

            if (loginClient.Register(username, password))
            {
                Console.WriteLine("You are now registered. Please log in using the new user to access all features.");
            }
            else
            {
                Console.WriteLine("Unable to register a new user");
            }
        }


        private void LogIn()
        {
            Console.WriteLine("What is your username?");
            string username = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("What is your password?");
            string password = Console.ReadLine();

            Console.WriteLine();

            UserInfo loggedInUser = loginClient.Login(username, password);

            if (loggedInUser == null)
            {
                Console.WriteLine("Could not log in");
            }
            else
            {
                string jwt = loggedInUser.Token;

                Console.WriteLine("Successfully logged in with JWT of " + jwt);

                // TODO: tell the jokesClient we're authenticated with a valid JWT
            }
        }

        private void LogOut()
        {
            // TODO: tell the jokesClient we're no longer authenticated
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

                Joke oldJoke = jokesClient.GetJokeById(jokeId);

                if (oldJoke == null)
                {
                    Console.WriteLine("Could not update the joke.");
                    return;
                }

                SetJokeProperties(oldJoke);

                Joke newJoke = jokesClient.UpdateJoke(oldJoke);

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
            List<Joke> jokes = jokesClient.GetAllJokes();

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

                bool deleted = jokesClient.DeleteJokeById(jokeId);

                if (deleted)
                {
                    Console.WriteLine("Boom! Roasted!");
                }
                else 
                {
                    Console.WriteLine("Could not delete the joke.");
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

            newJoke = jokesClient.CreateJoke(newJoke);

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
            List<Joke> jokes = jokesClient.GetAllJokes();

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
