using System;
using System.Collections.Generic;
using System.Text;

namespace DadabaseApp
{
    public class Joke
    {
        public string SetUp { get; set; }
        public string PunchLine { get; set; }
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public int DadId { get; set; }
        public string DadName { get; set; }

    }
}
