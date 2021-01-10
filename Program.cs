using HRAdminAPI;
using System;
using System.Collections.Generic;
using WorkHRAdmin;
using System.Linq;

namespace WorkHRAdmin
{
    public enum EmployeeType
    {
        Tech,
        Enrollment,
        Accounting,
        Sales
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Employee> employees = new List<Employee>();

            Data(employees);

            //Finds total salary of all employees using System.Linq;          
            Console.WriteLine($"Total Salary: {employees.Sum(e => e.salary)}");

            Console.ReadKey();
        }
        public static void Data(List<Employee> employees)
        {
            //Hardcode data
            
            Employee workerTech = EmployeeCreate.GetEmployeeInfo(EmployeeType.Tech, 1, "Tech", "Worker", 25000);
            Employee workerEnrollment = EmployeeCreate.GetEmployeeInfo(EmployeeType.Tech, 2, "Enrollment", "Worker", 25000);
            Employee workerAccounting = EmployeeCreate.GetEmployeeInfo(EmployeeType.Tech, 3, "Accounting", "Worker", 25000);
            Employee workerSales = EmployeeCreate.GetEmployeeInfo(EmployeeType.Tech, 4, "Sales", "Worker", 25000);

            employees.Add(workerTech);
            employees.Add(workerEnrollment);
            employees.Add(workerAccounting);
            employees.Add(workerSales);



        }
    }
    public class Tech : EmployeeBase
    {
        
    }
    public class Enrollment : EmployeeBase
    {

    }
    public class Accounting : EmployeeBase
    {

    }
    public class Sales : EmployeeBase
    {

    }
    public static class EmployeeCreate
    {
        public static Employee GetEmployeeInfo(EmployeeType employeeType, int id, string firstName,
            string lastName, decimal salary)
        {
            Employee employee = null;

            switch (employeeType)
            {
                case EmployeeType.Tech:
                    employee = new Tech
                    {
                        id = id,
                        firstName = firstName,
                        lastName = lastName,
                        salary = salary
                    };
                    break;
                case EmployeeType.Enrollment:
                    employee = new Enrollment
                    {
                        id = id,
                        firstName = firstName,
                        lastName = lastName,
                        salary = salary
                    };
                    break;
                case EmployeeType.Accounting:
                    employee = new Accounting
                    {
                        id = id,
                        firstName = firstName,
                        lastName = lastName,
                        salary = salary
                    };
                    break;
                case EmployeeType.Sales:
                    employee = new Sales
                    {
                        id = id,
                        firstName = firstName,
                        lastName = lastName,
                        salary = salary
                    };
                    break;
                default:
                    break;
            }

            return employee;

        }
    }
    
}
