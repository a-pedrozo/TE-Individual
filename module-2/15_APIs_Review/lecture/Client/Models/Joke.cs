using System;
using System.Collections.Generic;
using System.Text;

namespace DadabaseApp
{
    public class Joke
    {
        public string Setup { get; set; }

        public string Punchline { get; set; }

        public int Id { get; set; }

        public DateTime DateAdded { get; set; }

        public int DadId { get; set; } // NOTE: int? might appropriate since DadId may be null

        public string DadName { get; set; }
    }
}
