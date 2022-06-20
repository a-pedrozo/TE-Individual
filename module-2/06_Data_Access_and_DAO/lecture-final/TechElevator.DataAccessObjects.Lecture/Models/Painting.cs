using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.DataAccess.Models
{
    public class Painting
    {
        // This maps to painting_id in the database
        public int Id { get; set; }

        // This maps to artist_id in the database
        public int ArtistId { get; set; }
        
        // This maps to painting_title in the database
        public string Title { get; set; }
    }
}
