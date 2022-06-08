using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BugTrackerConsoleApp.Items;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// Responsible for reading and writing bugs to a comma separated value (CSV) file.
    /// </summary>
    public class BugCSVFile
    {
        public void ImportFromFile(string filePath, BugManager bugManager)
        {

            // Open the file for reading
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Loop over the lines of the file
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Each row looks like this:
                    // 1, The app doesn't list bugs, Jimothy, Startup, true
                    string[] fields = line.Split(",");

                    int id = int.Parse(fields[0]);
                    string summary = fields[1];
                    string author = fields[2];
                    string location = fields[3];
                    bool isOpen = bool.Parse(fields[4]);

                    // For each line, create a Bug instance for that line
                    Bug newBug = new Bug(summary);
                    newBug.Id = id;
                    newBug.ResponsibleDev = author;
                    newBug.Location = location;
                    newBug.IsOpen = isOpen;

                    // Add the bug to a bug manager
                    bugManager.AddBug(newBug);
                }
            }

        }
    }
}
