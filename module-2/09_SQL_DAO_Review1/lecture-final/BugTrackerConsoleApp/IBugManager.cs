using System.Collections.Generic;

namespace BugTrackerConsoleApp
{
    public interface IBugManager
    {
        List<Bug> GetAllBugs();
        Bug AddBug(Bug newBug);
        bool DeleteBug(int bugId);
        bool CloseBug(int bugId);
    }
}
