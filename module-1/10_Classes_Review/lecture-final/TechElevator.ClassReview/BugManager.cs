using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.ClassReview
{
    public class BugManager
    {
        private List<Bug> bugs = new List<Bug>();

        public Bug Add(Bug newBug)
        {
            bugs.Add(newBug);

            return newBug;
        }
    }
}
