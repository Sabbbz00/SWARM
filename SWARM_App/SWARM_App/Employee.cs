using System;
namespace SWARM_App
{
    public class Employee : Person
    {
		public int EmployeeType { get; set; }
		public string EmployeeID { get; set; }

        public Employee()
        {
        }
		public Employee(string name, string address, string phone, string email, int employeeType, string employeeid)
		{
			this.Name = name;
			this.Address = address;
			this.Phone = phone;
			this.Email = email;
            EmployeeType = employeeType;
            EmployeeID = employeeid;
		}
    }
}
