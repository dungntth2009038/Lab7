using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab7
{
    public class EmployeeManager
    {
        private Dictionary<string, Employee> _employees = new Dictionary<string, Employee>();
        public void Create()
        {
            Console.WriteLine("Please enter ID: ");
            var id = Console.ReadLine();
            Console.WriteLine("Please enter employee name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter salary: ");
            var salary = double.Parse(Console.ReadLine());
            _employees.Add(id,new Employee()
            {
                Name = name,
                Age = age,
                Salary = salary
            });
        }
        public void Display ()
        {
            foreach (var list in _employees)
            {
                Console.WriteLine($"ID: {list.Key},{list.Value}");
            }
        }
        public void Modify()
        {
            Console.WriteLine("Please enter ID: ");
            var id = Console.ReadLine();
            if (_employees.ContainsKey(id))
            {
                Console.WriteLine("Change the employee name to: ");
                var name = Console.ReadLine();
                Console.WriteLine("Change employee age to: ");
                var age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Change employee salary to: ");
                var salary = double.Parse(Console.ReadLine());
                _employees[id].Name = name;
                _employees[id].Age = age;
                _employees[id].Salary = salary;
            }
            else
            {
                Console.WriteLine("You must enter the employee ID!");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Please enter ID: ");
            var id = Console.ReadLine();
            if (_employees.ContainsKey(id))
            {
                _employees.Remove(id);
            }
            else
            {
                Console.WriteLine("You must enter the employee ID!");
            }
        }
    }
}