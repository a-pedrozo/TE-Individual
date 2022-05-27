using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.ClassReview
{
    public class Bug
    {
        public int Id { get; set; } = -1;
        public bool IsOpen { get; set; } = true;
        public string CreatedBy { get; set; } = "Unknown";
        public string Name { get; set; } = "Untitled Bug";

        public Bug()
        {

        }


        public Bug(int id, string createdBy, string name)
        {
            this.Id = id;
            this.CreatedBy = createdBy;
            this.Name = name;
        }
    }
}
