using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// Represents a bug in the system.
    /// </summary>
    public class Bug
    {
        public Bug()
        {

        }

        public Bug(string summary)
        {
            this.Summary = summary;
        }

        /// <summary>
        /// The unique identifier for the bug
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The details associated with the bug
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// The name of the developer who summoned the bug into existence
        /// </summary>
        public string ResponsibleDev { get; set; } = "Jimothy"; // Dangit, Jimothy!

        /// <summary>
        /// Whether or not the bug is currently unresolved
        /// </summary>
        public bool IsOpen { get; set; } = true;

        public override string ToString()
        {
            string isOpenText = "Open";
            if (!IsOpen)
            {
                isOpenText = "Closed";
            }

            return $"{Id}) {Summary} ({isOpenText})";
        }
    }
}
