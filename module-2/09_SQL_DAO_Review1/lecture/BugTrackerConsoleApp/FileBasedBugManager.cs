using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// Responsible for reading bugs from a comma separated value (CSV) file.
    /// </summary>
    public class FileBasedBugManager : IBugManager
    {
        private readonly string filePath;
        private List<Bug> bugs = new List<Bug>();
        private int nextBugId = 1;

        public FileBasedBugManager(string filePath)
        {
            this.filePath = filePath;
        }

        public Bug AddBug(Bug newBug)
        {
            newBug.Id = GetNextValidId();
            bugs.Add(newBug);

            SaveBugsToFile();

            return newBug;
        }

        public List<Bug> GetAllBugs()
        {
            bugs = new List<Bug>();

            // Open the file for reading
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Loop over the lines of the file
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Each row looks like this:
                    // 1, The app doesn't list bugs, Jimothy, true
                    string[] fields = line.Split(",");

                    int id = int.Parse(fields[0]);
                    string summary = fields[1];
                    string author = fields[2];
                    bool isOpen = bool.Parse(fields[3]);

                    // For each line, create a Bug instance for that line
                    Bug newBug = new Bug(summary);
                    newBug.Id = id;
                    newBug.ResponsibleDev = author;
                    newBug.IsOpen = isOpen;

                    // Add the bug to the result list
                    bugs.Add(newBug);
                }
            }

            return bugs;
        }

        public Bug UpdateBug(Bug updatedBug)
        {
            SaveBugsToFile();

            return updatedBug;
        }

        private void SaveBugsToFile()
        {
            // Open the file for writing
            bool shouldAppend = false;
            using (StreamWriter writer = new StreamWriter(filePath, shouldAppend))
            {
                // Write all bugs to the file
                foreach (Bug bug in bugs)
                {
                    writer.WriteLine($"{bug.Id},{bug.Summary},{bug.ResponsibleDev},{bug.IsOpen}");
                }
            }
        }

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
        /// Makes sure that the next bug ID we generate is greater than any other 
        /// bug ID we have access to. This will never make nextBugId smaller
        /// </summary>
        private int GetNextValidId()
        {
            foreach (Bug bug in bugs)
            {
                if (bug.Id >= nextBugId)
                {
                    nextBugId = bug.Id + 1;
                }
            }

            return nextBugId;
        }

        public bool CloseBug(int bugId)
        {
            Bug bug = FindBug(bugId);

            if (bug == null)
            {
                return false;
            }
            else
            {
                bug.IsOpen = false;
                return true;
            }
        }

        public bool DeleteBug(int bugId)
        {
            Bug bug = FindBug(bugId);

            if (bug == null)
            {
                return false;
            }
            else
            {
                bugs.Remove(bug);

                SaveBugsToFile();

                return true;
            }

        }
    }
}
