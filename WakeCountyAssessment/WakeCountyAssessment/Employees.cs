namespace WakeCountyAssessment
{
    public class Employees
    {
        public Employees(int id, string firstname, string lastname, string department, DateTime hiredate)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            Department = department;
            HireDate = hiredate;
        }

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public DateTime HireDate { get; set; }
    }
}