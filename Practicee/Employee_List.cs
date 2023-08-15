using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double salary { get; set; }
        //List<Employee> Employees { get; set; }
        public static void  Showsalary(List<Employee> list)
        {
            foreach (Employee emp in list)
            {
                if (emp.salary > 25000)
                {
                    Console.WriteLine(emp.salary);
                }
            }
        }
        public static void IncreaseSalary(List<Employee> list)
        {
            foreach (Employee item in list)
            {
                if (item.salary > 25000)
                {
                    item.salary = item.salary + (item.salary * 0.2);
                    Console.WriteLine($"id={item.Id},Name={item.Name},Salary={item.salary}");
                }
            }
        }
        static void Main(string[] args)
        {
           // Employee employee = new Employee();
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { Id = 1, Name = "Vidyashree", salary = 25000 });
            list.Add(new Employee { Id = 2, Name = "Akshata", salary = 35000 });
            list.Add(new Employee { Id = 3, Name = "Anjali", salary = 45000 });
            list.Add(new Employee { Id = 1, Name = "Snehal", salary = 30000 });
            //foreach (Employee item in list)
            //{
            //    Console.WriteLine($"id={item.Id},Name={item.Name},Salary={item.salary}");
            //}
            Dictionary<double,List<string>> dic =new Dictionary<double,List<string>>();
            
            foreach (Employee item in list)
            {
                if (item.salary > 25000) 
                {
                    Console.WriteLine($"id={item.Id},Name={item.Name},Salary={item.salary}");
                }
            }
            Employee.Showsalary(list);
            Employee.IncreaseSalary(list);

        }
        
    }
}
