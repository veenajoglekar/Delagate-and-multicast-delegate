using System;
using System.Collections.Generic;


namespace DelegateUsage1
{
    delegate bool IsExperienceGreater(Employee empl);
    delegate bool IsSalaryGreater(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public DateTime DateOfJoining { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsExperienceGreater IsEmployeeExperienced, IsSalaryGreater SalaryGreater )
        {
            foreach (Employee employee in employeeList)
            {
                if (IsEmployeeExperienced(employee))
                {
                    Console.WriteLine(employee.Name + " has experience greater than 5 yrs");
                }
                if ( SalaryGreater(employee))
                {
                    Console.WriteLine(employee.Name + " has salary greater than 25000");
                }

            }
        }

    }
    class Program
    {
        public delegate bool ExperienceCheck(Employee emp);

        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 20000, DateOfJoining = new DateTime(2015, 7, 24) });
            empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 40000, DateOfJoining = new DateTime(2020, 7, 24) });
            empList.Add(new Employee() { ID = 101, Name = "John", Salary = 60000, DateOfJoining = new DateTime(2010, 7, 24) });
            empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 10000, DateOfJoining = new DateTime(2005, 7, 24) });

            //IsPromotable isPromotable = new IsPromotable(Promote);
            // Employee.PromoteEmployee(empList, isPromotable);

            
            Employee.PromoteEmployee(empList, experienceCheck , salaryCheck);
               

        }



        public static bool experienceCheck(Employee emp)
        {
            double days = DateTime.Now.Subtract(emp.DateOfJoining).TotalDays;
            if (days > 1825)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool salaryCheck(Employee emp)
        {
            if (emp.Salary > 25000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
