using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DadabaseApp
{
    // Matt's TODO List

    // Part 1: Create a Joke table
    // Part 2: List all jokes
    // Part 3: Insert a joke
    // Part 4: Add a Dad Table and hard-code in relationships
    // Part 5: Revise List all Jokes
    // Part 6: Discuss how we might modify Insert a Joke
    // Part 7: ???
    // Part 8: Profit!!!

    /// <summary>
    /// This class is responsible for all user input and menu code.
    /// </summary>
    public class UserInterface
    {
        private JokeDAO jokesDAO;

        public UserInterface(string connectionString)
        {
            this.jokesDAO = new JokeDAO(connectionString);
        }

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
            newJoke.SetUp = setup;
            newJoke.PunchLine = punchline;
            newJoke.DateAdded = DateTime.Now;

            int newJokeId = jokesDAO.AddJoke(newJoke);

            Console.WriteLine("joke added! its ID is " + newJokeId);
            return newJokeId;
        }
        private List<Joke> ShowAllDadJokes()
        {
            List<Joke> jokes = jokesDAO.GetAllDadJokes();

            foreach (Joke joke in jokes)
            {
                Console.WriteLine(joke);
            }
            return jokes;
        }
    }
}
