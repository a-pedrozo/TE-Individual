using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTrackerConsoleApp;
using BugTrackerConsoleApp.Items;

namespace BugTrackerTests
{
    [TestClass]
    public class BugManagerTests
    {
        [TestMethod]
        public void FindBugShouldFindTheBug()
        {
            // Arrange
            BugManager manager = new BugManager();
            manager.AddBug(new Bug("TestBug"));

            // Act
            WorkItem bug = manager.FindBug(1);

            // Assert
            Assert.IsNotNull(bug);
            Assert.AreEqual(1, bug.Id);
            Assert.AreEqual("TestBug", bug.Summary);
        }

        [TestMethod]
        public void FindBugShouldReturnNullWhenNotThere()
        {
            // Arrange
            BugManager manager = new BugManager();

            // Act
            WorkItem bug = manager.FindBug(42);

            // Assert
            Assert.IsNull(bug);
        }
    }
}
