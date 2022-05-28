using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.ClassReview
{
    public class BugManager
    {
        private List<Bug> bugs = new List<Bug>();
        public Bug Add(Bug newBug) // adding a bug and return new bug 
        {
            bugs.Add(newBug);

            return newBug;
        }
    }
}
