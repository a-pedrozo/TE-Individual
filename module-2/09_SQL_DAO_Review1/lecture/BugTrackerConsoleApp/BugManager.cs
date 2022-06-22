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
        // Fields (Class Variables)
        private List<Bug> bugs = new List<Bug>();
        private int nextBugId = 1;

        // Constructor
        public BugManager() : base()
        {
            
        }

        // Properties

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

        public void Load(IBugLoader bugLoader)
        {
            this.bugs = bugLoader.LoadBugs();
        }

        // Methods

        /// <summary>
        /// Finds a bug with a specified ID or returns null.
        /// </summary>
        /// <param name="id">The ID to look for</param>
        /// <returns>The first matching bug, or null</returns>
        public Bug FindBug(int id)
        {
            foreach (Bug bug in bugs)
            {
                // Is this bug the one we're looking for?
                if (bug.Id == id)
                {
                    return bug;
                }
            }

            return null;
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
            }

            bugs.Add(newBug);

            EnsureNextBugIdIsValid();
        }

        /// <summary>
        /// Makes sure that the next bug ID we generate is greater than any other 
        /// bug ID we have access to. This will never make nextBugId smaller
        /// </summary>
        private void EnsureNextBugIdIsValid()
        {
            foreach (Bug bug in bugs)
            {
                if (bug.Id >= nextBugId)
                {
                    nextBugId = bug.Id + 1;
                }
            }
        }
    }
}
