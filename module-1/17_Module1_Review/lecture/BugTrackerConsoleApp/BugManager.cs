using BugTrackerConsoleApp.Items;
using System;
using System.Collections.Generic;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// Responsible for tracking bugs
    /// </summary>
    public class BugManager
    {
        // Field or Class Variable
        private readonly List<Bug> bugs = new List<Bug>();

        private int nextBugId = 1;

        public BugManager() : base()
        {
            
        }

        /// <summary>
        /// Adds a new bug
        /// </summary>
        /// <param name="newBug">The bug to add</param>
        public void AddBug(Bug newBug)
        {
            // Ensure the bug we're adding has a good ID
            if (newBug.Id <= 0)
            {
                newBug.Id = nextBugId;
                nextBugId += 1;
            }

            bugs.Add(newBug);
        }


        /// <summary>
        /// Finds a bug with a specified ID or returns null.
        /// </summary>
        /// <param name="id">The ID to look for</param>
        /// <returns>The first matching bug, or null</returns>
        public Bug FindBug(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets an unmodifiable array of the current bugs
        /// </summary>
        public Bug[] AllBugs
        {
            get
            {
                return bugs.ToArray();
            }
        }
    }
}
