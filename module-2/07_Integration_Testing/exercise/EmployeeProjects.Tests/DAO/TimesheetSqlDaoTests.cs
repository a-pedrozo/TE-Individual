using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using EmployeeProjects.DAO;
using EmployeeProjects.Models;

namespace EmployeeProjects.Tests.DAO
{
    [TestClass]
    public class TimesheetSqlDaoTests : BaseDaoTests
    {
        private readonly Timesheet timesheet1 = new Timesheet(1, 1, 1, DateTime.Parse("2021-01-01"), 1.0M, true, "Timesheet 1");
        private readonly Timesheet timesheet2 = new Timesheet(2, 1, 1, DateTime.Parse("2021-01-02"), 1.5M, true, "Timesheet 2");
        private readonly Timesheet timesheet3 = new Timesheet(3, 2, 1, DateTime.Parse("2021-01-01"), 0.25M, true, "Timesheet 3");
        private readonly Timesheet timesheet4 = new Timesheet(4, 2, 2, DateTime.Parse("2021-02-01"), 2.0M, false, "Timesheet 4");

        private TimesheetSqlDao dao;


        [TestInitialize]
        public override void Setup()
        {
            dao = new TimesheetSqlDao(ConnectionString);
            base.Setup();
        }

        [TestMethod]
        public void GetTimesheet_ReturnsCorrectTimesheetForId()
        {
            TimesheetSqlDao dao = new TimesheetSqlDao(ConnectionString);

            Timesheet timesheet = dao.GetTimesheet(4);
            Assert.AreEqual(4,timesheet.TimesheetId);
        }

        [TestMethod]
        public void GetTimesheet_ReturnsNullWhenIdNotFound()
        {
            //arrrange 
            TimesheetSqlDao dao = new TimesheetSqlDao(ConnectionString);
            
            //act
            Timesheet result = dao.GetTimesheet(0);
            //assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void GetTimesheetsByEmployeeId_ReturnsListOfAllTimesheetsForEmployee()
        {
            //arrange
            TimesheetSqlDao dao = new TimesheetSqlDao(ConnectionString);
            //list or ienumrable????
            //act
            IList<Timesheet> result = dao.GetTimesheetsByEmployeeId(2);
            //assert
            
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void GetTimesheetsByProjectId_ReturnsListOfAllTimesheetsForProject()
        {
            //arrange
            TimesheetSqlDao dao = new TimesheetSqlDao(ConnectionString);
            //act
            IList<Timesheet> result = dao.GetTimesheetsByProjectId(1);
            //assert
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void CreateTimesheet_ReturnsTimesheetWithIdAndExpectedValues()
        {
            //arrange
            TimesheetSqlDao dao = new TimesheetSqlDao(ConnectionString);
            //act
            Timesheet timesheet = new Timesheet();
            timesheet.TimesheetId = 5; // what numbers go here???
            timesheet.EmployeeId = 2;
            timesheet.ProjectId = 2;
            timesheet.DateWorked = DateTime.Parse("2021-01-01");
            timesheet.HoursWorked = 6.9m;
            timesheet.IsBillable = false;
            timesheet.Description = "doesmanos";

             Timesheet newSheet = dao.CreateTimesheet(timesheet);

            //asert

            Assert.AreEqual(5,newSheet.TimesheetId);

        }

        [TestMethod]
        public void CreatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            //arrange
            TimesheetSqlDao dao = new TimesheetSqlDao(ConnectionString);
            //act
            Timesheet timesheet = new Timesheet();
            //timesheet.TimesheetId = 5; // what numbers go here???
            timesheet.EmployeeId = 2;
            timesheet.ProjectId = 2;
            timesheet.DateWorked = DateTime.Parse("2021-01-01");
            timesheet.HoursWorked = 6.9m;
            timesheet.IsBillable = false;
            timesheet.Description = "doesmanos";

            Timesheet newSheet = dao.CreateTimesheet(timesheet);

            //asert

            Assert.AreEqual(5, newSheet.TimesheetId);

        }

        [TestMethod]
        public void UpdatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            //arrange
            TimesheetSqlDao dao = new TimesheetSqlDao(ConnectionString);
            //act
            Timesheet timesheet = new Timesheet();
            timesheet.TimesheetId = 5; // what numbers go here???
            timesheet.EmployeeId = 2;
            timesheet.ProjectId = 2;
            timesheet.DateWorked = DateTime.Parse("2021-01-01");
            timesheet.HoursWorked = 6.9m;
            timesheet.IsBillable = false;
            timesheet.Description = "doesmanos";

            Timesheet newSheet = dao.CreateTimesheet(timesheet);
            //assert 
            Assert.AreEqual(5,newSheet.TimesheetId);
        }

        [TestMethod]
        public void DeletedTimesheetCantBeRetrieved()
        {
            TimesheetSqlDao dao = new TimesheetSqlDao(ConnectionString);
            Timesheet timesheet = new Timesheet();
            timesheet.EmployeeId = 2;
            timesheet.ProjectId = 2;
            timesheet.DateWorked = DateTime.Parse("2021-01-01");
            timesheet.HoursWorked = 6.9m;
            timesheet.IsBillable = false;
            timesheet.Description = "doesmanos";


            // Act
             dao.DeleteTimesheet(timesheet.TimesheetId);//why wont this work???

             //Assert
               Assert.AreEqual(0, timesheet.TimesheetId);
        }

        [TestMethod]
        public void GetBillableHours_ReturnsCorrectTotal()
        {
            //arrange
            TimesheetSqlDao dao = new TimesheetSqlDao(ConnectionString);

            //act
           
            Timesheet timesheet = new Timesheet();
            timesheet.EmployeeId = 1;
            timesheet.ProjectId = 1;
            timesheet.DateWorked = DateTime.Parse("2021-01-01");
            timesheet.HoursWorked = 1.0m;
            timesheet.IsBillable = true;
            timesheet.Description = "timesheet1";
            decimal timesheet1 = dao.GetBillableHours(1,1);

            //assert

            Assert.AreEqual(1,timesheet1);
        }

        private void AssertTimesheetsMatch(Timesheet expected, Timesheet actual)
        {
            Assert.AreEqual(expected.TimesheetId, actual.TimesheetId);
            Assert.AreEqual(expected.EmployeeId, actual.EmployeeId);
            Assert.AreEqual(expected.ProjectId, actual.ProjectId);
            Assert.AreEqual(expected.DateWorked, actual.DateWorked);
            Assert.AreEqual(expected.HoursWorked, actual.HoursWorked);
            Assert.AreEqual(expected.IsBillable, actual.IsBillable);
            Assert.AreEqual(expected.Description, actual.Description);
        }
    }
}
