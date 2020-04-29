using System;
using System.Collections.Generic;

namespace TestArea
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            //This uses a Lambda expression in place of the instantiated delegate that points to a custom method.
            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);

            //Instantiated delegate
            //IsPromotable isPromotable = new IsPromotable(Promote);

            //This calls the method in another class that takes in a delegate as a parameter(a method)
            //Employee.PromoteEmployee(empList, isPromotable);
        }
        //This iss the Custom method used by the instantiated delegate above (not needed if you use a Lambda Expression inplace of the delegae parameter)
        //public static bool Promote(Employee emp)
        //{
        //    if(emp.Experience >= 5)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }

    public delegate bool IsPromotable(Employee empl);

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }
}
