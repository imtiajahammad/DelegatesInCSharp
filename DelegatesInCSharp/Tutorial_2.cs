using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp
{
    class Tutorial_2
    {
        public Tutorial_2()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, ExperienceYears = 5 });
            empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, ExperienceYears = 4 });
            empList.Add(new Employee() { ID = 103, Name = "John", Salary = 6000, ExperienceYears = 6 });
            empList.Add(new Employee() { ID = 104, Name = "Todd", Salary = 3000, ExperienceYears = 3 });
            Employee employee = new Employee();
            employee.PromoteEmployee(empList);
            /// All on a sudden, if your company policies change for promotion,
            /// you may have to change the logic of the Employee.PromoteEmployee function, as it is hard coded. 
            /// changing hard coded logic or keeping hard coded logics are bad practices
            /// to make it reusable, this PromoteEmployee should be called from anywhere without depending on making instance of it
            /// also PromoteEmployee must have some options to imply the promotion logic however you want without touching the method hard code.


        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int ExperienceYears { get; set; }
        /// <summary>
        /// calculate if any employee has more or equal than 5 years of experience; if so he/she is eligible for promotion
        /// </summary>
        /// <param name="employeeList">its a list of employees with their ids, names and salaries</param>
        public void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                if (employee.ExperienceYears >= 5)
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }
}
