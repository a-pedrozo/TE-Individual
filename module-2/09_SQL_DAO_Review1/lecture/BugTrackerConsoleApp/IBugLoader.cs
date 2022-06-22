using BugTrackerConsoleApp.Items;
using System.Collections.Generic;

namespace BugTrackerConsoleApp
{
    public interface IBugLoader
    {
        List<Bug> LoadBugs();
    }
}