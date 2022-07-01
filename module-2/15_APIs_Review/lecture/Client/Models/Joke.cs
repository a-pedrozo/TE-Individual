using System;
using System.Collections.Generic;
using System.Text;

namespace DadabaseApp
{
    public class Joke
    {
        public Joke(string setup, string punchline)
        {
            this.Setup = setup;
            this.PunchLine = punchline;
        }

        public string Setup { get; set; }

        public string PunchLine { get; set; }

        public int Id { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
