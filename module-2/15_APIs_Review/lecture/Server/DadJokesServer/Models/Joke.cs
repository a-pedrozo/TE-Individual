using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DadJokesServer.Models
{
    public class Joke
    {
        [Required]
        [StringLength(255)]
        public string Setup { get; set; }
        [Required]
        [StringLength(255)]
        public string Punchline { get; set; }

        public int Id { get; set; }

        public DateTime DateAdded { get; set; }

        public string DadName { get; set; }

        public int? DadId { get; set; }
    }
}
