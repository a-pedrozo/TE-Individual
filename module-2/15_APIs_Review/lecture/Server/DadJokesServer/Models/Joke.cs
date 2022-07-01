using System;
using System.Collections.Generic;
using System.Text;

namespace DadJokesServer.Models
{
    public class Joke
    {
        public string Setup { get; set; }

        public string Punchline { get; set; }

        public int Id { get; set; }

        public DateTime DateAdded { get; set; }

        public string DadName { get; set; }

        public int? DadId { get; set; }
    }
}
