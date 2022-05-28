using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.ClassReview
{
    public class Bug
    {
        public int ID { get; set; } = -1; // default values are 0, false, null 
        public bool IsOpen { get; set; } = true; // this is one way of customizng default values
        public string CreatedBy { get; set; } = "unknown";
        public string Name { get; set; } = "Untitled Bug";

        public Bug()
        {

        }

        public Bug(int id, string createdBy, string name)
        {
            this.ID = id;
            this.CreatedBy = createdBy;
            this.Name = name;

        }


    }
}
