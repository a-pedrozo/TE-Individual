namespace Exercises.Classes
{
    public class Employee
    {
        public int Employeeld { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double AnnualSalary { get; private set; }

        public string FullName
        {
            get
            {
                string FullName = LastName + FirstName;
                return FullName;

            }
        }
        public Employee(int employeeID, string firstName, string lastName, double salary)
        {
            this.Employeeld = employeeID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = salary;
        }

        public void RaiseSalery(double percent)
        {

        }

    }
}
