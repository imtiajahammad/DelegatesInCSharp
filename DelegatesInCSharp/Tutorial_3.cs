using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp
{
    public delegate bool IsPromotable(EmployeeModel empl);
    /// <summary>
    /// Tutorial_2 implementation with delegates to make EmployeeModel.PromoteEmployee reusable with multiple promotion logic
    /// </summary>
    public class Tutorial_3
    {
        public Tutorial_3()
        {
            EmployeeModel employee = new EmployeeModel();
            List<EmployeeModel> empList = new List<EmployeeModel>();
            empList.Add(new EmployeeModel() { ID = 101, Name = "Mary", Salary = 5000, ExperienceYears = 5 });
            empList.Add(new EmployeeModel() { ID = 102, Name = "Mike", Salary = 4000, ExperienceYears = 4 });
            empList.Add(new EmployeeModel() { ID = 103, Name = "John", Salary = 6000, ExperienceYears = 6 });
            empList.Add(new EmployeeModel() { ID = 104, Name = "Todd", Salary = 3000, ExperienceYears = 3 });
            IsPromotable isPromotable = new IsPromotable(Promote);
           employee.PromoteEmployee(empList, isPromotable);


            ///you can also send lambda expression for the functin pointer
            Console.WriteLine("\r\nTutorial_3-implementation with lambda expression-start");
            employee.PromoteEmployee(empList, emp => emp.ExperienceYears >= 5);
            Console.WriteLine("Tutorial_3-implementation with lambda expression-end\r\n");
        }

        /// <summary>
        /// creating a function when needed having the similar signature of the delegate so that we can send dynamic function pointer to PromoteEmployee function
        /// </summary>
        /// <param name="emp">Employee model with id, name and salary</param>
        /// <returns>boolean return if promotable yes or not</returns>
        bool Promote(EmployeeModel emp)
        {
            if (emp.ExperienceYears >= 5)
            {
                return true;
            }
            return false;
        }
    }



























    public class EmployeeModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int ExperienceYears { get; set; }



        /// <summary>
        /// a function which accepts a function parameter to check if any employee is eligible for promotion.
        /// Here the eligibility logic is dynamic as we are sending a function pointer. We can also send an inline lambda expression for the function pointer
        /// </summary>
        /// <param name="employeeList">a list of employees with employee name, id and salaries</param>
        /// <param name="IsEligibleToPromote"> a function pointer with a bool return type</param>
        public void PromoteEmployee(List<EmployeeModel> employeeList,IsPromotable IsEligibleToPromote)
         {
            foreach (EmployeeModel employeeModel in employeeList)
            {
                if (IsEligibleToPromote(employeeModel))
                {
                    Console.WriteLine(employeeModel.Name + " promoted");
                }
            }
        }
    }
}
