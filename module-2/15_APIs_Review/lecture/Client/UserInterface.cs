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
                Console.WriteLine("4) Quit");
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

                    case "4": // Quit
                        shouldQuit = true;
                        Console.WriteLine("Have fun telling dad jokes!");
                        break;

                    default:
                        Console.WriteLine("That's not a thing. Go think about what you did.");
                        break;
                }
            }
        }

        private int AddDadJoke()
        {
            Console.WriteLine("What is the joke's setup?");
            Console.WriteLine();
            string setup = Console.ReadLine();

            Console.WriteLine("What is the joke's punchline?");
            Console.WriteLine();
            string punchline = Console.ReadLine();

            Joke newJoke = new Joke();
            newJoke.Setup = setup;
            newJoke.Punchline = punchline;
            newJoke.Id = -1;
            newJoke.DateAdded = DateTime.Now;

            throw new NotImplementedException("Need to adjust this to work with an API!");
            int newJokeId = -1;// formerly: jokesDAO.AddJoke(newJoke);

            Console.WriteLine("Joke added! Its ID is " + newJokeId);

            return newJokeId;
        }

        private List<Joke> ShowAllDadJokes()
        {
            List<Joke> jokes = new List<Joke>(); // Formerly: jokesDAO.GetAllDadJokes();

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
